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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
            gunaPictureBox5.ImageLocation = Form1.imagePath;
            label5.Text = Form1.username;
            int pocetRec = 0;
            for (int i = 0; i < (Form1.myvotes).Length; i++) {
                if (Form1.myvotes[i] > -1) {
                    pocetRec += 1;
                }
            }
            
            gunaLabel9.Text = pocetRec.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel12_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
