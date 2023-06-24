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
    public partial class profile : Form
    {

        public profile()
        {
            InitializeComponent();
            gunaLabel1.Text = Form1.username;
            gunaPictureBox1.ImageLocation = Form1.imagePath;
            
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void profile_Load(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string newName = gunaTextBox1.Text;
            Form1.username = newName;

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            string newName = gunaTextBox2.Text;
            Form1.password = newName;
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Close();
            login secondForm = new login();
            secondForm.Show();

        }

        private void gunaLabel4_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Form1.imagePath = openFileDialog.FileName;

                    gunaPictureBox1.ImageLocation = Form1.imagePath;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Nastala chyba pri vztvarani", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
