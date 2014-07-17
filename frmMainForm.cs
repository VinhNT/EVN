using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DirectX.Capture;
using System.Drawing.Imaging;
using System.Configuration;
using EVN.Lib;

namespace EVN
{
    public partial class frmMainForm : Form
    {
        private Filters filters;
        private Boolean isCapturing = false;
        private Capture captureDevice;
        private Boolean isTakeningPicture = false;        
        private int x, y;
        private Boolean isDrawingRectangle=false;
        private Image capturedImage;        
        private float rw, rh;
        private Rectangle selection;
        private Recognizer recognizer;
        private String LastCameraNameKey = "LastCameraName";
        private const int MAX_AVAILABLE_NUMBER_LEN = 7;

        public frmMainForm()
        {
            InitializeComponent();
            recognizer = new Recognizer();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            int lastSelectedIndex = -1;
            String lastSelectedCamera = AppSettingManager.ReadAppSetting(LastCameraNameKey);
            filters = new Filters();
            cboSelectVideoSource.Items.Clear();

            for (int i = 0; i < filters.VideoInputDevices.Count; i++)
            {
                Filter fc = filters.VideoInputDevices[i];
                cboSelectVideoSource.Items.Add(fc.Name);
                if (lastSelectedCamera.Equals(fc.Name))
                {
                    lastSelectedIndex = i;
                }
            }
            cboSelectVideoSource.SelectedIndex = lastSelectedIndex;
            HiddenMeterReading();
            ShowHideNumberKeyboard(false);
        }

        private void cmdPreview_Click(object sender, EventArgs e)
        {
            if (cboSelectVideoSource.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa lựa chọn camera...");
                return;
            }
            if (isTakeningPicture || isCapturing)
            {
                picPreview.Visible = true;
                picCapturedImage.Visible = false;                
                isTakeningPicture = false;
                releaseCaptureDevice();
            }
            HiddenMeterReading();
            isDrawingRectangle = false;
            startPreviewing();
            cboSelectVideoSource.Visible = false;
            ShowHideNumberKeyboard(false);
        }
        private void startPreviewing() {
            captureDevice = new Capture(filters.VideoInputDevices[cboSelectVideoSource.SelectedIndex], null);

            captureDevice.FrameSize = new Size(captureDevice.VideoCaps.MaxFrameSize.Width, captureDevice.VideoCaps.MaxFrameSize.Height);
            captureDevice.FrameRate = 15; //20frame/sec            
            tsRecognizeResult.Text = captureDevice.FrameSize.Width.ToString() + ":" + captureDevice.FrameSize.Height.ToString();
            captureDevice.PreviewWindow = this.picPreview;
            
            captureDevice.Cue();
            picCapturedImage.Visible = false;
            captureDevice.Start();
            isCapturing = true;
            
        }
        public void frmMainForm_FrameEvent2(PictureBox frame)
        {
            capturedImage = CopyImage(frame.Image);
            this.picCapturedImage.Image = capturedImage;
            captureDevice.Stop();
            this.picCapturedImage.Refresh();
            picPreview.Visible = false;
            picCapturedImage.Visible = true;
            rw = capturedImage.Width/ picCapturedImage.Width;
            rh = capturedImage.Height / picCapturedImage.Height;
        }
       
        private void releaseCaptureDevice() {
            if (captureDevice.Capturing) captureDevice.Stop();
            captureDevice.Dispose();
            isCapturing = false;
        }
        
        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (isCapturing && captureDevice.Capturing)
            {
                isTakeningPicture = true;
                captureDevice.FrameCaptureComplete += frmMainForm_FrameEvent2;
                captureDevice.CaptureFrame();
            }
        }
        private Bitmap CopyImage(Image value)
        {
            Bitmap bm = new Bitmap(value.Width, value.Height, PixelFormat.Format32bppRgb);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(value, 0, 0, value.Size.Width, value.Size.Height);
            g.Dispose();
            return bm;
        }

        private Bitmap CropImage(Image src, Rectangle cropRegion)
        {
            Bitmap bm = new Bitmap(cropRegion.Width, cropRegion.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bm);
            g.DrawImage(src, new Rectangle(0, 0, cropRegion.Width, cropRegion.Height), 
                        new Rectangle(cropRegion.X, cropRegion.Y, cropRegion.Width, cropRegion.Height), GraphicsUnit.Point);
            //g.DrawImage(
            g.Dispose();
            return bm;
        }
        private void picCapturedImage_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawingRectangle = true;
            x = e.X;
            y = e.Y;
            picCapturedImage.Image = capturedImage;
            picCapturedImage.Invalidate();            
            HiddenMeterReading();
        }

        private void picCapturedImage_MouseMove(object sender, MouseEventArgs e)
        {
            int x1, y1, width, height;
            if (isDrawingRectangle)
            {
                if (e.X<x) {
                    x1 = e.X;
                    width = x-x1;
                }else {
                    x1 = x;
                    width = e.X - x;
                }
                if (e.Y < y) {
                    y1 = e.Y;
                    height = y - y1;
                }else {
                    y1 = y;
                    height = e.Y-y;
                }                
                selection = new Rectangle(x1, y1, width, height);
                picCapturedImage.Invalidate();                
            }
        }

        private void picCapturedImage_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawingRectangle = false;
            picCapturedImage.Invalidate();
            picSelection.SizeMode = PictureBoxSizeMode.CenterImage;
            picSelection.Width = selection.Width;
            picSelection.Height = selection.Height;

            Bitmap image = GetWindowCaptureAsBitmap((int)picCapturedImage.Handle, selection);
            picSelection.Image = image;
            RecognizeSet result = null;
            if (image != null)
            {
                result = recognizer.Recognize(image);
                DisplayMeterReading(result);
            }
        }

        private void picCapturedImage_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;            
            if (capturedImage != null)
            {                
                if (isDrawingRectangle)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Red, 1), selection);
                }
            }
        }

        private void cboSelectVideoSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelectVideoSource.SelectedIndex != -1)
            {
                AppSettingManager.EditAppSetting(LastCameraNameKey, cboSelectVideoSource.Text);
            }
            else
            {
                AppSettingManager.EditAppSetting(LastCameraNameKey, "");
            }  
        }
        

        public static Bitmap GetWindowCaptureAsBitmap(int handle, Rectangle selection) 
        {
            if (selection.Width < 50 || selection.Height < 10) return null;

            IntPtr hWnd = new IntPtr(handle);
           
            // create a bitmap from the visible clipping bounds of 
            //the graphics object from the window
            Bitmap bitmap = new Bitmap(selection.Width-1, selection.Height-1);

            // create a graphics object from the bitmap
            Graphics gfxBitmap = Graphics.FromImage(bitmap);

            // get a device context for the bitmap
            IntPtr hdcBitmap = gfxBitmap.GetHdc();

            // get a device context for the window
            IntPtr hdcWindow = Win32.GetWindowDC(hWnd);

            // bitblt the window to the bitmap
            Win32.BitBlt(hdcBitmap, 0, 0, bitmap.Width, bitmap.Height,
               hdcWindow, selection.X+1, selection.Y+1, (int)Win32.TernaryRasterOperations.SRCCOPY);

            // release the bitmap's device context
            gfxBitmap.ReleaseHdc(hdcBitmap);


            Win32.ReleaseDC(hWnd, hdcWindow);

            // dispose of the bitmap's graphics object
            gfxBitmap.Dispose();

            // return the bitmap of the window
            return bitmap;
        }

        private void btnShowConfig_Click(object sender, EventArgs e)
        {
            frmAppSetting frmSetting = new frmAppSetting();
            frmSetting.ShowInTaskbar = false;
            frmSetting.ShowDialog(this);
        }
        private void DisplayMeterReading(RecognizeSet rs)
        {
            ShowRecognizeControl(true);
            lblResultHight.Text = rs.MatchedHight;            
            tsRecognizeResult.Text = "Chỉ số 1: " + rs.MatchedHight + " : " + rs.HightRate + "%" + "/ Chỉ số 2: " + rs.MatchedLow + " : " + rs.LowRate + "%";
        }
        private void ShowRecognizeControl(Boolean visible)
        {
            picSelection.Visible = visible;
        }
        private void HiddenMeterReading()
        {
            ShowRecognizeControl(false);            
        }
       
        private void ShowHideNumberKeyboard(Boolean isShown)
        {
            numberClose.Visible = numberKey0.Visible = numberKey1.Visible = numberKey2.Visible = numberKey3.Visible = numberKey4.Visible = numberKey5.Visible = numberKey6.Visible = numberKey7.Visible = numberKey8.Visible = numberKey9.Visible = numberKeyBackspace.Visible = isShown;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowHideNumberKeyboard(true);
            btnShowKeyboard.Visible = false;
        }

        private void numberKey1_Click(object sender, EventArgs e)
        {
            appendNumber("1");
        }

        private void numberKey2_Click(object sender, EventArgs e)
        {
            appendNumber("2");
        }

        private void numberKey3_Click(object sender, EventArgs e)
        {
            appendNumber("3");
        }

        private void numberKey4_Click(object sender, EventArgs e)
        {
            appendNumber("4");
        }

        private void numberKey5_Click(object sender, EventArgs e)
        {
            appendNumber("5");
        }

        private void numberKey6_Click(object sender, EventArgs e)
        {
            appendNumber("6");
        }

        private void numberKey7_Click(object sender, EventArgs e)
        {
            appendNumber("7");
        }

        private void numberKey8_Click(object sender, EventArgs e)
        {
            appendNumber("8");
        }

        private void numberKey9_Click(object sender, EventArgs e)
        {
            appendNumber("9");
        }

        private void numberKey0_Click(object sender, EventArgs e)
        {
            appendNumber("0");
        }

        private void numberKeyBackspace_Click(object sender, EventArgs e)
        {

            if (lblResultHight.Text.Length > 1)
            {
                lblResultHight.Text = lblResultHight.Text.Substring(0, lblResultHight.Text.Length - 1);
            }
            else
            {
                lblResultHight.Text = "0";
            }
        }
        private void appendNumber(String number)
        {
            if (lblResultHight.Text.Equals("0")) {
                lblResultHight.Text="";
            }
            if (lblResultHight.Text.Length < MAX_AVAILABLE_NUMBER_LEN)
            {
                lblResultHight.Text = lblResultHight.Text + number;
            }
        }
        private void numberClose_Click(object sender, EventArgs e)
        {
            ShowHideNumberKeyboard(false);
            btnShowKeyboard.Visible = true;
        }
    }
}
