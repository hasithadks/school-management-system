namespace SchoolManagementSystem
{
    partial class IncomeExpensesReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeExpensesReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dropPayMonth = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dropPayYear = new Bunifu.UI.WinForms.BunifuDropdown();
            this.labelTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.labeldate = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtTotalIncome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTotalExpenses = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.IncomeDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomePaymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolManagementSystemDataSet = new StaffManagment.SchoolManagementSystemDataSet();
            this.ExpensesDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.expensesPaymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DragControlIEReport = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.expensesPaymentTableAdapter = new StaffManagment.SchoolManagementSystemDataSetTableAdapters.expensesPaymentTableAdapter();
            this.incomePaymentTableAdapter = new StaffManagment.SchoolManagementSystemDataSetTableAdapters.incomePaymentTableAdapter();
            this.btnReportPrint = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.incomePaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expensesPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomePaymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesPaymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomePaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesPaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(345, 3);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(403, 22);
            this.bunifuLabel2.TabIndex = 84;
            this.bunifuLabel2.Text = "School Management System - Income Expenses Report";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // dropPayMonth
            // 
            this.dropPayMonth.BackColor = System.Drawing.Color.White;
            this.dropPayMonth.BorderRadius = 1;
            this.dropPayMonth.Color = System.Drawing.Color.White;
            this.dropPayMonth.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropPayMonth.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.dropPayMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropPayMonth.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.dropPayMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropPayMonth.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropPayMonth.FillDropDown = false;
            this.dropPayMonth.FillIndicator = false;
            this.dropPayMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropPayMonth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropPayMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropPayMonth.FormattingEnabled = true;
            this.dropPayMonth.Icon = null;
            this.dropPayMonth.IndicatorColor = System.Drawing.Color.Gray;
            this.dropPayMonth.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropPayMonth.ItemBackColor = System.Drawing.Color.White;
            this.dropPayMonth.ItemBorderColor = System.Drawing.Color.White;
            this.dropPayMonth.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropPayMonth.ItemHeight = 26;
            this.dropPayMonth.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.dropPayMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.dropPayMonth.Location = new System.Drawing.Point(966, 68);
            this.dropPayMonth.Name = "dropPayMonth";
            this.dropPayMonth.Size = new System.Drawing.Size(77, 32);
            this.dropPayMonth.TabIndex = 79;
            this.dropPayMonth.Text = null;
            // 
            // dropPayYear
            // 
            this.dropPayYear.BackColor = System.Drawing.Color.White;
            this.dropPayYear.BorderRadius = 1;
            this.dropPayYear.Color = System.Drawing.Color.White;
            this.dropPayYear.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropPayYear.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.dropPayYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropPayYear.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.dropPayYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropPayYear.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropPayYear.FillDropDown = false;
            this.dropPayYear.FillIndicator = false;
            this.dropPayYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropPayYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropPayYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropPayYear.FormattingEnabled = true;
            this.dropPayYear.Icon = null;
            this.dropPayYear.IndicatorColor = System.Drawing.Color.Gray;
            this.dropPayYear.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropPayYear.ItemBackColor = System.Drawing.Color.White;
            this.dropPayYear.ItemBorderColor = System.Drawing.Color.White;
            this.dropPayYear.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropPayYear.ItemHeight = 26;
            this.dropPayYear.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.dropPayYear.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.dropPayYear.Location = new System.Drawing.Point(799, 69);
            this.dropPayYear.Name = "dropPayYear";
            this.dropPayYear.Size = new System.Drawing.Size(162, 32);
            this.dropPayYear.TabIndex = 78;
            this.dropPayYear.Text = null;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoEllipsis = false;
            this.labelTitle.CursorType = null;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(354, 136);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitle.Size = new System.Drawing.Size(0, 0);
            this.labelTitle.TabIndex = 82;
            this.labelTitle.Text = null;
            this.labelTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // labeldate
            // 
            this.labeldate.AutoEllipsis = false;
            this.labeldate.CursorType = null;
            this.labeldate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labeldate.Location = new System.Drawing.Point(453, 173);
            this.labeldate.Name = "labeldate";
            this.labeldate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labeldate.Size = new System.Drawing.Size(0, 0);
            this.labeldate.TabIndex = 81;
            this.labeldate.Text = null;
            this.labeldate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel6.Location = new System.Drawing.Point(658, 74);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(122, 23);
            this.bunifuLabel6.TabIndex = 80;
            this.bunifuLabel6.Text = "Select a Month";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.AutoSize = false;
            this.bunifuLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.bunifuLabel5.Location = new System.Drawing.Point(6, 277);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(540, 32);
            this.bunifuLabel5.TabIndex = 77;
            this.bunifuLabel5.Text = "Total Income";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(6, 715);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(263, 32);
            this.bunifuLabel1.TabIndex = 76;
            this.bunifuLabel1.Text = "Total Income";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalIncome
            // 
            this.txtTotalIncome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTotalIncome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTotalIncome.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalIncome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalIncome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalIncome.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotalIncome.HintText = "";
            this.txtTotalIncome.isPassword = false;
            this.txtTotalIncome.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.txtTotalIncome.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.txtTotalIncome.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.txtTotalIncome.LineThickness = 3;
            this.txtTotalIncome.Location = new System.Drawing.Point(277, 707);
            this.txtTotalIncome.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTotalIncome.MaxLength = 32767;
            this.txtTotalIncome.Name = "txtTotalIncome";
            this.txtTotalIncome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalIncome.Size = new System.Drawing.Size(263, 40);
            this.txtTotalIncome.TabIndex = 73;
            this.txtTotalIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.AutoSize = false;
            this.bunifuLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.bunifuLabel4.Location = new System.Drawing.Point(556, 277);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(536, 32);
            this.bunifuLabel4.TabIndex = 75;
            this.bunifuLabel4.Text = "Total Expenses";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(552, 715);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(263, 32);
            this.bunifuLabel3.TabIndex = 74;
            this.bunifuLabel3.Text = "Total Expenses";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(799, 75);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuMaterialTextbox3.MaxLength = 32767;
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(162, 32);
            this.bunifuMaterialTextbox3.TabIndex = 72;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(966, 75);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuMaterialTextbox2.MaxLength = 32767;
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(77, 32);
            this.bunifuMaterialTextbox2.TabIndex = 71;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTotalExpenses
            // 
            this.txtTotalExpenses.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTotalExpenses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTotalExpenses.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalExpenses.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalExpenses.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalExpenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalExpenses.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotalExpenses.HintText = "";
            this.txtTotalExpenses.isPassword = false;
            this.txtTotalExpenses.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.txtTotalExpenses.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.txtTotalExpenses.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.txtTotalExpenses.LineThickness = 3;
            this.txtTotalExpenses.Location = new System.Drawing.Point(823, 707);
            this.txtTotalExpenses.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTotalExpenses.MaxLength = 32767;
            this.txtTotalExpenses.Name = "txtTotalExpenses";
            this.txtTotalExpenses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalExpenses.Size = new System.Drawing.Size(263, 40);
            this.txtTotalExpenses.TabIndex = 70;
            this.txtTotalExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // IncomeDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.IncomeDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.IncomeDataGrid.AutoGenerateColumns = false;
            this.IncomeDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.IncomeDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IncomeDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IncomeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.IncomeDataGrid.ColumnHeadersHeight = 30;
            this.IncomeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.IncomeDataGrid.DataSource = this.incomePaymentBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.IncomeDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.IncomeDataGrid.DoubleBuffered = true;
            this.IncomeDataGrid.EnableHeadersVisualStyles = false;
            this.IncomeDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.IncomeDataGrid.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.IncomeDataGrid.Location = new System.Drawing.Point(6, 309);
            this.IncomeDataGrid.Name = "IncomeDataGrid";
            this.IncomeDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IncomeDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.IncomeDataGrid.RowHeadersWidth = 40;
            this.IncomeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IncomeDataGrid.Size = new System.Drawing.Size(540, 315);
            this.IncomeDataGrid.TabIndex = 69;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "incomeUnitName";
            this.dataGridViewTextBoxColumn4.HeaderText = "UnitName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 165;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "incomeType";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 185;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "incomeAmount";
            this.dataGridViewTextBoxColumn6.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // incomePaymentBindingSource1
            // 
            this.incomePaymentBindingSource1.DataMember = "incomePayment";
            this.incomePaymentBindingSource1.DataSource = this.schoolManagementSystemDataSet;
            // 
            // schoolManagementSystemDataSet
            // 
            this.schoolManagementSystemDataSet.DataSetName = "SchoolManagementSystemDataSet";
            this.schoolManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExpensesDataGrid
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.ExpensesDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ExpensesDataGrid.AutoGenerateColumns = false;
            this.ExpensesDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ExpensesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpensesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ExpensesDataGrid.ColumnHeadersHeight = 30;
            this.ExpensesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ExpensesDataGrid.DataSource = this.expensesPaymentBindingSource1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpensesDataGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.ExpensesDataGrid.DoubleBuffered = true;
            this.ExpensesDataGrid.EnableHeadersVisualStyles = false;
            this.ExpensesDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.ExpensesDataGrid.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.ExpensesDataGrid.Location = new System.Drawing.Point(556, 309);
            this.ExpensesDataGrid.Name = "ExpensesDataGrid";
            this.ExpensesDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ExpensesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpensesDataGrid.Size = new System.Drawing.Size(540, 315);
            this.ExpensesDataGrid.TabIndex = 68;
            // 
            // expensesPaymentBindingSource1
            // 
            this.expensesPaymentBindingSource1.DataMember = "expensesPayment";
            this.expensesPaymentBindingSource1.DataSource = this.schoolManagementSystemDataSet;
            // 
            // DragControlIEReport
            // 
            this.DragControlIEReport.Fixed = true;
            this.DragControlIEReport.Horizontal = true;
            this.DragControlIEReport.TargetControl = this;
            this.DragControlIEReport.Vertical = true;
            // 
            // expensesPaymentTableAdapter
            // 
            this.expensesPaymentTableAdapter.ClearBeforeFill = true;
            // 
            // incomePaymentTableAdapter
            // 
            this.incomePaymentTableAdapter.ClearBeforeFill = true;
            // 
            // btnReportPrint
            // 
            this.btnReportPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnReportPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportPrint.BackgroundImage")));
            this.btnReportPrint.ButtonText = "PRINT";
            this.btnReportPrint.ButtonTextMarginLeft = 0;
            this.btnReportPrint.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnReportPrint.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnReportPrint.DisabledForecolor = System.Drawing.Color.White;
            this.btnReportPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.btnReportPrint.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReportPrint.IconPadding = 5;
            this.btnReportPrint.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReportPrint.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnReportPrint.IdleBorderRadius = 15;
            this.btnReportPrint.IdleBorderThickness = 1;
            this.btnReportPrint.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnReportPrint.IdleIconLeftImage = global::StaffManagment.Properties.Resources.print;
            this.btnReportPrint.IdleIconRightImage = null;
            this.btnReportPrint.Location = new System.Drawing.Point(6, 74);
            this.btnReportPrint.Name = "btnReportPrint";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.BorderRadius = 15;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.IconLeftImage = global::StaffManagment.Properties.Resources.print;
            stateProperties1.IconRightImage = null;
            this.btnReportPrint.onHoverState = stateProperties1;
            this.btnReportPrint.Size = new System.Drawing.Size(101, 32);
            this.btnReportPrint.TabIndex = 85;
            this.btnReportPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportPrint.Click += new System.EventHandler(this.btnReportPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = global::StaffManagment.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(1048, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 35);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 83;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // expensesPaymentBindingSource
            // 
            this.expensesPaymentBindingSource.DataMember = "expensesPayment";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "expensesUnitName";
            this.dataGridViewTextBoxColumn1.HeaderText = "UnitName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "expensesType";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 165;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "expensesAmount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // IncomeExpensesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReportPrint);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dropPayMonth);
            this.Controls.Add(this.dropPayYear);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txtTotalIncome);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuMaterialTextbox3);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.txtTotalExpenses);
            this.Controls.Add(this.IncomeDataGrid);
            this.Controls.Add(this.ExpensesDataGrid);
            this.Name = "IncomeExpensesReport";
            this.Size = new System.Drawing.Size(1098, 755);
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomePaymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesPaymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomePaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesPaymentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.PictureBox btnSearch;
        private Bunifu.UI.WinForms.BunifuDropdown dropPayMonth;
        private Bunifu.UI.WinForms.BunifuDropdown dropPayYear;
        private Bunifu.UI.WinForms.BunifuLabel labelTitle;
        private Bunifu.UI.WinForms.BunifuLabel labeldate;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotalIncome;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotalExpenses;
        public Bunifu.Framework.UI.BunifuCustomDataGrid IncomeDataGrid;
        public Bunifu.Framework.UI.BunifuCustomDataGrid ExpensesDataGrid;
        private System.Windows.Forms.BindingSource incomePaymentBindingSource;
       
        private System.Windows.Forms.BindingSource expensesPaymentBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesUnitNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesAmountDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuDragControl DragControlIEReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeUnitNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeAmountDataGridViewTextBoxColumn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReportPrint;
        private System.Windows.Forms.BindingSource incomePaymentBindingSource1;
        private StaffManagment.SchoolManagementSystemDataSet schoolManagementSystemDataSet;
        private System.Windows.Forms.BindingSource expensesPaymentBindingSource1;
        private StaffManagment.SchoolManagementSystemDataSetTableAdapters.expensesPaymentTableAdapter expensesPaymentTableAdapter;
        private StaffManagment.SchoolManagementSystemDataSetTableAdapters.incomePaymentTableAdapter incomePaymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
