namespace StaffManagment
{
    partial class requestleave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(requestleave));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.remainleaves = new System.Windows.Forms.GroupBox();
            this.yearLable = new Bunifu.UI.WinForms.BunifuLabel();
            this.nohalfdayLable = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.shortleavelabelTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.medicalLableTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.casualLabelTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.rshortleaves = new Bunifu.UI.WinForms.BunifuLabel();
            this.rhalfday = new Bunifu.UI.WinForms.BunifuLabel();
            this.rfullday = new Bunifu.UI.WinForms.BunifuLabel();
            this.requestlev = new System.Windows.Forms.GroupBox();
            this.selectDateTxt = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.requestlvbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.reasontxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.typetxt = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.reason = new Bunifu.UI.WinForms.BunifuLabel();
            this.type = new Bunifu.UI.WinForms.BunifuLabel();
            this.selectnic = new Bunifu.UI.WinForms.BunifuLabel();
            this.refreshbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.remainleaves.SuspendLayout();
            this.requestlev.SuspendLayout();
            this.SuspendLayout();
            // 
            // remainleaves
            // 
            this.remainleaves.Controls.Add(this.yearLable);
            this.remainleaves.Controls.Add(this.nohalfdayLable);
            this.remainleaves.Controls.Add(this.bunifuLabel2);
            this.remainleaves.Controls.Add(this.shortleavelabelTxt);
            this.remainleaves.Controls.Add(this.medicalLableTxt);
            this.remainleaves.Controls.Add(this.casualLabelTxt);
            this.remainleaves.Controls.Add(this.rshortleaves);
            this.remainleaves.Controls.Add(this.rhalfday);
            this.remainleaves.Controls.Add(this.rfullday);
            this.remainleaves.Location = new System.Drawing.Point(307, 71);
            this.remainleaves.Name = "remainleaves";
            this.remainleaves.Size = new System.Drawing.Size(585, 243);
            this.remainleaves.TabIndex = 0;
            this.remainleaves.TabStop = false;
            this.remainleaves.Text = "Remain Leaves";
            this.remainleaves.Enter += new System.EventHandler(this.remainleaves_Enter);
            // 
            // yearLable
            // 
            this.yearLable.AutoEllipsis = false;
            this.yearLable.CursorType = null;
            this.yearLable.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.yearLable.Location = new System.Drawing.Point(515, 55);
            this.yearLable.Name = "yearLable";
            this.yearLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yearLable.Size = new System.Drawing.Size(39, 22);
            this.yearLable.TabIndex = 23;
            this.yearLable.Text = "xxxx";
            this.yearLable.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nohalfdayLable
            // 
            this.nohalfdayLable.AutoEllipsis = false;
            this.nohalfdayLable.CursorType = null;
            this.nohalfdayLable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nohalfdayLable.Location = new System.Drawing.Point(270, 191);
            this.nohalfdayLable.Name = "nohalfdayLable";
            this.nohalfdayLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nohalfdayLable.Size = new System.Drawing.Size(27, 23);
            this.nohalfdayLable.TabIndex = 22;
            this.nohalfdayLable.Text = "xxx";
            this.nohalfdayLable.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(30, 191);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(174, 23);
            this.bunifuLabel2.TabIndex = 21;
            this.bunifuLabel2.Text = "No of HalfDays Taken  :";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // shortleavelabelTxt
            // 
            this.shortleavelabelTxt.AutoEllipsis = false;
            this.shortleavelabelTxt.CursorType = null;
            this.shortleavelabelTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortleavelabelTxt.Location = new System.Drawing.Point(270, 147);
            this.shortleavelabelTxt.Name = "shortleavelabelTxt";
            this.shortleavelabelTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.shortleavelabelTxt.Size = new System.Drawing.Size(27, 23);
            this.shortleavelabelTxt.TabIndex = 20;
            this.shortleavelabelTxt.Text = "xxx";
            this.shortleavelabelTxt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medicalLableTxt
            // 
            this.medicalLableTxt.AutoEllipsis = false;
            this.medicalLableTxt.CursorType = null;
            this.medicalLableTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalLableTxt.Location = new System.Drawing.Point(270, 100);
            this.medicalLableTxt.Name = "medicalLableTxt";
            this.medicalLableTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.medicalLableTxt.Size = new System.Drawing.Size(27, 23);
            this.medicalLableTxt.TabIndex = 19;
            this.medicalLableTxt.Text = "xxx";
            this.medicalLableTxt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // casualLabelTxt
            // 
            this.casualLabelTxt.AutoEllipsis = false;
            this.casualLabelTxt.CursorType = null;
            this.casualLabelTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casualLabelTxt.Location = new System.Drawing.Point(270, 55);
            this.casualLabelTxt.Name = "casualLabelTxt";
            this.casualLabelTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.casualLabelTxt.Size = new System.Drawing.Size(27, 23);
            this.casualLabelTxt.TabIndex = 18;
            this.casualLabelTxt.Text = "xxx";
            this.casualLabelTxt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rshortleaves
            // 
            this.rshortleaves.AutoEllipsis = false;
            this.rshortleaves.CursorType = null;
            this.rshortleaves.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rshortleaves.Location = new System.Drawing.Point(30, 147);
            this.rshortleaves.Name = "rshortleaves";
            this.rshortleaves.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rshortleaves.Size = new System.Drawing.Size(202, 23);
            this.rshortleaves.TabIndex = 9;
            this.rshortleaves.Text = "Remaining Shorts Leaves  :";
            this.rshortleaves.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // rhalfday
            // 
            this.rhalfday.AutoEllipsis = false;
            this.rhalfday.CursorType = null;
            this.rhalfday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rhalfday.Location = new System.Drawing.Point(30, 100);
            this.rhalfday.Name = "rhalfday";
            this.rhalfday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rhalfday.Size = new System.Drawing.Size(219, 23);
            this.rhalfday.TabIndex = 8;
            this.rhalfday.Text = "Remaining Medical Leaves :";
            this.rhalfday.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // rfullday
            // 
            this.rfullday.AutoEllipsis = false;
            this.rfullday.CursorType = null;
            this.rfullday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfullday.Location = new System.Drawing.Point(30, 55);
            this.rfullday.Name = "rfullday";
            this.rfullday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rfullday.Size = new System.Drawing.Size(210, 23);
            this.rfullday.TabIndex = 7;
            this.rfullday.Text = "Remaining Casual Leaves  :";
            this.rfullday.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.rfullday.Click += new System.EventHandler(this.rfullday_Click);
            // 
            // requestlev
            // 
            this.requestlev.Controls.Add(this.selectDateTxt);
            this.requestlev.Controls.Add(this.requestlvbtn);
            this.requestlev.Controls.Add(this.reasontxt);
            this.requestlev.Controls.Add(this.typetxt);
            this.requestlev.Controls.Add(this.bunifuLabel1);
            this.requestlev.Controls.Add(this.reason);
            this.requestlev.Controls.Add(this.type);
            this.requestlev.Location = new System.Drawing.Point(307, 337);
            this.requestlev.Name = "requestlev";
            this.requestlev.Size = new System.Drawing.Size(585, 262);
            this.requestlev.TabIndex = 1;
            this.requestlev.TabStop = false;
            this.requestlev.Text = "Request Leaves";
            // 
            // selectDateTxt
            // 
            this.selectDateTxt.BorderRadius = 1;
            this.selectDateTxt.Color = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.selectDateTxt.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.selectDateTxt.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.selectDateTxt.DisabledColor = System.Drawing.Color.Gray;
            this.selectDateTxt.DisplayWeekNumbers = false;
            this.selectDateTxt.DPHeight = 0;
            this.selectDateTxt.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.selectDateTxt.FillDatePicker = false;
            this.selectDateTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDateTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.selectDateTxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectDateTxt.Icon = ((System.Drawing.Image)(resources.GetObject("selectDateTxt.Icon")));
            this.selectDateTxt.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.selectDateTxt.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.selectDateTxt.Location = new System.Drawing.Point(143, 138);
            this.selectDateTxt.MinimumSize = new System.Drawing.Size(372, 32);
            this.selectDateTxt.Name = "selectDateTxt";
            this.selectDateTxt.Size = new System.Drawing.Size(372, 32);
            this.selectDateTxt.TabIndex = 16;
            // 
            // requestlvbtn
            // 
            this.requestlvbtn.BackColor = System.Drawing.Color.Transparent;
            this.requestlvbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("requestlvbtn.BackgroundImage")));
            this.requestlvbtn.ButtonText = "Request Leave";
            this.requestlvbtn.ButtonTextMarginLeft = 0;
            this.requestlvbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.requestlvbtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.requestlvbtn.DisabledForecolor = System.Drawing.Color.White;
            this.requestlvbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestlvbtn.ForeColor = System.Drawing.Color.White;
            this.requestlvbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.requestlvbtn.IconPadding = 10;
            this.requestlvbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.requestlvbtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.requestlvbtn.IdleBorderRadius = 1;
            this.requestlvbtn.IdleBorderThickness = 0;
            this.requestlvbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.requestlvbtn.IdleIconLeftImage = null;
            this.requestlvbtn.IdleIconRightImage = null;
            this.requestlvbtn.Location = new System.Drawing.Point(321, 185);
            this.requestlvbtn.Margin = new System.Windows.Forms.Padding(2);
            this.requestlvbtn.Name = "requestlvbtn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.requestlvbtn.onHoverState = stateProperties1;
            this.requestlvbtn.Size = new System.Drawing.Size(194, 32);
            this.requestlvbtn.TabIndex = 13;
            this.requestlvbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.requestlvbtn.Click += new System.EventHandler(this.requestlvbtn_Click);
            // 
            // reasontxt
            // 
            this.reasontxt.AcceptsReturn = false;
            this.reasontxt.AcceptsTab = false;
            this.reasontxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.reasontxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.reasontxt.BackColor = System.Drawing.Color.Transparent;
            this.reasontxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reasontxt.BackgroundImage")));
            this.reasontxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reasontxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reasontxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reasontxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reasontxt.BorderRadius = 1;
            this.reasontxt.BorderThickness = 1;
            this.reasontxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.reasontxt.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasontxt.DefaultText = "";
            this.reasontxt.FillColor = System.Drawing.Color.White;
            this.reasontxt.HideSelection = true;
            this.reasontxt.IconLeft = null;
            this.reasontxt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.reasontxt.IconPadding = 10;
            this.reasontxt.IconRight = null;
            this.reasontxt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.reasontxt.Location = new System.Drawing.Point(145, 88);
            this.reasontxt.MaxLength = 32767;
            this.reasontxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.reasontxt.Modified = false;
            this.reasontxt.Name = "reasontxt";
            this.reasontxt.PasswordChar = '\0';
            this.reasontxt.ReadOnly = false;
            this.reasontxt.SelectedText = "";
            this.reasontxt.SelectionLength = 0;
            this.reasontxt.SelectionStart = 0;
            this.reasontxt.ShortcutsEnabled = true;
            this.reasontxt.Size = new System.Drawing.Size(370, 35);
            this.reasontxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.reasontxt.TabIndex = 11;
            this.reasontxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reasontxt.TextMarginLeft = 5;
            this.reasontxt.TextPlaceholder = "";
            this.reasontxt.UseSystemPasswordChar = false;
            this.reasontxt.TextChange += new System.EventHandler(this.reasontxt_TextChange);
            // 
            // typetxt
            // 
            this.typetxt.BackColor = System.Drawing.Color.White;
            this.typetxt.BorderRadius = 1;
            this.typetxt.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.typetxt.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.typetxt.DisabledColor = System.Drawing.Color.White;
            this.typetxt.DisplayMember = "Academic Staff";
            this.typetxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typetxt.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.typetxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typetxt.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.typetxt.FillDropDown = false;
            this.typetxt.FillIndicator = false;
            this.typetxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typetxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.typetxt.FormattingEnabled = true;
            this.typetxt.Icon = null;
            this.typetxt.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.typetxt.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.typetxt.ItemBackColor = System.Drawing.Color.White;
            this.typetxt.ItemBorderColor = System.Drawing.Color.White;
            this.typetxt.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.typetxt.ItemHeight = 26;
            this.typetxt.ItemHighLightColor = System.Drawing.Color.RosyBrown;
            this.typetxt.Items.AddRange(new object[] {
            "Casual_Leave",
            "Medical_Leave",
            "HalfDay_Leave",
            "Short_Leave"});
            this.typetxt.Location = new System.Drawing.Point(145, 46);
            this.typetxt.Name = "typetxt";
            this.typetxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.typetxt.Size = new System.Drawing.Size(370, 32);
            this.typetxt.TabIndex = 10;
            this.typetxt.Text = null;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(30, 147);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(43, 23);
            this.bunifuLabel1.TabIndex = 9;
            this.bunifuLabel1.Text = "Date";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // reason
            // 
            this.reason.AutoEllipsis = false;
            this.reason.CursorType = null;
            this.reason.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reason.Location = new System.Drawing.Point(30, 100);
            this.reason.Name = "reason";
            this.reason.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reason.Size = new System.Drawing.Size(60, 23);
            this.reason.TabIndex = 8;
            this.reason.Text = "Reason";
            this.reason.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // type
            // 
            this.type.AutoEllipsis = false;
            this.type.CursorType = null;
            this.type.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(30, 55);
            this.type.Name = "type";
            this.type.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.type.Size = new System.Drawing.Size(40, 23);
            this.type.TabIndex = 7;
            this.type.Text = "Type";
            this.type.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // selectnic
            // 
            this.selectnic.AutoEllipsis = false;
            this.selectnic.CursorType = null;
            this.selectnic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectnic.Location = new System.Drawing.Point(504, 27);
            this.selectnic.Name = "selectnic";
            this.selectnic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectnic.Size = new System.Drawing.Size(161, 23);
            this.selectnic.TabIndex = 17;
            this.selectnic.Text = "Leave Request Form";
            this.selectnic.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectnic.Click += new System.EventHandler(this.selectnic_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshbtn.BackgroundImage")));
            this.refreshbtn.ButtonText = "Refresh";
            this.refreshbtn.ButtonTextMarginLeft = 0;
            this.refreshbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.refreshbtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.refreshbtn.DisabledForecolor = System.Drawing.Color.White;
            this.refreshbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.ForeColor = System.Drawing.Color.White;
            this.refreshbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.refreshbtn.IconPadding = 10;
            this.refreshbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.refreshbtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.refreshbtn.IdleBorderRadius = 1;
            this.refreshbtn.IdleBorderThickness = 0;
            this.refreshbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.refreshbtn.IdleIconLeftImage = global::StaffManagment.Properties.Resources.reset;
            this.refreshbtn.IdleIconRightImage = null;
            this.refreshbtn.Location = new System.Drawing.Point(977, 27);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshbtn.Name = "refreshbtn";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.refreshbtn.onHoverState = stateProperties2;
            this.refreshbtn.Size = new System.Drawing.Size(95, 32);
            this.refreshbtn.TabIndex = 17;
            this.refreshbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // requestleave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.selectnic);
            this.Controls.Add(this.requestlev);
            this.Controls.Add(this.remainleaves);
            this.Name = "requestleave";
            this.Size = new System.Drawing.Size(1085, 737);
            this.remainleaves.ResumeLayout(false);
            this.remainleaves.PerformLayout();
            this.requestlev.ResumeLayout(false);
            this.requestlev.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox remainleaves;
        private Bunifu.UI.WinForms.BunifuLabel rfullday;
        private Bunifu.UI.WinForms.BunifuLabel rshortleaves;
        private Bunifu.UI.WinForms.BunifuLabel rhalfday;
        private System.Windows.Forms.GroupBox requestlev;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel reason;
        private Bunifu.UI.WinForms.BunifuLabel type;
        private Bunifu.UI.WinForms.BunifuDropdown typetxt;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox reasontxt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton requestlvbtn;
        private Bunifu.UI.WinForms.BunifuDatePicker selectDateTxt;
        private Bunifu.UI.WinForms.BunifuLabel shortleavelabelTxt;
        private Bunifu.UI.WinForms.BunifuLabel medicalLableTxt;
        private Bunifu.UI.WinForms.BunifuLabel casualLabelTxt;
        private Bunifu.UI.WinForms.BunifuLabel selectnic;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton refreshbtn;
        private Bunifu.UI.WinForms.BunifuLabel yearLable;
        private Bunifu.UI.WinForms.BunifuLabel nohalfdayLable;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
    }
}
