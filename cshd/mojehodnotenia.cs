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
    public partial class mojehodnotenia : Form
    {
        public mojehodnotenia()
        {

            InitializeComponent();
            if (Form1.myvotes[0] > -1)
            {
                gunaLabel2.Text = Form1.myvotes[0] + "/10";
            }
            else {
                gunaLabel2.Text = "";

            }

            if (Form1.myvotes[1] > -1)
            {
                gunaLabel3.Text = Form1.myvotes[1] + "/10";
            }
            else
            {
                gunaLabel3.Text = "";

            }

            if (Form1.myvotes[2] > -1)
            {
                gunaLabel5.Text = Form1.myvotes[2] + "/10";
            }
            else
            {
                gunaLabel5.Text = "";

            }

            if (Form1.myvotes[3] > -1)
            {
                gunaLabel7.Text = Form1.myvotes[3] + "/10";
            }
            else
            {
                gunaLabel7.Text = "";

            }

            if (Form1.myvotes[4] > -1)
            {
                gunaLabel9.Text = Form1.myvotes[4] + "/10";
            }
            else
            {
                gunaLabel9.Text = "";

            }

            if (Form1.myvotes[5] > -1)
            {
                gunaLabel11.Text = Form1.myvotes[5] + "/10";
            }
            else
            {
                gunaLabel11.Text = "";

            }

            if (Form1.myvotes[6] > -1)
            {
                gunaLabel13.Text = Form1.myvotes[6] + "/10";
            }
            else
            {
                gunaLabel13.Text = "";

            }
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
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Form1.numberAlb = 0;
            gunaPanel1.BackColor = Color.Silver;
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Form1.numberAlb = 1;
            gunaPanel2.BackColor = Color.Silver;
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            Form1.numberAlb = 2;
            gunaPanel3.BackColor = Color.Silver;
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
    }
}
