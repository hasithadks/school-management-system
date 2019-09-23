namespace SchoolManagementSystem
{
    partial class loding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loding));
            this.lodingSline = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.LodingTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lodingSline
            // 
            this.lodingSline.BackColor = System.Drawing.Color.White;
            this.lodingSline.Location = new System.Drawing.Point(219, 1);
            this.lodingSline.Name = "lodingSline";
            this.lodingSline.Size = new System.Drawing.Size(84, 8);
            this.lodingSline.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lodingSline);
            this.panel1.Location = new System.Drawing.Point(529, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 10);
            this.panel1.TabIndex = 1;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.CursorType = null;
            this.bunifuLabel8.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.bunifuLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel8.Location = new System.Drawing.Point(508, 377);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(346, 32);
            this.bunifuLabel8.TabIndex = 15;
            this.bunifuLabel8.Text = "School Management System";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // LodingTimer
            // 
            this.LodingTimer.Interval = 15;
            this.LodingTimer.Tick += new System.EventHandler(this.LodingTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StaffManagment.Properties.Resources.logo11;
            this.pictureBox1.Location = new System.Drawing.Point(589, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // loding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.bunifuLabel8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loding";
            this.Load += new System.EventHandler(this.loding_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel lodingSline;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private System.Windows.Forms.Timer LodingTimer;
    }
}