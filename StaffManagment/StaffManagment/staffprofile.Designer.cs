namespace StaffManagment
{
    partial class staffprofile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffprofile));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.dataGridViewPendingLeaves = new System.Windows.Forms.DataGridView();
            this.chng_password = new System.Windows.Forms.GroupBox();
            this.changePassword_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.newPassword_txt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.confirmPassword_txt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.currentPassword_txt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.confirmPassword = new Bunifu.UI.WinForms.BunifuLabel();
            this.newPassword = new Bunifu.UI.WinForms.BunifuLabel();
            this.currentPassword = new Bunifu.UI.WinForms.BunifuLabel();
            this.canclebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.requestbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingLeaves)).BeginInit();
            this.chng_password.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPendingLeaves
            // 
            this.dataGridViewPendingLeaves.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPendingLeaves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPendingLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPendingLeaves.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPendingLeaves.Location = new System.Drawing.Point(49, 63);
            this.dataGridViewPendingLeaves.Name = "dataGridViewPendingLeaves";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPendingLeaves.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPendingLeaves.Size = new System.Drawing.Size(471, 345);
            this.dataGridViewPendingLeaves.TabIndex = 11;
            // 
            // chng_password
            // 
            this.chng_password.Controls.Add(this.changePassword_btn);
            this.chng_password.Controls.Add(this.newPassword_txt);
            this.chng_password.Controls.Add(this.confirmPassword_txt);
            this.chng_password.Controls.Add(this.currentPassword_txt);
            this.chng_password.Controls.Add(this.confirmPassword);
            this.chng_password.Controls.Add(this.newPassword);
            this.chng_password.Controls.Add(this.currentPassword);
            this.chng_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chng_password.Location = new System.Drawing.Point(48, 441);
            this.chng_password.Name = "chng_password";
            this.chng_password.Size = new System.Drawing.Size(573, 220);
            this.chng_password.TabIndex = 12;
            this.chng_password.TabStop = false;
            this.chng_password.Text = "Change Password";
            // 
            // changePassword_btn
            // 
            this.changePassword_btn.BackColor = System.Drawing.Color.Transparent;
            this.changePassword_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changePassword_btn.BackgroundImage")));
            this.changePassword_btn.ButtonText = "Change Password";
            this.changePassword_btn.ButtonTextMarginLeft = 0;
            this.changePassword_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.changePassword_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.changePassword_btn.DisabledFillColor = System.Drawing.Color.Gray;
            this.changePassword_btn.DisabledForecolor = System.Drawing.Color.White;
            this.changePassword_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassword_btn.ForeColor = System.Drawing.Color.White;
            this.changePassword_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.changePassword_btn.IconPadding = 6;
            this.changePassword_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.changePassword_btn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.changePassword_btn.IdleBorderRadius = 1;
            this.changePassword_btn.IdleBorderThickness = 0;
            this.changePassword_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.changePassword_btn.IdleIconLeftImage = null;
            this.changePassword_btn.IdleIconRightImage = null;
            this.changePassword_btn.Location = new System.Drawing.Point(385, 161);
            this.changePassword_btn.Margin = new System.Windows.Forms.Padding(2);
            this.changePassword_btn.Name = "changePassword_btn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.changePassword_btn.onHoverState = stateProperties1;
            this.changePassword_btn.Size = new System.Drawing.Size(172, 32);
            this.changePassword_btn.TabIndex = 19;
            this.changePassword_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changePassword_btn.Click += new System.EventHandler(this.changePassword_btn_Click);
            // 
            // newPassword_txt
            // 
            this.newPassword_txt.AcceptsReturn = false;
            this.newPassword_txt.AcceptsTab = false;
            this.newPassword_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.newPassword_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.newPassword_txt.BackColor = System.Drawing.Color.Transparent;
            this.newPassword_txt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newPassword_txt.BackgroundImage")));
            this.newPassword_txt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPassword_txt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPassword_txt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPassword_txt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPassword_txt.BorderRadius = 1;
            this.newPassword_txt.BorderThickness = 1;
            this.newPassword_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newPassword_txt.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword_txt.DefaultText = "";
            this.newPassword_txt.FillColor = System.Drawing.Color.White;
            this.newPassword_txt.HideSelection = true;
            this.newPassword_txt.IconLeft = null;
            this.newPassword_txt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.newPassword_txt.IconPadding = 10;
            this.newPassword_txt.IconRight = null;
            this.newPassword_txt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.newPassword_txt.Location = new System.Drawing.Point(187, 80);
            this.newPassword_txt.MaxLength = 32767;
            this.newPassword_txt.MinimumSize = new System.Drawing.Size(100, 35);
            this.newPassword_txt.Modified = false;
            this.newPassword_txt.Name = "newPassword_txt";
            this.newPassword_txt.PasswordChar = '\0';
            this.newPassword_txt.ReadOnly = false;
            this.newPassword_txt.SelectedText = "";
            this.newPassword_txt.SelectionLength = 0;
            this.newPassword_txt.SelectionStart = 0;
            this.newPassword_txt.ShortcutsEnabled = true;
            this.newPassword_txt.Size = new System.Drawing.Size(370, 35);
            this.newPassword_txt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.newPassword_txt.TabIndex = 17;
            this.newPassword_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.newPassword_txt.TextMarginLeft = 5;
            this.newPassword_txt.TextPlaceholder = "";
            this.newPassword_txt.UseSystemPasswordChar = false;
            // 
            // confirmPassword_txt
            // 
            this.confirmPassword_txt.AcceptsReturn = false;
            this.confirmPassword_txt.AcceptsTab = false;
            this.confirmPassword_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.confirmPassword_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.confirmPassword_txt.BackColor = System.Drawing.Color.Transparent;
            this.confirmPassword_txt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmPassword_txt.BackgroundImage")));
            this.confirmPassword_txt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmPassword_txt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmPassword_txt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmPassword_txt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmPassword_txt.BorderRadius = 1;
            this.confirmPassword_txt.BorderThickness = 1;
            this.confirmPassword_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.confirmPassword_txt.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword_txt.DefaultText = "";
            this.confirmPassword_txt.FillColor = System.Drawing.Color.White;
            this.confirmPassword_txt.HideSelection = true;
            this.confirmPassword_txt.IconLeft = null;
            this.confirmPassword_txt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.confirmPassword_txt.IconPadding = 10;
            this.confirmPassword_txt.IconRight = null;
            this.confirmPassword_txt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.confirmPassword_txt.Location = new System.Drawing.Point(187, 121);
            this.confirmPassword_txt.MaxLength = 32767;
            this.confirmPassword_txt.MinimumSize = new System.Drawing.Size(100, 35);
            this.confirmPassword_txt.Modified = false;
            this.confirmPassword_txt.Name = "confirmPassword_txt";
            this.confirmPassword_txt.PasswordChar = '\0';
            this.confirmPassword_txt.ReadOnly = false;
            this.confirmPassword_txt.SelectedText = "";
            this.confirmPassword_txt.SelectionLength = 0;
            this.confirmPassword_txt.SelectionStart = 0;
            this.confirmPassword_txt.ShortcutsEnabled = true;
            this.confirmPassword_txt.Size = new System.Drawing.Size(370, 35);
            this.confirmPassword_txt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.confirmPassword_txt.TabIndex = 16;
            this.confirmPassword_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.confirmPassword_txt.TextMarginLeft = 5;
            this.confirmPassword_txt.TextPlaceholder = "";
            this.confirmPassword_txt.UseSystemPasswordChar = false;
            // 
            // currentPassword_txt
            // 
            this.currentPassword_txt.AcceptsReturn = false;
            this.currentPassword_txt.AcceptsTab = false;
            this.currentPassword_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.currentPassword_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.currentPassword_txt.BackColor = System.Drawing.Color.Transparent;
            this.currentPassword_txt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("currentPassword_txt.BackgroundImage")));
            this.currentPassword_txt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentPassword_txt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentPassword_txt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentPassword_txt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentPassword_txt.BorderRadius = 1;
            this.currentPassword_txt.BorderThickness = 1;
            this.currentPassword_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.currentPassword_txt.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPassword_txt.DefaultText = "";
            this.currentPassword_txt.FillColor = System.Drawing.Color.White;
            this.currentPassword_txt.HideSelection = true;
            this.currentPassword_txt.IconLeft = null;
            this.currentPassword_txt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.currentPassword_txt.IconPadding = 10;
            this.currentPassword_txt.IconRight = null;
            this.currentPassword_txt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.currentPassword_txt.Location = new System.Drawing.Point(187, 39);
            this.currentPassword_txt.MaxLength = 32767;
            this.currentPassword_txt.MinimumSize = new System.Drawing.Size(100, 35);
            this.currentPassword_txt.Modified = false;
            this.currentPassword_txt.Name = "currentPassword_txt";
            this.currentPassword_txt.PasswordChar = '\0';
            this.currentPassword_txt.ReadOnly = false;
            this.currentPassword_txt.SelectedText = "";
            this.currentPassword_txt.SelectionLength = 0;
            this.currentPassword_txt.SelectionStart = 0;
            this.currentPassword_txt.ShortcutsEnabled = true;
            this.currentPassword_txt.Size = new System.Drawing.Size(370, 35);
            this.currentPassword_txt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.currentPassword_txt.TabIndex = 15;
            this.currentPassword_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.currentPassword_txt.TextMarginLeft = 5;
            this.currentPassword_txt.TextPlaceholder = "";
            this.currentPassword_txt.UseSystemPasswordChar = false;
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoEllipsis = false;
            this.confirmPassword.CursorType = null;
            this.confirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.Location = new System.Drawing.Point(23, 133);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confirmPassword.Size = new System.Drawing.Size(140, 23);
            this.confirmPassword.TabIndex = 14;
            this.confirmPassword.Text = "Confirm Password";
            this.confirmPassword.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // newPassword
            // 
            this.newPassword.AutoEllipsis = false;
            this.newPassword.CursorType = null;
            this.newPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword.Location = new System.Drawing.Point(23, 91);
            this.newPassword.Name = "newPassword";
            this.newPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newPassword.Size = new System.Drawing.Size(115, 23);
            this.newPassword.TabIndex = 13;
            this.newPassword.Text = "New Password";
            this.newPassword.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // currentPassword
            // 
            this.currentPassword.AutoEllipsis = false;
            this.currentPassword.CursorType = null;
            this.currentPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPassword.Location = new System.Drawing.Point(23, 51);
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentPassword.Size = new System.Drawing.Size(139, 23);
            this.currentPassword.TabIndex = 12;
            this.currentPassword.Text = "Current Password";
            this.currentPassword.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // canclebtn
            // 
            this.canclebtn.BackColor = System.Drawing.Color.Transparent;
            this.canclebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("canclebtn.BackgroundImage")));
            this.canclebtn.ButtonText = "Cancle Leaves";
            this.canclebtn.ButtonTextMarginLeft = 0;
            this.canclebtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.canclebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.canclebtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.canclebtn.DisabledForecolor = System.Drawing.Color.White;
            this.canclebtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canclebtn.ForeColor = System.Drawing.Color.White;
            this.canclebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.canclebtn.IconPadding = 6;
            this.canclebtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.canclebtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.canclebtn.IdleBorderRadius = 1;
            this.canclebtn.IdleBorderThickness = 0;
            this.canclebtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.canclebtn.IdleIconLeftImage = global::StaffManagment.Properties.Resources.close;
            this.canclebtn.IdleIconRightImage = null;
            this.canclebtn.Location = new System.Drawing.Point(200, 31);
            this.canclebtn.Margin = new System.Windows.Forms.Padding(2);
            this.canclebtn.Name = "canclebtn";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.canclebtn.onHoverState = stateProperties2;
            this.canclebtn.Size = new System.Drawing.Size(149, 32);
            this.canclebtn.TabIndex = 21;
            this.canclebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.canclebtn.Click += new System.EventHandler(this.canclebtn_Click);
            // 
            // requestbtn
            // 
            this.requestbtn.BackColor = System.Drawing.Color.Transparent;
            this.requestbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("requestbtn.BackgroundImage")));
            this.requestbtn.ButtonText = "Pending Leaves";
            this.requestbtn.ButtonTextMarginLeft = 0;
            this.requestbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.requestbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.requestbtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.requestbtn.DisabledForecolor = System.Drawing.Color.White;
            this.requestbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestbtn.ForeColor = System.Drawing.Color.White;
            this.requestbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.requestbtn.IconPadding = 6;
            this.requestbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.requestbtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.requestbtn.IdleBorderRadius = 1;
            this.requestbtn.IdleBorderThickness = 0;
            this.requestbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.requestbtn.IdleIconLeftImage = global::StaffManagment.Properties.Resources.demo1;
            this.requestbtn.IdleIconRightImage = null;
            this.requestbtn.Location = new System.Drawing.Point(49, 31);
            this.requestbtn.Margin = new System.Windows.Forms.Padding(2);
            this.requestbtn.Name = "requestbtn";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.requestbtn.onHoverState = stateProperties3;
            this.requestbtn.Size = new System.Drawing.Size(149, 32);
            this.requestbtn.TabIndex = 20;
            this.requestbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.requestbtn.Click += new System.EventHandler(this.requestbtn_Click);
            // 
            // staffprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.canclebtn);
            this.Controls.Add(this.requestbtn);
            this.Controls.Add(this.chng_password);
            this.Controls.Add(this.dataGridViewPendingLeaves);
            this.Name = "staffprofile";
            this.Size = new System.Drawing.Size(1085, 737);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingLeaves)).EndInit();
            this.chng_password.ResumeLayout(false);
            this.chng_password.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPendingLeaves;
        private System.Windows.Forms.GroupBox chng_password;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton changePassword_btn;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox newPassword_txt;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox confirmPassword_txt;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox currentPassword_txt;
        private Bunifu.UI.WinForms.BunifuLabel confirmPassword;
        private Bunifu.UI.WinForms.BunifuLabel newPassword;
        private Bunifu.UI.WinForms.BunifuLabel currentPassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton requestbtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton canclebtn;
    }
}
