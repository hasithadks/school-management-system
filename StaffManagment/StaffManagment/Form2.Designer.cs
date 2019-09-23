namespace StaffManagment
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nameLable = new Bunifu.UI.WinForms.BunifuLabel();
            this.nicLable = new Bunifu.UI.WinForms.BunifuLabel();
            this.dateLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.barcodeImg = new System.Windows.Forms.PictureBox();
            this.photoTxt = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_button = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(36, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // nameLable
            // 
            this.nameLable.AutoEllipsis = false;
            this.nameLable.CursorType = null;
            this.nameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLable.Location = new System.Drawing.Point(237, 255);
            this.nameLable.Name = "nameLable";
            this.nameLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameLable.Size = new System.Drawing.Size(40, 21);
            this.nameLable.TabIndex = 3;
            this.nameLable.Text = "name";
            this.nameLable.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameLable.Click += new System.EventHandler(this.nameLable_Click);
            // 
            // nicLable
            // 
            this.nicLable.AutoEllipsis = false;
            this.nicLable.CursorType = null;
            this.nicLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicLable.Location = new System.Drawing.Point(237, 290);
            this.nicLable.Name = "nicLable";
            this.nicLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nicLable.Size = new System.Drawing.Size(28, 21);
            this.nicLable.TabIndex = 4;
            this.nicLable.Text = "NIC";
            this.nicLable.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoEllipsis = false;
            this.dateLabel.CursorType = null;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(237, 325);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateLabel.Size = new System.Drawing.Size(34, 21);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(180, 255);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(51, 21);
            this.bunifuLabel1.TabIndex = 10;
            this.bunifuLabel1.Text = "Name :";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click_1);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(195, 290);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(36, 21);
            this.bunifuLabel2.TabIndex = 11;
            this.bunifuLabel2.Text = "NIC :";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(150, 325);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(81, 21);
            this.bunifuLabel3.TabIndex = 12;
            this.bunifuLabel3.Text = "Issue Date :";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel3.Click += new System.EventHandler(this.bunifuLabel3_Click);
            // 
            // barcodeImg
            // 
            this.barcodeImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeImg.Location = new System.Drawing.Point(180, 418);
            this.barcodeImg.Name = "barcodeImg";
            this.barcodeImg.Size = new System.Drawing.Size(189, 64);
            this.barcodeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barcodeImg.TabIndex = 13;
            this.barcodeImg.TabStop = false;
            this.barcodeImg.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // photoTxt
            // 
            this.photoTxt.Location = new System.Drawing.Point(212, 123);
            this.photoTxt.Name = "photoTxt";
            this.photoTxt.Size = new System.Drawing.Size(101, 110);
            this.photoTxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoTxt.TabIndex = 8;
            this.photoTxt.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(90, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 482);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // close_button
            // 
            this.close_button.ActiveImage = null;
            this.close_button.AllowAnimations = true;
            this.close_button.AllowZooming = true;
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.ErrorImage = ((System.Drawing.Image)(resources.GetObject("close_button.ErrorImage")));
            this.close_button.FadeWhenInactive = false;
            this.close_button.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.close_button.Image = global::StaffManagment.Properties.Resources.closebtn;
            this.close_button.ImageActive = null;
            this.close_button.ImageLocation = null;
            this.close_button.ImageMargin = 10;
            this.close_button.ImageSize = new System.Drawing.Size(30, 30);
            this.close_button.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.close_button.InitialImage = ((System.Drawing.Image)(resources.GetObject("close_button.InitialImage")));
            this.close_button.Location = new System.Drawing.Point(559, 0);
            this.close_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close_button.Name = "close_button";
            this.close_button.Rotation = 0;
            this.close_button.ShowActiveImage = true;
            this.close_button.ShowCursorChanges = true;
            this.close_button.ShowImageBorders = true;
            this.close_button.ShowSizeMarkers = true;
            this.close_button.Size = new System.Drawing.Size(40, 40);
            this.close_button.TabIndex = 1;
            this.close_button.ToolTipText = "";
            this.close_button.WaitOnLoad = false;
            this.close_button.Zoom = 10;
            this.close_button.ZoomSpeed = 10;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.barcodeImg);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.photoTxt);
            this.Controls.Add(this.nicLable);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barcodeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton close_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Bunifu.UI.WinForms.BunifuLabel nameLable;
        private Bunifu.UI.WinForms.BunifuLabel nicLable;
        private System.Windows.Forms.PictureBox photoTxt;
        private Bunifu.UI.WinForms.BunifuLabel dateLabel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private System.Windows.Forms.PictureBox barcodeImg;
    }
}