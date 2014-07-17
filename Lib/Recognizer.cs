using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVN.Lib
{
    class Recognizer
    {
        public Recognizer()
        {
            InitializeSettings();

            GeneralTraining();
            CreateNetwork();
            asyCallBack = new AsyncCallback(TraningCompleted);
            BeginTraining();
        }

        public RecognizeSet Recognize(Image src)
        {
            String[] hightResult = new String[5];
            String[] lowResult   = new String[5];
            Double hightRate = 0, lowRate = 0;
            
            StringBuilder sbHigh = new StringBuilder();
            StringBuilder sbLow = new StringBuilder();
            Bitmap bimapImage = new Bitmap(src);

            float widthRatio = getRatio(860, bimapImage.Width);
            float heightRatio = getRatio(110, bimapImage.Height);

            var newWidth = (int)(bimapImage.Width * widthRatio);
            var newHeight = (int)(bimapImage.Height * heightRatio);
            InitializeSettings();
            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(bimapImage, 0, 0, newWidth, newHeight);

            Dictionary<MyPoint, Bitmap> Images = ImageProcessing.Findboundary(newImage);

            Dictionary<int, RecognizeSingle> Results = new Dictionary<int, RecognizeSingle>();
            int count = 1;
            
            foreach (var image in Images.OrderByDescending(p => p.Key.X).ThenBy(p => p.Key.Y))
            {
                Results.Add(count, RecongzieEMeter(image.Value));
                count++;
            }
            count = 0;
            foreach (var result in Results)
            {
                if (result.Key <= 5)
                {
                    hightResult[5 - result.Key] = result.Value.MatchedHight;
                    lowResult[5 - result.Key] = result.Value.MatchedHight;
                    hightRate += result.Value.HightRate;
                    lowRate += result.Value.LowRate;
                    count++;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                sbHigh.Append(hightResult[i]);
                sbLow.Append(hightResult[i]);
            }
            hightRate /= count;
            lowRate /= count;
            return new RecognizeSet(sbHigh.ToString(), sbLow.ToString(), hightRate, lowRate);
        }
        //Neural network object with output type string
        private NeuralNetwork<string> neuralNetwork = null;

        //Data members require for neural network
        private Dictionary<string, double[]> TrainingSet = null;
        private int av_ImageHeight = 0;
        private int av_ImageWidth = 0;
        private int NumOfPatterns = 0;
        private int NumOfLayers = 0;
        private string patternDirectory = null;

        //For Asynchronized Programming Instead of Handling Threads
        private delegate bool TrainingCallBack();
        private AsyncCallback asyCallBack = null;
        private IAsyncResult res = null;

        private DateTime DTStart;


        private void BeginTraining()
        {
            Console.WriteLine("Begin Training Process..\r\n");
            TrainingCallBack TR = new TrainingCallBack(neuralNetwork.Train);
            res = TR.BeginInvoke(asyCallBack, TR);
            DTStart = DateTime.Now;
        }

        private void TraningCompleted(IAsyncResult result)
        {
            if (result.AsyncState is TrainingCallBack)
            {
                TrainingCallBack TR = (TrainingCallBack)result.AsyncState;

                bool isSuccess = TR.EndInvoke(res);
                if (isSuccess)
                {
                    Console.WriteLine("Training Process Successfully\r\n");
                }
                else
                {
                    Console.WriteLine("Training Process is Aborted or Exceed Maximum Iteration\r\n");
                }
            }
        }

        private RecognizeSingle RecongzieEMeter(Bitmap imageBitmap)
        {
            Color pixelColor = imageBitmap.GetPixel(0, 0);
            if (pixelColor.R < 100 && pixelColor.G < 100 && pixelColor.B < 100)
                ImageProcessing.ApplyInvert(ref imageBitmap);
            ImageProcessing.AdjustContrast(ref imageBitmap, 150);

            double[] input = ImageProcessing.ToMatrix(imageBitmap,
                av_ImageHeight, av_ImageWidth);
            string MatchedHigh = "?", MatchedLow = "?";
            double OutputValueHight = 0, OutputValueLow = 0;
            neuralNetwork.Recognize(input, ref MatchedHigh, ref OutputValueHight,
                ref MatchedLow, ref OutputValueLow);

            return new RecognizeSingle(MatchedHigh, MatchedLow, OutputValueHight, OutputValueLow);
        }

        private void InitializeSettings()
        {
            try
            {
                NameValueCollection AppSettings = ConfigurationManager.AppSettings;
                patternDirectory = Path.GetFullPath(AppSettings["PatternsDirectory"]);
                NumOfLayers = Int16.Parse(AppSettings["NumOfLayers"]);

                string[] Images = Directory.GetFiles(patternDirectory, "*.bmp");
                NumOfPatterns = Images.Length;

                av_ImageHeight = 0;
                av_ImageWidth = 0;

                foreach (string s in Images)
                {
                    Bitmap Temp = new Bitmap(s);
                    av_ImageHeight += Temp.Height;
                    av_ImageWidth += Temp.Width;
                    Temp.Dispose();
                }
                av_ImageHeight /= NumOfPatterns;
                av_ImageWidth /= NumOfPatterns;
                av_ImageWidth = 27;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Initializing Settings: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeneralTraining()
        {
            string[] Patterns = Directory.GetFiles(patternDirectory, "*.bmp");

            TrainingSet = new Dictionary<string, double[]>(Patterns.Length);
            foreach (string s in Patterns)
            {
                Bitmap tempPic = new Bitmap(s);
                TrainingSet.Add(Path.GetFileNameWithoutExtension(s), ImageProcessing.ToMatrix(tempPic, av_ImageHeight, av_ImageWidth));
                tempPic.Dispose();
            }
        }

        private void CreateNetwork()
        {
            if (TrainingSet == null)
                throw new Exception("Unable to Create Neural Network As There is No Data to Train..");
            neuralNetwork = new NeuralNetwork<string>(new BPLayer<string>(av_ImageHeight * av_ImageWidth, NumOfPatterns), TrainingSet);
            neuralNetwork.MaximumError = Double.Parse(ConfigurationManager.AppSettings["MaxError"]);
        }
        private float getRatio(int standardWidth, int sourceWidth)
        {
            return (float)standardWidth / (float)sourceWidth;
        }
    }
}
