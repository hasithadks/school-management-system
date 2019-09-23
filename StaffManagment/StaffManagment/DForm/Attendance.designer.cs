namespace SchoolManagementSystem
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.txtUserId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LableUserId = new Bunifu.UI.WinForms.BunifuLabel();
            this.AttendanceTimer = new System.Windows.Forms.Timer(this.components);
            this.LabelTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.LabelSecond = new Bunifu.UI.WinForms.BunifuLabel();
            this.LabelDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.LabelDay = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnEnd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnStart = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnMinimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnNormalize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SuspendLayout();
            // 
            // txtUserId
            // 
            this.txtUserId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUserId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUserId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUserId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserId.HintForeColor = System.Drawing.Color.Empty;
            this.txtUserId.HintText = "";
            this.txtUserId.isPassword = false;
            this.txtUserId.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.txtUserId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUserId.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.txtUserId.LineThickness = 3;
            this.txtUserId.Location = new System.Drawing.Point(509, 364);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUserId.MaxLength = 32767;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(322, 40);
            this.txtUserId.TabIndex = 32;
            this.txtUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LableUserId
            // 
            this.LableUserId.AutoEllipsis = false;
            this.LableUserId.CursorType = null;
            this.LableUserId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LableUserId.Location = new System.Drawing.Point(277, 380);
            this.LableUserId.Name = "LableUserId";
            this.LableUserId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LableUserId.Size = new System.Drawing.Size(198, 24);
            this.LableUserId.TabIndex = 33;
            this.LableUserId.Text = "Enter Your Id Number";
            this.LableUserId.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // AttendanceTimer
            // 
            this.AttendanceTimer.Tick += new System.EventHandler(this.AttendanceTimer_Tick);
            // 
            // LabelTime
            // 
            this.LabelTime.AutoEllipsis = false;
            this.LabelTime.CursorType = null;
            this.LabelTime.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelTime.Location = new System.Drawing.Point(426, 267);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelTime.Size = new System.Drawing.Size(75, 38);
            this.LabelTime.TabIndex = 36;
            this.LabelTime.Text = "22:22";
            this.LabelTime.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // LabelSecond
            // 
            this.LabelSecond.AutoEllipsis = false;
            this.LabelSecond.CursorType = null;
            this.LabelSecond.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelSecond.Location = new System.Drawing.Point(504, 281);
            this.LabelSecond.Name = "LabelSecond";
            this.LabelSecond.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelSecond.Size = new System.Drawing.Size(21, 21);
            this.LabelSecond.TabIndex = 36;
            this.LabelSecond.Text = "22";
            this.LabelSecond.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoEllipsis = false;
            this.LabelDate.CursorType = null;
            this.LabelDate.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelDate.Location = new System.Drawing.Point(570, 267);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelDate.Size = new System.Drawing.Size(184, 38);
            this.LabelDate.TabIndex = 37;
            this.LabelDate.Text = "JUNE 25 2018";
            this.LabelDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // LabelDay
            // 
            this.LabelDay.AutoEllipsis = false;
            this.LabelDay.CursorType = null;
            this.LabelDay.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelDay.Location = new System.Drawing.Point(779, 267);
            this.LabelDay.Name = "LabelDay";
            this.LabelDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelDay.Size = new System.Drawing.Size(101, 38);
            this.LabelDay.TabIndex = 37;
            this.LabelDay.Text = "FRIDAY";
            this.LabelDay.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Transparent;
            this.btnEnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnd.BackgroundImage")));
            this.btnEnd.ButtonText = "END";
            this.btnEnd.ButtonTextMarginLeft = 0;
            this.btnEnd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnEnd.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnEnd.DisabledForecolor = System.Drawing.Color.White;
            this.btnEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.btnEnd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEnd.IconPadding = 5;
            this.btnEnd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEnd.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnEnd.IdleBorderRadius = 15;
            this.btnEnd.IdleBorderThickness = 1;
            this.btnEnd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnEnd.IdleIconLeftImage = global::StaffManagment.Properties.Resources.expenses;
            this.btnEnd.IdleIconRightImage = null;
            this.btnEnd.Location = new System.Drawing.Point(983, 372);
            this.btnEnd.Name = "btnEnd";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.BorderRadius = 15;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.IconLeftImage = global::StaffManagment.Properties.Resources.expenses;
            stateProperties1.IconRightImage = null;
            this.btnEnd.onHoverState = stateProperties1;
            this.btnEnd.Size = new System.Drawing.Size(101, 32);
            this.btnEnd.TabIndex = 35;
            this.btnEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.ButtonText = "START";
            this.btnStart.ButtonTextMarginLeft = 0;
            this.btnStart.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnStart.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnStart.DisabledForecolor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.btnStart.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnStart.IconPadding = 5;
            this.btnStart.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnStart.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnStart.IdleBorderRadius = 15;
            this.btnStart.IdleBorderThickness = 1;
            this.btnStart.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnStart.IdleIconLeftImage = global::StaffManagment.Properties.Resources.income;
            this.btnStart.IdleIconRightImage = null;
            this.btnStart.Location = new System.Drawing.Point(868, 372);
            this.btnStart.Name = "btnStart";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties2.BorderRadius = 15;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties2.IconLeftImage = global::StaffManagment.Properties.Resources.income;
            stateProperties2.IconRightImage = null;
            this.btnStart.onHoverState = stateProperties2;
            this.btnStart.Size = new System.Drawing.Size(101, 32);
            this.btnStart.TabIndex = 34;
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowZooming = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 10;
            this.btnClose.ImageSize = new System.Drawing.Size(28, 25);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(38, 35);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(1322, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = true;
            this.btnClose.Size = new System.Drawing.Size(38, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 10;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.ActiveImage = null;
            this.btnMinimize.AllowAnimations = true;
            this.btnMinimize.AllowZooming = true;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.ErrorImage")));
            this.btnMinimize.FadeWhenInactive = false;
            this.btnMinimize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMinimize.Image = global::StaffManagment.Properties.Resources.minibtn;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.ImageLocation = null;
            this.btnMinimize.ImageMargin = 10;
            this.btnMinimize.ImageSize = new System.Drawing.Size(28, 25);
            this.btnMinimize.ImageZoomSize = new System.Drawing.Size(38, 35);
            this.btnMinimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.InitialImage")));
            this.btnMinimize.Location = new System.Drawing.Point(1249, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0;
            this.btnMinimize.ShowActiveImage = true;
            this.btnMinimize.ShowCursorChanges = true;
            this.btnMinimize.ShowImageBorders = true;
            this.btnMinimize.ShowSizeMarkers = true;
            this.btnMinimize.Size = new System.Drawing.Size(38, 35);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.ToolTipText = "";
            this.btnMinimize.WaitOnLoad = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.ZoomSpeed = 10;
            // 
            // btnNormalize
            // 
            this.btnNormalize.ActiveImage = null;
            this.btnNormalize.AllowAnimations = true;
            this.btnNormalize.AllowZooming = true;
            this.btnNormalize.BackColor = System.Drawing.Color.Transparent;
            this.btnNormalize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnNormalize.ErrorImage")));
            this.btnNormalize.FadeWhenInactive = false;
            this.btnNormalize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnNormalize.Image = global::StaffManagment.Properties.Resources.Maxibtn;
            this.btnNormalize.ImageActive = null;
            this.btnNormalize.ImageLocation = null;
            this.btnNormalize.ImageMargin = 10;
            this.btnNormalize.ImageSize = new System.Drawing.Size(28, 25);
            this.btnNormalize.ImageZoomSize = new System.Drawing.Size(38, 35);
            this.btnNormalize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnNormalize.InitialImage")));
            this.btnNormalize.Location = new System.Drawing.Point(1285, 0);
            this.btnNormalize.Margin = new System.Windows.Forms.Padding(4);
            this.btnNormalize.Name = "btnNormalize";
            this.btnNormalize.Rotation = 0;
            this.btnNormalize.ShowActiveImage = true;
            this.btnNormalize.ShowCursorChanges = true;
            this.btnNormalize.ShowImageBorders = true;
            this.btnNormalize.ShowSizeMarkers = true;
            this.btnNormalize.Size = new System.Drawing.Size(38, 35);
            this.btnNormalize.TabIndex = 5;
            this.btnNormalize.ToolTipText = "";
            this.btnNormalize.WaitOnLoad = false;
            this.btnNormalize.Zoom = 10;
            this.btnNormalize.ZoomSpeed = 10;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.LabelDay);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelSecond);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.LableUserId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnNormalize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuImageButton btnMinimize;
        private Bunifu.UI.WinForms.BunifuImageButton btnNormalize;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserId;
        private Bunifu.UI.WinForms.BunifuLabel LableUserId;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnStart;
        private System.Windows.Forms.Timer AttendanceTimer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEnd;
        private Bunifu.UI.WinForms.BunifuLabel LabelTime;
        private Bunifu.UI.WinForms.BunifuLabel LabelSecond;
        private Bunifu.UI.WinForms.BunifuLabel LabelDate;
        private Bunifu.UI.WinForms.BunifuLabel LabelDay;
    }
}