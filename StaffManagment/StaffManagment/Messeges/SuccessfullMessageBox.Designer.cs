namespace StaffManagment.Messeges
{
    partial class SuccessfullMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccessfullMessageBox));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.SuccessMsg = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.projectTopPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SuccessMsgClose = new System.Windows.Forms.PictureBox();
            this.TitleSuccessMsg = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnSuccessMsg = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.projectTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessMsgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SuccessMsg
            // 
            this.SuccessMsg.AutoEllipsis = false;
            this.SuccessMsg.AutoSize = false;
            this.SuccessMsg.CursorType = null;
            this.SuccessMsg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SuccessMsg.Location = new System.Drawing.Point(0, 61);
            this.SuccessMsg.Name = "SuccessMsg";
            this.SuccessMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SuccessMsg.Size = new System.Drawing.Size(429, 58);
            this.SuccessMsg.TabIndex = 35;
            this.SuccessMsg.Text = "Message";
            this.SuccessMsg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // projectTopPanel
            // 
            this.projectTopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("projectTopPanel.BackgroundImage")));
            this.projectTopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.projectTopPanel.Controls.Add(this.SuccessMsgClose);
            this.projectTopPanel.Controls.Add(this.TitleSuccessMsg);
            this.projectTopPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.projectTopPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.projectTopPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.projectTopPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.projectTopPanel.Location = new System.Drawing.Point(-1, -1);
            this.projectTopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.projectTopPanel.Name = "projectTopPanel";
            this.projectTopPanel.Quality = 10;
            this.projectTopPanel.Size = new System.Drawing.Size(429, 39);
            this.projectTopPanel.TabIndex = 33;
            // 
            // SuccessMsgClose
            // 
            this.SuccessMsgClose.BackColor = System.Drawing.Color.Transparent;
            this.SuccessMsgClose.Image = ((System.Drawing.Image)(resources.GetObject("SuccessMsgClose.Image")));
            this.SuccessMsgClose.Location = new System.Drawing.Point(390, -2);
            this.SuccessMsgClose.Margin = new System.Windows.Forms.Padding(2);
            this.SuccessMsgClose.Name = "SuccessMsgClose";
            this.SuccessMsgClose.Size = new System.Drawing.Size(38, 35);
            this.SuccessMsgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SuccessMsgClose.TabIndex = 33;
            this.SuccessMsgClose.TabStop = false;
            this.SuccessMsgClose.Click += new System.EventHandler(this.SuccessMsgClose_Click);
            // 
            // TitleSuccessMsg
            // 
            this.TitleSuccessMsg.AutoEllipsis = false;
            this.TitleSuccessMsg.CursorType = null;
            this.TitleSuccessMsg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSuccessMsg.ForeColor = System.Drawing.Color.White;
            this.TitleSuccessMsg.Location = new System.Drawing.Point(9, 6);
            this.TitleSuccessMsg.Name = "TitleSuccessMsg";
            this.TitleSuccessMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleSuccessMsg.Size = new System.Drawing.Size(47, 24);
            this.TitleSuccessMsg.TabIndex = 23;
            this.TitleSuccessMsg.Text = "Type";
            this.TitleSuccessMsg.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnSuccessMsg
            // 
            this.btnSuccessMsg.BackColor = System.Drawing.Color.Transparent;
            this.btnSuccessMsg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuccessMsg.BackgroundImage")));
            this.btnSuccessMsg.ButtonText = "OK";
            this.btnSuccessMsg.ButtonTextMarginLeft = 0;
            this.btnSuccessMsg.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSuccessMsg.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSuccessMsg.DisabledForecolor = System.Drawing.Color.White;
            this.btnSuccessMsg.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuccessMsg.ForeColor = System.Drawing.Color.White;
            this.btnSuccessMsg.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSuccessMsg.IconPadding = 10;
            this.btnSuccessMsg.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSuccessMsg.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnSuccessMsg.IdleBorderRadius = 1;
            this.btnSuccessMsg.IdleBorderThickness = 0;
            this.btnSuccessMsg.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnSuccessMsg.IdleIconLeftImage = null;
            this.btnSuccessMsg.IdleIconRightImage = null;
            this.btnSuccessMsg.Location = new System.Drawing.Point(175, 198);
            this.btnSuccessMsg.Name = "btnSuccessMsg";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnSuccessMsg.onHoverState = stateProperties1;
            this.btnSuccessMsg.Size = new System.Drawing.Size(79, 32);
            this.btnSuccessMsg.TabIndex = 36;
            this.btnSuccessMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuccessMsg.Click += new System.EventHandler(this.btnSuccessMsg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // SuccessfullMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 244);
            this.Controls.Add(this.projectTopPanel);
            this.Controls.Add(this.btnSuccessMsg);
            this.Controls.Add(this.SuccessMsg);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuccessfullMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuccessfullMessageBox";
            this.projectTopPanel.ResumeLayout(false);
            this.projectTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessMsgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel TitleSuccessMsg;
        private Bunifu.Framework.UI.BunifuGradientPanel projectTopPanel;
        private System.Windows.Forms.PictureBox SuccessMsgClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSuccessMsg;
        private Bunifu.UI.WinForms.BunifuLabel SuccessMsg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}