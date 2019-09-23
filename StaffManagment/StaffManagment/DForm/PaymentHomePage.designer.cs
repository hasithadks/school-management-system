namespace SchoolManagementSystem
{
    partial class PaymentHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentHomePage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.DragControlMainPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControlSidePanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ElipseMainPanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseSidePanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnMinimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnNormalize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.paymentMainPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.paymentSidePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuButton6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnReport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnIncome = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPayroll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExpenses = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnMainMenu = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.paymentSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControlMainPanel
            // 
            this.DragControlMainPanel.Fixed = true;
            this.DragControlMainPanel.Horizontal = true;
            this.DragControlMainPanel.TargetControl = this.paymentMainPanel;
            this.DragControlMainPanel.Vertical = true;
            // 
            // DragControlSidePanel
            // 
            this.DragControlSidePanel.Fixed = true;
            this.DragControlSidePanel.Horizontal = true;
            this.DragControlSidePanel.TargetControl = this.paymentSidePanel;
            this.DragControlSidePanel.Vertical = true;
            // 
            // ElipseMainPanel
            // 
            this.ElipseMainPanel.ElipseRadius = 0;
            this.ElipseMainPanel.TargetControl = this.paymentMainPanel;
            // 
            // ElipseSidePanel
            // 
            this.ElipseSidePanel.ElipseRadius = 0;
            this.ElipseSidePanel.TargetControl = this.paymentSidePanel;
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
            this.btnClose.Image = global::StaffManagment.Properties.Resources.closebtn;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 10;
            this.btnClose.ImageSize = new System.Drawing.Size(28, 25);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(38, 35);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(1322, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = true;
            this.btnClose.Size = new System.Drawing.Size(38, 35);
            this.btnClose.TabIndex = 2;
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
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0;
            this.btnMinimize.ShowActiveImage = true;
            this.btnMinimize.ShowCursorChanges = true;
            this.btnMinimize.ShowImageBorders = true;
            this.btnMinimize.ShowSizeMarkers = true;
            this.btnMinimize.Size = new System.Drawing.Size(38, 35);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.ToolTipText = "";
            this.btnMinimize.WaitOnLoad = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.ZoomSpeed = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnNormalize.Name = "btnNormalize";
            this.btnNormalize.Rotation = 0;
            this.btnNormalize.ShowActiveImage = true;
            this.btnNormalize.ShowCursorChanges = true;
            this.btnNormalize.ShowImageBorders = true;
            this.btnNormalize.ShowSizeMarkers = true;
            this.btnNormalize.Size = new System.Drawing.Size(38, 35);
            this.btnNormalize.TabIndex = 2;
            this.btnNormalize.ToolTipText = "";
            this.btnNormalize.WaitOnLoad = false;
            this.btnNormalize.Zoom = 10;
            this.btnNormalize.ZoomSpeed = 10;
            // 
            // paymentMainPanel
            // 
            this.paymentMainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paymentMainPanel.BackgroundImage")));
            this.paymentMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paymentMainPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.paymentMainPanel.GradientBottomRight = System.Drawing.Color.White;
            this.paymentMainPanel.GradientTopLeft = System.Drawing.Color.White;
            this.paymentMainPanel.GradientTopRight = System.Drawing.Color.White;
            this.paymentMainPanel.Location = new System.Drawing.Point(255, 6);
            this.paymentMainPanel.Name = "paymentMainPanel";
            this.paymentMainPanel.Quality = 10;
            this.paymentMainPanel.Size = new System.Drawing.Size(1098, 755);
            this.paymentMainPanel.TabIndex = 1;
            this.paymentMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paymentMainPanel_Paint);
            // 
            // paymentSidePanel
            // 
            this.paymentSidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paymentSidePanel.BackgroundImage")));
            this.paymentSidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paymentSidePanel.Controls.Add(this.bunifuButton6);
            this.paymentSidePanel.Controls.Add(this.btnReport);
            this.paymentSidePanel.Controls.Add(this.btnIncome);
            this.paymentSidePanel.Controls.Add(this.btnPayroll);
            this.paymentSidePanel.Controls.Add(this.btnExpenses);
            this.paymentSidePanel.Controls.Add(this.btnMainMenu);
            this.paymentSidePanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.paymentSidePanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.paymentSidePanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.paymentSidePanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.paymentSidePanel.Location = new System.Drawing.Point(-2, 0);
            this.paymentSidePanel.Name = "paymentSidePanel";
            this.paymentSidePanel.Quality = 10;
            this.paymentSidePanel.Size = new System.Drawing.Size(250, 769);
            this.paymentSidePanel.TabIndex = 0;
            // 
            // bunifuButton6
            // 
            this.bunifuButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton6.BackgroundImage")));
            this.bunifuButton6.ButtonText = "LOGOUT";
            this.bunifuButton6.ButtonTextMarginLeft = 0;
            this.bunifuButton6.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton6.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton6.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.bunifuButton6.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton6.IconPadding = 9;
            this.bunifuButton6.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton6.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.bunifuButton6.IdleBorderRadius = 1;
            this.bunifuButton6.IdleBorderThickness = 0;
            this.bunifuButton6.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.bunifuButton6.IdleIconLeftImage = global::StaffManagment.Properties.Resources.logout;
            this.bunifuButton6.IdleIconRightImage = null;
            this.bunifuButton6.Location = new System.Drawing.Point(0, 545);
            this.bunifuButton6.Name = "bunifuButton6";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties1.IconLeftImage = global::StaffManagment.Properties.Resources.logout1;
            stateProperties1.IconRightImage = null;
            this.bunifuButton6.onHoverState = stateProperties1;
            this.bunifuButton6.Size = new System.Drawing.Size(250, 43);
            this.bunifuButton6.TabIndex = 1;
            this.bunifuButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.ButtonText = "REPORT";
            this.btnReport.ButtonTextMarginLeft = 0;
            this.btnReport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnReport.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnReport.DisabledForecolor = System.Drawing.Color.White;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.btnReport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReport.IconPadding = 8;
            this.btnReport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReport.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnReport.IdleBorderRadius = 1;
            this.btnReport.IdleBorderThickness = 0;
            this.btnReport.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnReport.IdleIconLeftImage = global::StaffManagment.Properties.Resources.report;
            this.btnReport.IdleIconRightImage = null;
            this.btnReport.Location = new System.Drawing.Point(0, 382);
            this.btnReport.Name = "btnReport";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties2.IconLeftImage = global::StaffManagment.Properties.Resources.report;
            stateProperties2.IconRightImage = null;
            this.btnReport.onHoverState = stateProperties2;
            this.btnReport.Size = new System.Drawing.Size(250, 43);
            this.btnReport.TabIndex = 1;
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.Transparent;
            this.btnIncome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncome.BackgroundImage")));
            this.btnIncome.ButtonText = "INCOME";
            this.btnIncome.ButtonTextMarginLeft = 0;
            this.btnIncome.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnIncome.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnIncome.DisabledForecolor = System.Drawing.Color.White;
            this.btnIncome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.btnIncome.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnIncome.IconPadding = 9;
            this.btnIncome.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnIncome.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnIncome.IdleBorderRadius = 1;
            this.btnIncome.IdleBorderThickness = 0;
            this.btnIncome.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnIncome.IdleIconLeftImage = global::StaffManagment.Properties.Resources.income;
            this.btnIncome.IdleIconRightImage = null;
            this.btnIncome.Location = new System.Drawing.Point(0, 333);
            this.btnIncome.Name = "btnIncome";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties3.IconLeftImage = global::StaffManagment.Properties.Resources.income;
            stateProperties3.IconRightImage = null;
            this.btnIncome.onHoverState = stateProperties3;
            this.btnIncome.Size = new System.Drawing.Size(250, 43);
            this.btnIncome.TabIndex = 1;
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnPayroll
            // 
            this.btnPayroll.BackColor = System.Drawing.Color.Transparent;
            this.btnPayroll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayroll.BackgroundImage")));
            this.btnPayroll.ButtonText = "PAYROLL";
            this.btnPayroll.ButtonTextMarginLeft = 0;
            this.btnPayroll.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnPayroll.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnPayroll.DisabledForecolor = System.Drawing.Color.White;
            this.btnPayroll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.btnPayroll.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPayroll.IconPadding = 9;
            this.btnPayroll.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPayroll.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnPayroll.IdleBorderRadius = 1;
            this.btnPayroll.IdleBorderThickness = 0;
            this.btnPayroll.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnPayroll.IdleIconLeftImage = global::StaffManagment.Properties.Resources.payroll;
            this.btnPayroll.IdleIconRightImage = null;
            this.btnPayroll.Location = new System.Drawing.Point(0, 283);
            this.btnPayroll.Name = "btnPayroll";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties4.IconLeftImage = global::StaffManagment.Properties.Resources.payroll;
            stateProperties4.IconRightImage = null;
            this.btnPayroll.onHoverState = stateProperties4;
            this.btnPayroll.Size = new System.Drawing.Size(250, 43);
            this.btnPayroll.TabIndex = 1;
            this.btnPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayroll.Click += new System.EventHandler(this.btnPayroll_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackColor = System.Drawing.Color.Transparent;
            this.btnExpenses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExpenses.BackgroundImage")));
            this.btnExpenses.ButtonText = "EXPENSES";
            this.btnExpenses.ButtonTextMarginLeft = 0;
            this.btnExpenses.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExpenses.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnExpenses.DisabledForecolor = System.Drawing.Color.White;
            this.btnExpenses.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.btnExpenses.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExpenses.IconPadding = 9;
            this.btnExpenses.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExpenses.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnExpenses.IdleBorderRadius = 1;
            this.btnExpenses.IdleBorderThickness = 0;
            this.btnExpenses.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnExpenses.IdleIconLeftImage = global::StaffManagment.Properties.Resources.expenses;
            this.btnExpenses.IdleIconRightImage = null;
            this.btnExpenses.Location = new System.Drawing.Point(0, 234);
            this.btnExpenses.Name = "btnExpenses";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties5.BorderRadius = 1;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties5.IconLeftImage = global::StaffManagment.Properties.Resources.expenses;
            stateProperties5.IconRightImage = null;
            this.btnExpenses.onHoverState = stateProperties5;
            this.btnExpenses.Size = new System.Drawing.Size(250, 43);
            this.btnExpenses.TabIndex = 1;
            this.btnExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMainMenu.BackgroundImage")));
            this.btnMainMenu.ButtonText = "HOME";
            this.btnMainMenu.ButtonTextMarginLeft = 0;
            this.btnMainMenu.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnMainMenu.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnMainMenu.DisabledForecolor = System.Drawing.Color.White;
            this.btnMainMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(156)))), ((int)(((byte)(173)))));
            this.btnMainMenu.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMainMenu.IconPadding = 9;
            this.btnMainMenu.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMainMenu.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnMainMenu.IdleBorderRadius = 1;
            this.btnMainMenu.IdleBorderThickness = 0;
            this.btnMainMenu.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.btnMainMenu.IdleIconLeftImage = global::StaffManagment.Properties.Resources.home;
            this.btnMainMenu.IdleIconRightImage = null;
            this.btnMainMenu.Location = new System.Drawing.Point(1, 185);
            this.btnMainMenu.Name = "btnMainMenu";
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties6.BorderRadius = 1;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            stateProperties6.IconLeftImage = global::StaffManagment.Properties.Resources.home;
            stateProperties6.IconRightImage = null;
            this.btnMainMenu.onHoverState = stateProperties6;
            this.btnMainMenu.Size = new System.Drawing.Size(250, 43);
            this.btnMainMenu.TabIndex = 1;
            this.btnMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // PaymentHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnNormalize);
            this.Controls.Add(this.paymentMainPanel);
            this.Controls.Add(this.paymentSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PaymentHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PaymentHomePage_Load);
            this.paymentSidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel paymentSidePanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMainMenu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton6;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnIncome;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPayroll;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExpenses;
        private Bunifu.Framework.UI.BunifuGradientPanel paymentMainPanel;
        private Bunifu.UI.WinForms.BunifuImageButton btnNormalize;
        private Bunifu.UI.WinForms.BunifuImageButton btnMinimize;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuDragControl DragControlMainPanel;
        private Bunifu.Framework.UI.BunifuDragControl DragControlSidePanel;
        private Bunifu.Framework.UI.BunifuElipse ElipseMainPanel;
        private Bunifu.Framework.UI.BunifuElipse ElipseSidePanel;
    }
}

