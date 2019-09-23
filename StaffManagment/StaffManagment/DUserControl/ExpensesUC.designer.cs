namespace SchoolManagementSystem
{
    partial class ExpensesUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpensesUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.DragControlExpenses = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ExpensesDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesPaymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolManagementSystemDataSet = new StaffManagment.SchoolManagementSystemDataSet();
            this.dropExpensesType = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dropExpensesUnitName = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtExpensesDescription = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtExpensesAmount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.expensesPaymentTableAdapter = new StaffManagment.SchoolManagementSystemDataSetTableAdapters.expensesPaymentTableAdapter();
            this.txtExpensesDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btnDemo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExpensesReset = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExpensesDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExpensesUpdate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExpensesInsert = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.expensesPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesPaymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesPaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(392, 3);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(357, 22);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "School Management System - Expenses Payment";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(185, 125);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(160, 23);
            this.bunifuLabel2.TabIndex = 5;
            this.bunifuLabel2.Text = "Expenses Unit Name";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(231, 177);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(114, 23);
            this.bunifuLabel3.TabIndex = 5;
            this.bunifuLabel3.Text = "Expenses Type";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel4.Location = new System.Drawing.Point(203, 234);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(142, 23);
            this.bunifuLabel4.TabIndex = 5;
            this.bunifuLabel4.Text = "Expenses Amount";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel5.Location = new System.Drawing.Point(228, 288);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(117, 23);
            this.bunifuLabel5.TabIndex = 5;
            this.bunifuLabel5.Text = "Expenses Date";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.bunifuLabel6.Location = new System.Drawing.Point(181, 345);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(164, 23);
            this.bunifuLabel6.TabIndex = 5;
            this.bunifuLabel6.Text = "Expenses Description";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // DragControlExpenses
            // 
            this.DragControlExpenses.Fixed = true;
            this.DragControlExpenses.Horizontal = true;
            this.DragControlExpenses.TargetControl = this;
            this.DragControlExpenses.Vertical = true;
            // 
            // ExpensesDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.ExpensesDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ExpensesDataGrid.AutoGenerateColumns = false;
            this.ExpensesDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ExpensesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpensesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ExpensesDataGrid.ColumnHeadersHeight = 50;
            this.ExpensesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ExpensesDataGrid.DataSource = this.expensesPaymentBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpensesDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ExpensesDataGrid.DoubleBuffered = true;
            this.ExpensesDataGrid.EnableHeadersVisualStyles = false;
            this.ExpensesDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.ExpensesDataGrid.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.ExpensesDataGrid.Location = new System.Drawing.Point(0, 492);
            this.ExpensesDataGrid.Name = "ExpensesDataGrid";
            this.ExpensesDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ExpensesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpensesDataGrid.Size = new System.Drawing.Size(1098, 263);
            this.ExpensesDataGrid.TabIndex = 29;
            this.ExpensesDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpensesDataGrid_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "expensesID";
            this.dataGridViewTextBoxColumn1.HeaderText = "expensesID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "expensesUnitName";
            this.dataGridViewTextBoxColumn2.HeaderText = "expensesUnitName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "expensesType";
            this.dataGridViewTextBoxColumn3.HeaderText = "expensesType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "expensesAmount";
            this.dataGridViewTextBoxColumn4.HeaderText = "expensesAmount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "expensesDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "expensesDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "expensesDescription";
            this.dataGridViewTextBoxColumn6.HeaderText = "expensesDescription";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // expensesPaymentBindingSource1
            // 
            this.expensesPaymentBindingSource1.DataMember = "expensesPayment";
            this.expensesPaymentBindingSource1.DataSource = this.schoolManagementSystemDataSet;
            // 
            // schoolManagementSystemDataSet
            // 
            this.schoolManagementSystemDataSet.DataSetName = "SchoolManagementSystemDataSet";
            this.schoolManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dropExpensesType
            // 
            this.dropExpensesType.BackColor = System.Drawing.Color.White;
            this.dropExpensesType.BorderRadius = 1;
            this.dropExpensesType.Color = System.Drawing.Color.White;
            this.dropExpensesType.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropExpensesType.DisabledColor = System.Drawing.Color.Gray;
            this.dropExpensesType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropExpensesType.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.dropExpensesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropExpensesType.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropExpensesType.FillDropDown = false;
            this.dropExpensesType.FillIndicator = false;
            this.dropExpensesType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropExpensesType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropExpensesType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropExpensesType.FormattingEnabled = true;
            this.dropExpensesType.Icon = null;
            this.dropExpensesType.IndicatorColor = System.Drawing.Color.Gray;
            this.dropExpensesType.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropExpensesType.ItemBackColor = System.Drawing.Color.White;
            this.dropExpensesType.ItemBorderColor = System.Drawing.Color.White;
            this.dropExpensesType.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropExpensesType.ItemHeight = 26;
            this.dropExpensesType.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.dropExpensesType.Items.AddRange(new object[] {
            "Water line Repair",
            "Communication Unit Expenses",
            "Office Expenses",
            "Class Room Manitanance"});
            this.dropExpensesType.Location = new System.Drawing.Point(379, 173);
            this.dropExpensesType.Name = "dropExpensesType";
            this.dropExpensesType.Size = new System.Drawing.Size(401, 32);
            this.dropExpensesType.TabIndex = 11;
            this.dropExpensesType.Text = null;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(378, 126);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.MaxLength = 32767;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(402, 32);
            this.bunifuMaterialTextbox1.TabIndex = 31;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dropExpensesUnitName
            // 
            this.dropExpensesUnitName.BackColor = System.Drawing.Color.White;
            this.dropExpensesUnitName.BorderRadius = 1;
            this.dropExpensesUnitName.Color = System.Drawing.Color.White;
            this.dropExpensesUnitName.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropExpensesUnitName.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.dropExpensesUnitName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropExpensesUnitName.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.dropExpensesUnitName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropExpensesUnitName.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropExpensesUnitName.FillDropDown = false;
            this.dropExpensesUnitName.FillIndicator = false;
            this.dropExpensesUnitName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropExpensesUnitName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropExpensesUnitName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropExpensesUnitName.FormattingEnabled = true;
            this.dropExpensesUnitName.Icon = null;
            this.dropExpensesUnitName.IndicatorColor = System.Drawing.Color.Gray;
            this.dropExpensesUnitName.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropExpensesUnitName.ItemBackColor = System.Drawing.Color.White;
            this.dropExpensesUnitName.ItemBorderColor = System.Drawing.Color.White;
            this.dropExpensesUnitName.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropExpensesUnitName.ItemHeight = 26;
            this.dropExpensesUnitName.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.dropExpensesUnitName.Items.AddRange(new object[] {
            "Art Room",
            "Communication Unit",
            "Computer Lab",
            "Library",
            "Music Room",
            "Other"});
            this.dropExpensesUnitName.Location = new System.Drawing.Point(379, 121);
            this.dropExpensesUnitName.Name = "dropExpensesUnitName";
            this.dropExpensesUnitName.Size = new System.Drawing.Size(401, 32);
            this.dropExpensesUnitName.TabIndex = 11;
            this.dropExpensesUnitName.Text = null;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(379, 178);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.MaxLength = 32767;
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(401, 32);
            this.bunifuMaterialTextbox2.TabIndex = 31;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(379, 288);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.MaxLength = 32767;
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(401, 32);
            this.bunifuMaterialTextbox3.TabIndex = 31;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtExpensesDescription
            // 
            this.txtExpensesDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtExpensesDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtExpensesDescription.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtExpensesDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExpensesDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpensesDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExpensesDescription.HintForeColor = System.Drawing.Color.Empty;
            this.txtExpensesDescription.HintText = "";
            this.txtExpensesDescription.isPassword = false;
            this.txtExpensesDescription.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.txtExpensesDescription.LineIdleColor = System.Drawing.Color.Gray;
            this.txtExpensesDescription.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.txtExpensesDescription.LineThickness = 3;
            this.txtExpensesDescription.Location = new System.Drawing.Point(379, 337);
            this.txtExpensesDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtExpensesDescription.MaxLength = 32767;
            this.txtExpensesDescription.Name = "txtExpensesDescription";
            this.txtExpensesDescription.Size = new System.Drawing.Size(401, 40);
            this.txtExpensesDescription.TabIndex = 31;
            this.txtExpensesDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtExpensesAmount
            // 
            this.txtExpensesAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtExpensesAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtExpensesAmount.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtExpensesAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExpensesAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpensesAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExpensesAmount.HintForeColor = System.Drawing.Color.Empty;
            this.txtExpensesAmount.HintText = "";
            this.txtExpensesAmount.isPassword = false;
            this.txtExpensesAmount.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.txtExpensesAmount.LineIdleColor = System.Drawing.Color.Gray;
            this.txtExpensesAmount.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.txtExpensesAmount.LineThickness = 3;
            this.txtExpensesAmount.Location = new System.Drawing.Point(379, 225);
            this.txtExpensesAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtExpensesAmount.MaxLength = 32767;
            this.txtExpensesAmount.Name = "txtExpensesAmount";
            this.txtExpensesAmount.Size = new System.Drawing.Size(401, 40);
            this.txtExpensesAmount.TabIndex = 31;
            this.txtExpensesAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // expensesPaymentTableAdapter
            // 
            this.expensesPaymentTableAdapter.ClearBeforeFill = true;
            // 
            // txtExpensesDate
            // 
            this.txtExpensesDate.BorderRadius = 1;
            this.txtExpensesDate.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpensesDate.Color = System.Drawing.Color.White;
            this.txtExpensesDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.txtExpensesDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.txtExpensesDate.DisabledColor = System.Drawing.Color.Gray;
            this.txtExpensesDate.DisplayWeekNumbers = false;
            this.txtExpensesDate.DPHeight = 0;
            this.txtExpensesDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtExpensesDate.FillDatePicker = false;
            this.txtExpensesDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpensesDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExpensesDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtExpensesDate.Icon = ((System.Drawing.Image)(resources.GetObject("txtExpensesDate.Icon")));
            this.txtExpensesDate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExpensesDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.txtExpensesDate.Location = new System.Drawing.Point(379, 285);
            this.txtExpensesDate.MinimumSize = new System.Drawing.Size(401, 32);
            this.txtExpensesDate.Name = "txtExpensesDate";
            this.txtExpensesDate.Size = new System.Drawing.Size(401, 32);
            this.txtExpensesDate.TabIndex = 14;
            // 
            // btnDemo
            // 
            this.btnDemo.BackColor = System.Drawing.Color.Transparent;
            this.btnDemo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDemo.BackgroundImage")));
            this.btnDemo.ButtonText = "DEMO";
            this.btnDemo.ButtonTextMarginLeft = 0;
            this.btnDemo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnDemo.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnDemo.DisabledForecolor = System.Drawing.Color.White;
            this.btnDemo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.btnDemo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDemo.IconPadding = 5;
            this.btnDemo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDemo.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnDemo.IdleBorderRadius = 15;
            this.btnDemo.IdleBorderThickness = 1;
            this.btnDemo.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnDemo.IdleIconLeftImage = global::StaffManagment.Properties.Resources.demo;
            this.btnDemo.IdleIconRightImage = null;
            this.btnDemo.Location = new System.Drawing.Point(816, 331);
            this.btnDemo.Name = "btnDemo";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.BorderRadius = 15;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.IconLeftImage = global::StaffManagment.Properties.Resources.demo1;
            stateProperties1.IconRightImage = null;
            this.btnDemo.onHoverState = stateProperties1;
            this.btnDemo.Size = new System.Drawing.Size(101, 32);
            this.btnDemo.TabIndex = 6;
            this.btnDemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // btnExpensesReset
            // 
            this.btnExpensesReset.BackColor = System.Drawing.Color.Transparent;
            this.btnExpensesReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExpensesReset.BackgroundImage")));
            this.btnExpensesReset.ButtonText = "RESET";
            this.btnExpensesReset.ButtonTextMarginLeft = 0;
            this.btnExpensesReset.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExpensesReset.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnExpensesReset.DisabledForecolor = System.Drawing.Color.White;
            this.btnExpensesReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpensesReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.btnExpensesReset.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExpensesReset.IconPadding = 5;
            this.btnExpensesReset.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExpensesReset.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnExpensesReset.IdleBorderRadius = 15;
            this.btnExpensesReset.IdleBorderThickness = 1;
            this.btnExpensesReset.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnExpensesReset.IdleIconLeftImage = global::StaffManagment.Properties.Resources.reset;
            this.btnExpensesReset.IdleIconRightImage = null;
            this.btnExpensesReset.Location = new System.Drawing.Point(816, 276);
            this.btnExpensesReset.Name = "btnExpensesReset";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties2.BorderRadius = 15;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties2.IconLeftImage = global::StaffManagment.Properties.Resources.reset;
            stateProperties2.IconRightImage = null;
            this.btnExpensesReset.onHoverState = stateProperties2;
            this.btnExpensesReset.Size = new System.Drawing.Size(101, 32);
            this.btnExpensesReset.TabIndex = 6;
            this.btnExpensesReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpensesReset.Click += new System.EventHandler(this.btnExpensesReset_Click);
            // 
            // btnExpensesDelete
            // 
            this.btnExpensesDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnExpensesDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExpensesDelete.BackgroundImage")));
            this.btnExpensesDelete.ButtonText = "DELETE";
            this.btnExpensesDelete.ButtonTextMarginLeft = 0;
            this.btnExpensesDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExpensesDelete.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnExpensesDelete.DisabledForecolor = System.Drawing.Color.White;
            this.btnExpensesDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpensesDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.btnExpensesDelete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExpensesDelete.IconPadding = 5;
            this.btnExpensesDelete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExpensesDelete.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnExpensesDelete.IdleBorderRadius = 15;
            this.btnExpensesDelete.IdleBorderThickness = 1;
            this.btnExpensesDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnExpensesDelete.IdleIconLeftImage = global::StaffManagment.Properties.Resources.delete;
            this.btnExpensesDelete.IdleIconRightImage = null;
            this.btnExpensesDelete.Location = new System.Drawing.Point(816, 221);
            this.btnExpensesDelete.Name = "btnExpensesDelete";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties3.BorderRadius = 15;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties3.IconLeftImage = global::StaffManagment.Properties.Resources.delete;
            stateProperties3.IconRightImage = null;
            this.btnExpensesDelete.onHoverState = stateProperties3;
            this.btnExpensesDelete.Size = new System.Drawing.Size(101, 32);
            this.btnExpensesDelete.TabIndex = 6;
            this.btnExpensesDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpensesDelete.Click += new System.EventHandler(this.btnExpensesDelete_Click);
            // 
            // btnExpensesUpdate
            // 
            this.btnExpensesUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnExpensesUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExpensesUpdate.BackgroundImage")));
            this.btnExpensesUpdate.ButtonText = "UPDATE";
            this.btnExpensesUpdate.ButtonTextMarginLeft = 0;
            this.btnExpensesUpdate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExpensesUpdate.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnExpensesUpdate.DisabledForecolor = System.Drawing.Color.White;
            this.btnExpensesUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpensesUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.btnExpensesUpdate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExpensesUpdate.IconPadding = 5;
            this.btnExpensesUpdate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExpensesUpdate.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnExpensesUpdate.IdleBorderRadius = 15;
            this.btnExpensesUpdate.IdleBorderThickness = 1;
            this.btnExpensesUpdate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnExpensesUpdate.IdleIconLeftImage = global::StaffManagment.Properties.Resources.update;
            this.btnExpensesUpdate.IdleIconRightImage = null;
            this.btnExpensesUpdate.Location = new System.Drawing.Point(816, 166);
            this.btnExpensesUpdate.Name = "btnExpensesUpdate";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties4.BorderRadius = 15;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties4.IconLeftImage = global::StaffManagment.Properties.Resources.update;
            stateProperties4.IconRightImage = null;
            this.btnExpensesUpdate.onHoverState = stateProperties4;
            this.btnExpensesUpdate.Size = new System.Drawing.Size(101, 32);
            this.btnExpensesUpdate.TabIndex = 6;
            this.btnExpensesUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpensesUpdate.Click += new System.EventHandler(this.btnExpensesUpdate_Click);
            // 
            // btnExpensesInsert
            // 
            this.btnExpensesInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnExpensesInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExpensesInsert.BackgroundImage")));
            this.btnExpensesInsert.ButtonText = "INSERT";
            this.btnExpensesInsert.ButtonTextMarginLeft = 0;
            this.btnExpensesInsert.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExpensesInsert.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnExpensesInsert.DisabledForecolor = System.Drawing.Color.White;
            this.btnExpensesInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpensesInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.btnExpensesInsert.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExpensesInsert.IconPadding = 5;
            this.btnExpensesInsert.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExpensesInsert.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnExpensesInsert.IdleBorderRadius = 15;
            this.btnExpensesInsert.IdleBorderThickness = 1;
            this.btnExpensesInsert.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnExpensesInsert.IdleIconLeftImage = global::StaffManagment.Properties.Resources.insert;
            this.btnExpensesInsert.IdleIconRightImage = null;
            this.btnExpensesInsert.Location = new System.Drawing.Point(816, 116);
            this.btnExpensesInsert.Name = "btnExpensesInsert";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties5.BorderRadius = 15;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties5.IconLeftImage = global::StaffManagment.Properties.Resources.insert;
            stateProperties5.IconRightImage = null;
            this.btnExpensesInsert.onHoverState = stateProperties5;
            this.btnExpensesInsert.Size = new System.Drawing.Size(101, 32);
            this.btnExpensesInsert.TabIndex = 6;
            this.btnExpensesInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpensesInsert.Click += new System.EventHandler(this.btnExpensesInsert_Click);
            // 
            // ExpensesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.dropExpensesUnitName);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.txtExpensesDate);
            this.Controls.Add(this.dropExpensesType);
            this.Controls.Add(this.ExpensesDataGrid);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.btnExpensesReset);
            this.Controls.Add(this.btnExpensesDelete);
            this.Controls.Add(this.btnExpensesUpdate);
            this.Controls.Add(this.btnExpensesInsert);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txtExpensesAmount);
            this.Controls.Add(this.txtExpensesDescription);
            this.Controls.Add(this.bunifuMaterialTextbox3);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Name = "ExpensesUC";
            this.Size = new System.Drawing.Size(1098, 755);
            this.Load += new System.EventHandler(this.ExpensesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesPaymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesPaymentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExpensesInsert;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExpensesUpdate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExpensesDelete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExpensesReset;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDemo;
        private Bunifu.Framework.UI.BunifuDragControl DragControlExpenses;
        public Bunifu.Framework.UI.BunifuCustomDataGrid ExpensesDataGrid;
        private System.Windows.Forms.BindingSource expensesPaymentBindingSource;
        
        private Bunifu.UI.WinForms.BunifuDatePicker txtExpensesDate;
        private Bunifu.UI.WinForms.BunifuDropdown dropExpensesType;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesUnitNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesDescriptionDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.UI.WinForms.BunifuDropdown dropExpensesUnitName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtExpensesDescription;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtExpensesAmount;
        private System.Windows.Forms.BindingSource expensesPaymentBindingSource1;
        private StaffManagment.SchoolManagementSystemDataSet schoolManagementSystemDataSet;
        private StaffManagment.SchoolManagementSystemDataSetTableAdapters.expensesPaymentTableAdapter expensesPaymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
