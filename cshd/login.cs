using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace cshd
{
    public partial class login : Form
    {
        

        public login()
        {

            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Form1.logState = true;
            this.Hide();
            this.Close();
            login secondForm = new login();
            secondForm.Show();

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            gunaTextBox1.Text = "";
            gunaTextBox2.Text = "";
        }
        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            string usernameCor = gunaTextBox1.Text;
            string passwordCor = gunaTextBox2.Text;

            if (Form1.username == usernameCor && Form1.password == passwordCor) {
                
                this.Hide();

                Form1 secondForm = new Form1();
                secondForm.Show();


            }
        }

       

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
                    }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
