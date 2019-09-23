namespace StaffManagment
{
    partial class ErrorDialogBox
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorDialogBox));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.projectTopPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ErrorMsgClose = new System.Windows.Forms.PictureBox();
            this.TitleErrorMsg = new Bunifu.UI.WinForms.BunifuLabel();
            this.ErrorMsg = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnErrorMsg = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.projectTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMsgClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 131);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // projectTopPanel
            // 
            this.projectTopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("projectTopPanel.BackgroundImage")));
            this.projectTopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.projectTopPanel.Controls.Add(this.ErrorMsgClose);
            this.projectTopPanel.Controls.Add(this.TitleErrorMsg);
            this.bunifuTransition1.SetDecoration(this.projectTopPanel, BunifuAnimatorNS.DecorationType.None);
            this.projectTopPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.projectTopPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.projectTopPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.projectTopPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.projectTopPanel.Location = new System.Drawing.Point(-1, -1);
            this.projectTopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.projectTopPanel.Name = "projectTopPanel";
            this.projectTopPanel.Quality = 10;
            this.projectTopPanel.Size = new System.Drawing.Size(429, 39);
            this.projectTopPanel.TabIndex = 7;
            // 
            // ErrorMsgClose
            // 
            this.ErrorMsgClose.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.ErrorMsgClose, BunifuAnimatorNS.DecorationType.None);
            this.ErrorMsgClose.Image = ((System.Drawing.Image)(resources.GetObject("ErrorMsgClose.Image")));
            this.ErrorMsgClose.Location = new System.Drawing.Point(390, 2);
            this.ErrorMsgClose.Margin = new System.Windows.Forms.Padding(2);
            this.ErrorMsgClose.Name = "ErrorMsgClose";
            this.ErrorMsgClose.Size = new System.Drawing.Size(38, 35);
            this.ErrorMsgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ErrorMsgClose.TabIndex = 30;
            this.ErrorMsgClose.TabStop = false;
            this.ErrorMsgClose.Click += new System.EventHandler(this.ErrorMsgClose_Click);
            // 
            // TitleErrorMsg
            // 
            this.TitleErrorMsg.AutoEllipsis = false;
            this.TitleErrorMsg.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.TitleErrorMsg, BunifuAnimatorNS.DecorationType.None);
            this.TitleErrorMsg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleErrorMsg.ForeColor = System.Drawing.Color.White;
            this.TitleErrorMsg.Location = new System.Drawing.Point(9, 7);
            this.TitleErrorMsg.Name = "TitleErrorMsg";
            this.TitleErrorMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleErrorMsg.Size = new System.Drawing.Size(47, 24);
            this.TitleErrorMsg.TabIndex = 23;
            this.TitleErrorMsg.Text = "Type";
            this.TitleErrorMsg.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // ErrorMsg
            // 
            this.ErrorMsg.AutoEllipsis = false;
            this.ErrorMsg.AutoSize = false;
            this.ErrorMsg.CursorType = null;
            this.bunifuTransition1.SetDecoration(this.ErrorMsg, BunifuAnimatorNS.DecorationType.None);
            this.ErrorMsg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ErrorMsg.Location = new System.Drawing.Point(0, 59);
            this.ErrorMsg.Name = "ErrorMsg";
            this.ErrorMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ErrorMsg.Size = new System.Drawing.Size(429, 62);
            this.ErrorMsg.TabIndex = 24;
            this.ErrorMsg.TabStop = false;
            this.ErrorMsg.Text = "Message";
            this.ErrorMsg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnErrorMsg
            // 
            this.btnErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.btnErrorMsg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnErrorMsg.BackgroundImage")));
            this.btnErrorMsg.ButtonText = "OK";
            this.btnErrorMsg.ButtonTextMarginLeft = 0;
            this.bunifuTransition1.SetDecoration(this.btnErrorMsg, BunifuAnimatorNS.DecorationType.None);
            this.btnErrorMsg.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnErrorMsg.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnErrorMsg.DisabledForecolor = System.Drawing.Color.White;
            this.btnErrorMsg.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErrorMsg.ForeColor = System.Drawing.Color.White;
            this.btnErrorMsg.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnErrorMsg.IconPadding = 10;
            this.btnErrorMsg.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnErrorMsg.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnErrorMsg.IdleBorderRadius = 1;
            this.btnErrorMsg.IdleBorderThickness = 0;
            this.btnErrorMsg.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnErrorMsg.IdleIconLeftImage = null;
            this.btnErrorMsg.IdleIconRightImage = null;
            this.btnErrorMsg.Location = new System.Drawing.Point(175, 196);
            this.btnErrorMsg.Name = "btnErrorMsg";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnErrorMsg.onHoverState = stateProperties1;
            this.btnErrorMsg.Size = new System.Drawing.Size(79, 32);
            this.btnErrorMsg.TabIndex = 29;
            this.btnErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnErrorMsg.Click += new System.EventHandler(this.btnErrorMsg_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ErrorDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 244);
            this.Controls.Add(this.btnErrorMsg);
            this.Controls.Add(this.ErrorMsg);
            this.Controls.Add(this.projectTopPanel);
            this.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ErrorDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorDialogBox";
            this.Load += new System.EventHandler(this.ErrorDialogBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.projectTopPanel.ResumeLayout(false);
            this.projectTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMsgClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel projectTopPanel;
        private Bunifu.UI.WinForms.BunifuLabel TitleErrorMsg;
        private Bunifu.UI.WinForms.BunifuLabel ErrorMsg;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnErrorMsg;
        private System.Windows.Forms.PictureBox ErrorMsgClose;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}