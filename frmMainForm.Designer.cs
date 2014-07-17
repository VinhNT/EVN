namespace EVN
{
    partial class frmMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.cboSelectVideoSource = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnShowConfig = new System.Windows.Forms.Button();
            this.lblResultHight = new System.Windows.Forms.Label();
            this.lblResultHighCaption = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsRecognizeResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.numberClose = new System.Windows.Forms.PictureBox();
            this.numberKeyBackspace = new System.Windows.Forms.PictureBox();
            this.numberKey8 = new System.Windows.Forms.PictureBox();
            this.numberKey9 = new System.Windows.Forms.PictureBox();
            this.numberKey0 = new System.Windows.Forms.PictureBox();
            this.numberKey2 = new System.Windows.Forms.PictureBox();
            this.numberKey3 = new System.Windows.Forms.PictureBox();
            this.numberKey4 = new System.Windows.Forms.PictureBox();
            this.numberKey5 = new System.Windows.Forms.PictureBox();
            this.numberKey6 = new System.Windows.Forms.PictureBox();
            this.numberKey7 = new System.Windows.Forms.PictureBox();
            this.numberKey1 = new System.Windows.Forms.PictureBox();
            this.picSelection = new System.Windows.Forms.PictureBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.picCapturedImage = new System.Windows.Forms.PictureBox();
            this.btnShowKeyboard = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKeyBackspace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapturedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowKeyboard)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSelectVideoSource
            // 
            this.cboSelectVideoSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelectVideoSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectVideoSource.FormattingEnabled = true;
            this.cboSelectVideoSource.Location = new System.Drawing.Point(588, 12);
            this.cboSelectVideoSource.Name = "cboSelectVideoSource";
            this.cboSelectVideoSource.Size = new System.Drawing.Size(282, 37);
            this.cboSelectVideoSource.TabIndex = 0;
            this.cboSelectVideoSource.SelectedIndexChanged += new System.EventHandler(this.cboSelectVideoSource_SelectedIndexChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Location = new System.Drawing.Point(810, 258);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(60, 60);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.cmdPreview_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapture.Location = new System.Drawing.Point(795, 324);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 59);
            this.btnCapture.TabIndex = 2;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnShowConfig
            // 
            this.btnShowConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowConfig.Location = new System.Drawing.Point(724, 324);
            this.btnShowConfig.Name = "btnShowConfig";
            this.btnShowConfig.Size = new System.Drawing.Size(65, 59);
            this.btnShowConfig.TabIndex = 8;
            this.btnShowConfig.Text = "Tùy chọn";
            this.btnShowConfig.UseVisualStyleBackColor = true;
            this.btnShowConfig.Visible = false;
            this.btnShowConfig.Click += new System.EventHandler(this.btnShowConfig_Click);
            // 
            // lblResultHight
            // 
            this.lblResultHight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultHight.AutoSize = true;
            this.lblResultHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultHight.Location = new System.Drawing.Point(125, 363);
            this.lblResultHight.Name = "lblResultHight";
            this.lblResultHight.Size = new System.Drawing.Size(0, 20);
            this.lblResultHight.TabIndex = 9;
            // 
            // lblResultHighCaption
            // 
            this.lblResultHighCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultHighCaption.AutoSize = true;
            this.lblResultHighCaption.Location = new System.Drawing.Point(63, 368);
            this.lblResultHighCaption.Name = "lblResultHighCaption";
            this.lblResultHighCaption.Size = new System.Drawing.Size(47, 13);
            this.lblResultHighCaption.TabIndex = 10;
            this.lblResultHighCaption.Text = "Số điện:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRecognizeResult});
            this.statusStrip1.Location = new System.Drawing.Point(0, 386);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(882, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsRecognizeResult
            // 
            this.tsRecognizeResult.Name = "tsRecognizeResult";
            this.tsRecognizeResult.Size = new System.Drawing.Size(0, 17);
            // 
            // numberClose
            // 
            this.numberClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("numberClose.BackgroundImage")));
            this.numberClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numberClose.Location = new System.Drawing.Point(181, 212);
            this.numberClose.Name = "numberClose";
            this.numberClose.Size = new System.Drawing.Size(51, 39);
            this.numberClose.TabIndex = 25;
            this.numberClose.TabStop = false;
            this.numberClose.Click += new System.EventHandler(this.numberClose_Click);
            // 
            // numberKeyBackspace
            // 
            this.numberKeyBackspace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberKeyBackspace.BackgroundImage = global::EVN.Properties.Resources.button_backspace;
            this.numberKeyBackspace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numberKeyBackspace.Location = new System.Drawing.Point(181, 257);
            this.numberKeyBackspace.Name = "numberKeyBackspace";
            this.numberKeyBackspace.Size = new System.Drawing.Size(51, 39);
            this.numberKeyBackspace.TabIndex = 24;
            this.numberKeyBackspace.TabStop = false;
            this.numberKeyBackspace.Click += new System.EventHandler(this.numberKeyBackspace_Click);
            // 
            // numberKey8
            // 
            this.numberKey8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberKey8.BackgroundImage = global::EVN.Properties.Resources.button8;
            this.numberKey8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numberKey8.Location = new System.Drawing.Point(67, 302);
            this.numberKey8.Name = "numberKey8";
            this.numberKey8.Size = new System.Drawing.Size(51, 39);
            this.numberKey8.TabIndex = 23;
            this.numberKey8.TabStop = false;
            this.numberKey8.Click += new System.EventHandler(this.numberKey8_Click);
            // 
            // numberKey9
            // 
            this.numberKey9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberKey9.BackgroundImage = global::EVN.Properties.Resources.button9;
            this.numberKey9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numberKey9.Location = new System.Drawing.Point(124, 302);
            this.numberKey9.Name = "numberKey9";
            this.numberKey9.Size = new System.Drawing.Size(51, 39);
            this.numberKey9.TabIndex = 22;
            this.numberKey9.TabStop = false;
            this.numberKey9.Click += new System.EventHandler(this.numberKey9_Click);
            // 
            // numberKey0
            // 
            this.numberKey0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberKey0.BackgroundImage = global::EVN.Properties.Resources.button0;
            this.numberKey0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numberKey0.Location = new System.Drawing.Point(181, 302);
            this.numberKey0.Name = "numberKey0";
            this.numberKey0.Size = new System.Drawing.Size(51, 39);
            this.numberKey0.TabIndex = 21;
            this.numberKey0.TabStop = false;
            this.numberKey0.Click += new System.EventHandler(this.numberKey0_Click);
            // 
            // numberKey2
            // 
            this.numberKey2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberKey2.BackgroundImage = global::EVN.Properties.Resources.button2;
            this.numberKey2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numberKey2.Location = new System.Drawing.Point(67, 212);
            this.numberKey2.Name = "numberKey2";
            this.numberKey2.Size = new System.Drawing.Size(51, 39);
            this.numberKey2.TabIndex = 20;
            this.numberKey2.TabStop = false;
            this.numberKey2.Click += new System.EventHandler(this.numberKey2_Click);
            // 
            // numberKey3
            // 
            this.numberKey3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberKey3.BackgroundImage = global::EVN.Properties.Resources.button3;
            this.numberKey3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numberKey3.Location = new System.Drawing.Point(124, 212);
            this.numberKey3.Name = "numberKey3";
            this.numberKey3.Size = new System.Drawing.Size(51, 39);
            this.numberKey3.TabIndex = 19;
            this.numberKey3.TabStop = false;
            this.numberKey3.Click += new System.EventHandler(this.numberKey3_Click);
            // 
            // numberKey4
            // 
            this.numberKey4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberKey4.BackgroundImage = global::EVN.Properties.Resources.button4;
            this.numberKey4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numberKey4.Location = new System.Drawing.Point(10, 257);
            this.numberKey4.Name = "numberKey4";
            this.numberKey4.Size = new System.Drawing.Size(51, 39);
            this.numberKey4.TabIndex = 18;
            this.numberKey4.TabStop = false;
            this.numberKey4.Click += new System.EventHandler(this.numberKey4_Click);
            // 
            // numberKey5
            // 
            this.numberKey5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberKey5.BackgroundImage = global::EVN.Properties.Resources.button5;
            this.numberKey5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numberKey5.Location = new System.Drawing.Point(67, 257);
            this.numberKey5.Name = "numberKey5";
            this.numberKey5.Size = new System.Drawing.Size(51, 39);
            this.numberKey5.TabIndex = 17;
            this.numberKey5.TabStop = false;
            this.numberKey5.Click += new System.EventHandler(this.numberKey5_Click);
            // 
            // numberKey6
            // 
            this.numberKey6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberKey6.BackgroundImage = global::EVN.Properties.Resources.button6;
            this.numberKey6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numberKey6.Location = new System.Drawing.Point(124, 257);
            this.numberKey6.Name = "numberKey6";
            this.numberKey6.Size = new System.Drawing.Size(51, 39);
            this.numberKey6.TabIndex = 16;
            this.numberKey6.TabStop = false;
            this.numberKey6.Click += new System.EventHandler(this.numberKey6_Click);
            // 
            // numberKey7
            // 
            this.numberKey7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberKey7.BackgroundImage = global::EVN.Properties.Resources.button7;
            this.numberKey7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numberKey7.Location = new System.Drawing.Point(10, 302);
            this.numberKey7.Name = "numberKey7";
            this.numberKey7.Size = new System.Drawing.Size(51, 39);
            this.numberKey7.TabIndex = 15;
            this.numberKey7.TabStop = false;
            this.numberKey7.Click += new System.EventHandler(this.numberKey7_Click);
            // 
            // numberKey1
            // 
            this.numberKey1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberKey1.BackgroundImage = global::EVN.Properties.Resources.button1;
            this.numberKey1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numberKey1.Location = new System.Drawing.Point(10, 212);
            this.numberKey1.Name = "numberKey1";
            this.numberKey1.Size = new System.Drawing.Size(51, 39);
            this.numberKey1.TabIndex = 14;
            this.numberKey1.TabStop = false;
            this.numberKey1.Click += new System.EventHandler(this.numberKey1_Click);
            // 
            // picSelection
            // 
            this.picSelection.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSelection.Location = new System.Drawing.Point(0, 0);
            this.picSelection.Name = "picSelection";
            this.picSelection.Size = new System.Drawing.Size(279, 68);
            this.picSelection.TabIndex = 7;
            this.picSelection.TabStop = false;
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPreview.Location = new System.Drawing.Point(0, 0);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(882, 408);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 3;
            this.picPreview.TabStop = false;
            // 
            // picCapturedImage
            // 
            this.picCapturedImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picCapturedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCapturedImage.Image = ((System.Drawing.Image)(resources.GetObject("picCapturedImage.Image")));
            this.picCapturedImage.Location = new System.Drawing.Point(0, 0);
            this.picCapturedImage.Name = "picCapturedImage";
            this.picCapturedImage.Size = new System.Drawing.Size(882, 408);
            this.picCapturedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapturedImage.TabIndex = 4;
            this.picCapturedImage.TabStop = false;
            this.picCapturedImage.Paint += new System.Windows.Forms.PaintEventHandler(this.picCapturedImage_Paint);
            this.picCapturedImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCapturedImage_MouseDown);
            this.picCapturedImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCapturedImage_MouseMove);
            this.picCapturedImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCapturedImage_MouseUp);
            // 
            // btnShowKeyboard
            // 
            this.btnShowKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowKeyboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowKeyboard.BackgroundImage")));
            this.btnShowKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShowKeyboard.Location = new System.Drawing.Point(10, 342);
            this.btnShowKeyboard.Name = "btnShowKeyboard";
            this.btnShowKeyboard.Size = new System.Drawing.Size(51, 39);
            this.btnShowKeyboard.TabIndex = 26;
            this.btnShowKeyboard.TabStop = false;
            this.btnShowKeyboard.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 408);
            this.Controls.Add(this.btnShowKeyboard);
            this.Controls.Add(this.numberClose);
            this.Controls.Add(this.numberKeyBackspace);
            this.Controls.Add(this.numberKey8);
            this.Controls.Add(this.numberKey9);
            this.Controls.Add(this.numberKey0);
            this.Controls.Add(this.numberKey2);
            this.Controls.Add(this.numberKey3);
            this.Controls.Add(this.numberKey4);
            this.Controls.Add(this.numberKey5);
            this.Controls.Add(this.numberKey6);
            this.Controls.Add(this.numberKey7);
            this.Controls.Add(this.numberKey1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblResultHighCaption);
            this.Controls.Add(this.lblResultHight);
            this.Controls.Add(this.btnShowConfig);
            this.Controls.Add(this.picSelection);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cboSelectVideoSource);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.picCapturedImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainForm";
            this.Text = "Phần mềm đọc công tơ";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKeyBackspace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKey1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapturedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowKeyboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelectVideoSource;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.PictureBox picCapturedImage;
        private System.Windows.Forms.PictureBox picSelection;
        private System.Windows.Forms.Button btnShowConfig;
        private System.Windows.Forms.Label lblResultHight;
        private System.Windows.Forms.Label lblResultHighCaption;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsRecognizeResult;
        private System.Windows.Forms.PictureBox numberKey1;
        private System.Windows.Forms.PictureBox numberKey7;
        private System.Windows.Forms.PictureBox numberKey6;
        private System.Windows.Forms.PictureBox numberKey5;
        private System.Windows.Forms.PictureBox numberKey4;
        private System.Windows.Forms.PictureBox numberKey3;
        private System.Windows.Forms.PictureBox numberKey2;
        private System.Windows.Forms.PictureBox numberKey0;
        private System.Windows.Forms.PictureBox numberKey9;
        private System.Windows.Forms.PictureBox numberKey8;
        private System.Windows.Forms.PictureBox numberKeyBackspace;
        private System.Windows.Forms.PictureBox numberClose;
        private System.Windows.Forms.PictureBox btnShowKeyboard;
    }
}

