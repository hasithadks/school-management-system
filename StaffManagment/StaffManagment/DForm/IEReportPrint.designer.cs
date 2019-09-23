namespace SchoolManagementSystem
{
    partial class IEReportPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IEReportPrint));
            this.IncomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IncomeData = new SchoolManagementSystem.IncomeData();
            this.ExpensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReportClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnReportMinimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnNormalize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IncomeBindingSource
            // 
            this.IncomeBindingSource.DataMember = "Income";
            this.IncomeBindingSource.DataSource = this.IncomeData;
            // 
            // IncomeData
            // 
            this.IncomeData.DataSetName = "IncomeData";
            this.IncomeData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReportClose
            // 
            this.btnReportClose.ActiveImage = null;
            this.btnReportClose.AllowAnimations = true;
            this.btnReportClose.AllowZooming = true;
            this.btnReportClose.BackColor = System.Drawing.Color.Transparent;
            this.btnReportClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnReportClose.ErrorImage")));
            this.btnReportClose.FadeWhenInactive = false;
            this.btnReportClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnReportClose.Image = global::StaffManagment.Properties.Resources.closebtn;
            this.btnReportClose.ImageActive = null;
            this.btnReportClose.ImageLocation = null;
            this.btnReportClose.ImageMargin = 10;
            this.btnReportClose.ImageSize = new System.Drawing.Size(28, 25);
            this.btnReportClose.ImageZoomSize = new System.Drawing.Size(38, 35);
            this.btnReportClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnReportClose.InitialImage")));
            this.btnReportClose.Location = new System.Drawing.Point(1073, -1);
            this.btnReportClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportClose.Name = "btnReportClose";
            this.btnReportClose.Rotation = 0;
            this.btnReportClose.ShowActiveImage = true;
            this.btnReportClose.ShowCursorChanges = true;
            this.btnReportClose.ShowImageBorders = true;
            this.btnReportClose.ShowSizeMarkers = true;
            this.btnReportClose.Size = new System.Drawing.Size(38, 35);
            this.btnReportClose.TabIndex = 3;
            this.btnReportClose.ToolTipText = "";
            this.btnReportClose.WaitOnLoad = false;
            this.btnReportClose.Zoom = 10;
            this.btnReportClose.ZoomSpeed = 10;
            this.btnReportClose.Click += new System.EventHandler(this.btnReportClose_Click);
            // 
            // btnReportMinimize
            // 
            this.btnReportMinimize.ActiveImage = null;
            this.btnReportMinimize.AllowAnimations = true;
            this.btnReportMinimize.AllowZooming = true;
            this.btnReportMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnReportMinimize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnReportMinimize.ErrorImage")));
            this.btnReportMinimize.FadeWhenInactive = false;
            this.btnReportMinimize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnReportMinimize.Image = global::StaffManagment.Properties.Resources.minibtn;
            this.btnReportMinimize.ImageActive = null;
            this.btnReportMinimize.ImageLocation = null;
            this.btnReportMinimize.ImageMargin = 10;
            this.btnReportMinimize.ImageSize = new System.Drawing.Size(28, 25);
            this.btnReportMinimize.ImageZoomSize = new System.Drawing.Size(38, 35);
            this.btnReportMinimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnReportMinimize.InitialImage")));
            this.btnReportMinimize.Location = new System.Drawing.Point(1000, -1);
            this.btnReportMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportMinimize.Name = "btnReportMinimize";
            this.btnReportMinimize.Rotation = 0;
            this.btnReportMinimize.ShowActiveImage = true;
            this.btnReportMinimize.ShowCursorChanges = true;
            this.btnReportMinimize.ShowImageBorders = true;
            this.btnReportMinimize.ShowSizeMarkers = true;
            this.btnReportMinimize.Size = new System.Drawing.Size(38, 35);
            this.btnReportMinimize.TabIndex = 4;
            this.btnReportMinimize.ToolTipText = "";
            this.btnReportMinimize.WaitOnLoad = false;
            this.btnReportMinimize.Zoom = 10;
            this.btnReportMinimize.ZoomSpeed = 10;
            this.btnReportMinimize.Click += new System.EventHandler(this.btnReportMinimize_Click);
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
            this.btnNormalize.Location = new System.Drawing.Point(1036, -1);
            this.btnNormalize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StaffManagment.IncomeExpensesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, 41);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1115, 728);
            this.reportViewer1.TabIndex = 6;
            // 
            // IEReportPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 718);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnReportClose);
            this.Controls.Add(this.btnReportMinimize);
            this.Controls.Add(this.btnNormalize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IEReportPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IEReportPrint";
            this.Load += new System.EventHandler(this.IEReportPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IncomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton btnReportClose;
        private Bunifu.UI.WinForms.BunifuImageButton btnReportMinimize;
        private Bunifu.UI.WinForms.BunifuImageButton btnNormalize;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IncomeBindingSource;
        private IncomeData IncomeData;
        private System.Windows.Forms.BindingSource ExpensesBindingSource;
       
    }
}