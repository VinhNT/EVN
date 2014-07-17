using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVN.Lib
{
    class ImageProcessing
    {        

        public static Dictionary<MyPoint, Bitmap> Findboundary(Bitmap bitmapImage)
        {
            ConnectedComponent ccl = new ConnectedComponent();
            IDictionary<int, ImageProperty> images = ccl.ProcessImage(bitmapImage);
            var filterImages = new Dictionary<MyPoint, Bitmap>();
            int count = 1;

            foreach (var pattern in images)
            {
                if (pattern.Value.Width > 40 && pattern.Value.Heigth > 70)
                {
                    int height = pattern.Value.Heigth;
                    int Width = pattern.Value.Width;

                    if (pattern.Value.Width > 95)
                        Width = 95;
                    if (pattern.Value.Width < 50)
                        Width = 70;

                    if (pattern.Value.Width > 200)
                    {   
                        Rectangle size1 = new Rectangle(pattern.Value.Position.X, pattern.Value.Position.Y, Width, height);
                        Bitmap bufferImage = bitmapImage.Clone(size1, bitmapImage.PixelFormat);

                        MyPoint point1 = new MyPoint();
                        point1.X = pattern.Value.Position.X;
                        point1.Y = pattern.Value.Position.Y;

                        filterImages.Add(point1, bufferImage);

                        MyPoint point2 = new MyPoint();
                        point2.X = pattern.Value.Position.X + pattern.Value.Width - 95;
                        point2.Y = pattern.Value.Position.Y;

                        Rectangle size2 = new Rectangle(point2.X, point2.Y, Width, height);
                        Bitmap bufferImage1 = bitmapImage.Clone(size2, bitmapImage.PixelFormat);

                        filterImages.Add(point2, bufferImage1);
                    }
                    else
                    {
                        Rectangle newSize = new Rectangle(pattern.Value.Position.X, pattern.Value.Position.Y, Width, height);
                        Bitmap bufferImage = bitmapImage.Clone(newSize, bitmapImage.PixelFormat);
                        MyPoint mPoint = new MyPoint();
                        mPoint.X = pattern.Value.Position.X;
                        mPoint.Y = pattern.Value.Position.Y;
                        filterImages.Add(mPoint, bufferImage);
                        count++;
                    }
                }
            }            

            return filterImages;
        }
        
        private static bool isBlackBackGround(Color colorPixel)
        {
            return colorPixel.R < 30 && colorPixel.G < 30 && colorPixel.B < 30;
        }

        public static void AdjustContrast(ref Bitmap bitmapImage, int threshold)
        {
            byte A, R, G, B;
            Color pixelColor;

            for (int y = 0; y < bitmapImage.Height; y++)
            {
                for (int x = 0; x < bitmapImage.Width; x++)
                {
                    pixelColor = bitmapImage.GetPixel(x, y);
                    A = pixelColor.A;
                    R = (Byte)PixelPick(pixelColor.R, pixelColor.G, pixelColor.B, threshold);
                    G = (Byte)PixelPick(pixelColor.R, pixelColor.G, pixelColor.B, threshold);
                    B = (Byte)PixelPick(pixelColor.R, pixelColor.G, pixelColor.B, threshold);
                    bitmapImage.SetPixel(x, y, Color.FromArgb((int)A >= 150 ? 255 : 0, (int)R, (int)G, (int)B));
                }
            }    
        }
        
        public static void ApplyInvert(ref Bitmap bitmapImage)  
        {  
            byte A, R, G, B;  
            Color pixelColor;  
  
            for (int y = 0; y < bitmapImage.Height; y++)  
            {  
                for (int x = 0; x < bitmapImage.Width; x++)  
                {  
                    pixelColor = bitmapImage.GetPixel(x, y);
                    A = pixelColor.A;
                    R = (byte)((255 - pixelColor.R) > 150 ? 255 : 0);
                    G = (byte)((255 - pixelColor.G) > 150 ? 255 : 0);
                    B = (byte)((255 - pixelColor.B) > 150 ? 255 : 0);

                    bitmapImage.SetPixel(x, y, Color.FromArgb((int)A, (int)R, (int)G, (int)B));  
                }  
            }    
        }

        private static int PixelPick(int R, int G, int B, int threshold)
        {
            if (R > threshold && G > threshold && B > threshold)
                return 255;            
            return 0;
        }        

        //Convert RGB to matrix of double
        public static double[] ToMatrix(Bitmap BM, int RowNumber, int ColumnNumber)
        {            
            double[] Result = new double[ColumnNumber * RowNumber];

            if (BM != null)
            {
                double HRate = ((Double)RowNumber / BM.Height);
                double WRate = ((Double)ColumnNumber / BM.Width);                

                for (int r = 0; r < RowNumber; r++)
                {
                    for (int c = 0; c < ColumnNumber; c++)
                    {
                        Color color = BM.GetPixel((int)(c / WRate), (int)(r / HRate));
                        Result[r * ColumnNumber + c] = 1 - (color.R * .3 + color.G * .59 + color.B * .11) / 255;
                    }
                }
            }
            return Result;
        }

        //Convert Double to Gray level
        public static Bitmap ToImage(double [] Matrix, int RowNumber, int ColumnNumber, int ImageHeight, int ImageWidth)
        {
            double HRate = ((Double)RowNumber / ImageHeight);
            double WRate = ((Double)ColumnNumber / ImageWidth);
            Bitmap Result = new Bitmap(ImageWidth, ImageHeight);

            for (int i = 0; i < ImageHeight; i++)
            {
                for (int j = 0; j < ImageWidth; j++)
                {
                    int x = (int)((double)j / WRate);
                    int y = (int)((double)i / HRate);

                    double temp = Matrix[y * ColumnNumber + x];
                    Result.SetPixel(j, i, Color.FromArgb((int)((1 - temp) * 255), (int)((1 - temp) * 255), (int)((1 - temp) * 255)));
                }
            }

            return Result;
        }

    }
}
