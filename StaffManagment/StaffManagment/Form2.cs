using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagment
{
    public partial class Form2 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DAVE\DAVE;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand cmd;


        public Form2()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonminimizesd_Click(object sender, EventArgs e)
        {
            
        }

        private void snic_Click(object sender, EventArgs e)
        {

        }

        private void generate_ID_Click(object sender, EventArgs e)
        {
           




        }

        private void Form2_Load(object sender, EventArgs e)
        {
            nameLable.Text = StaffManagment.setfname + " " +StaffManagment.setlname;
            nicLable.Text = StaffManagment.setnic;

            Byte[] img = StaffManagment.image;
            MemoryStream ms = new MemoryStream(img);
            photoTxt.Image = Image.FromStream(ms);


            DateTime date = DateTime.Now;
            dateLabel.Text = date.ToShortDateString();

            String barcode = StaffManagment.setnic;

            Bitmap bitmap = new Bitmap(barcode.Length * 18, 62);

            using(Graphics graphics = Graphics.FromImage(bitmap)) { 

                Font ofont = new System.Drawing.Font("IDAutomationHC39M", 12);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                graphics.DrawString(barcode, ofont, black, point);

            }
            using (MemoryStream ms2 = new MemoryStream())
            {
                bitmap.Save(ms2, ImageFormat.Png);
                barcodeImg.Image = bitmap;
                barcodeImg.Height = bitmap.Height;
                barcodeImg.Width = bitmap.Width;

            }



        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void nameLable_Click(object sender, EventArgs e)
        {

        }
    }
}
