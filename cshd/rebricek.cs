using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cshd
{
    public partial class rebricek : Form
    {

        public rebricek()
        {
            InitializeComponent();
            gunaPictureBox1.ImageLocation = Form1.images[0];
            gunaPictureBox2.ImageLocation = Form1.images[1];
            gunaPictureBox3.ImageLocation = Form1.images[2];
            gunaPictureBox4.ImageLocation = Form1.images[3];
            gunaPictureBox5.ImageLocation = Form1.images[4];
            gunaPictureBox6.ImageLocation = Form1.images[5];
            gunaPictureBox7.ImageLocation = Form1.images[6];

            label1.Text = Form1.albums[0];
            label2.Text = Form1.albums[1];
            label3.Text = Form1.albums[2];
            label4.Text = Form1.albums[3];
            label5.Text = Form1.albums[4];
            label6.Text = Form1.albums[5];
            label7.Text = Form1.albums[6];

            gunaLabel1.Text = Form1.author[0];
            gunaLabel4.Text = Form1.author[1];
            gunaLabel6.Text = Form1.author[2];
            gunaLabel8.Text = Form1.author[3];
            gunaLabel10.Text = Form1.author[4];
            gunaLabel12.Text = Form1.author[5];
            gunaLabel14.Text = Form1.author[6];

            gunaLabel2.Text = Math.Round(((Form1.ratingspol[0]) / (Form1.votes[0]) * 10))+"%";
            gunaLabel3.Text = Math.Round(((Form1.ratingspol[1]) / (Form1.votes[1]) * 10)) + "%";
            gunaLabel5.Text = Math.Round(((Form1.ratingspol[2]) / (Form1.votes[2]) * 10)) + "%";
            gunaLabel7.Text = Math.Round(((Form1.ratingspol[3]) / (Form1.votes[3]) * 10)) + "%";
            gunaLabel9.Text = Math.Round(((Form1.ratingspol[4]) / (Form1.votes[4]) * 10)) + "%";
            gunaLabel11.Text = Math.Round(((Form1.ratingspol[5]) / (Form1.votes[5]) * 10)) + "%";
            gunaLabel13.Text = Math.Round(((Form1.ratingspol[6]) / (Form1.votes[6]) * 10)) + "%";








        }
        public void loadform(object Form)
        {
            if (this.flowLayoutPanel1.Controls.Count > 0)
                this.flowLayoutPanel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.flowLayoutPanel1.Controls.Add(f);
            this.flowLayoutPanel1.Tag = f;
            
            f.Show();

        }
        private void gunaVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void rebricek_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void populateItems() {
            UserControl1[] listItems = new UserControl1[20];
            for (int i = 0; i < listItems.Length; i++) {
                //listItems[i] = new UserControl1();
                if (flowLayoutPanel1.Controls.Count > 0) {
                flowLayoutPanel1.Controls.Clear();

                }
            flowLayoutPanel1.Controls.Add(listItems[i]);
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl15_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Form1.numberAlb = 1;
            gunaPanel2.BackColor = Color.Silver;

        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Form1.numberAlb = 0;
            gunaPanel1.BackColor = Color.Silver;




        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            Form1.numberAlb = 2;
            gunaPanel3.BackColor = Color.Silver;


        }

        private void gunaLabel14_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel10_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel12_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            Form1.numberAlb = 3;
            gunaPanel4.BackColor = Color.Silver;


        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            Form1.numberAlb = 4;
            gunaPanel5.BackColor = Color.Silver;


        }

        private void gunaPictureBox6_Click(object sender, EventArgs e)
        {
            Form1.numberAlb = 5;
            gunaPanel6.BackColor = Color.Silver;


        }

        private void gunaPictureBox7_Click(object sender, EventArgs e)
        {
            Form1.numberAlb = 6;
            gunaPanel7.BackColor = Color.Silver;



        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel11_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel13_Click(object sender, EventArgs e)
        {

        }
    }
}
