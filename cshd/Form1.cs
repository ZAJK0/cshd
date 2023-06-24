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


    public partial class Form1 : Form
    {
        public static int numberAlb = 0;

        public static bool logState = false;
        public static string username = "wasd";
        public static string password = "wasd";
        public static string imagePath = "../../img/obluda.jpg";
        public static string[] images = { "../../img/trapstory.jpg",
        "../../img/mbdtf.jpg",
        "../../img/tpab.png",
        "../../img/darksideofmoon.png",
        "../../img/latereg.jpg",
        "../../img/36chambers.jpg",
        "../../img/21_Savage_Metro_Boomin_Savage_Mode_2.jpg"};
    
        public static string[] albums = {"TRAP STORY","MBDTF","To Pimp a Buterfly","The Dark Side Of The Moon","Late Registration","36Chambers","Savage Mode II" };
        public static string[] author = { "Gucci Mane", "Kanye West", "Kendrick Lamar", "Pink Floyd", "Kanye West", "Wu Tang Clan", "21Savage & Metro Boomin" };
        public static double[] ratingspol = { 130, 90, 62, 51, 93, 25, 207 };
        public static double[] votes = { 10, 9, 7, 7, 14, 5, 40 };
        public static int[] myvotes = {-1 , -1, -1, -1, -1, -1, -1 };




        public Form1()
        {
            InitializeComponent();
            gunaPictureBox3.ImageLocation = imagePath;
            loadform(new profile());
        }

        





        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            loadform(new Form2());
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            loadform(new rebricek());
        }

        private void gunaGradientButton1_Click_1(object sender, EventArgs e)
        {
            loadform(new mojehodnotenia());
        }

        private void gunaLineTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < (Form1.albums).Length;i++)
            {
                if (gunaLineTextBox1.Text == Form1.albums[i]) {
                    Form1.numberAlb = i;
                    loadform(new Form2());
                    break;
                }
                if (i == 6) {
                    loadform(new lutujeme());
                }
            }
            
        }

        private void gunaTextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            loadform(new profile());

        }

       

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton11_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton14_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton13_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton12_Click(object sender, EventArgs e)
        {
                    }

        private void gunaGradientButton15_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton10_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton9_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton8_Click(object sender, EventArgs e)
        {
                    }

        private void gunaGradientButton7_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton17_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton9_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton6_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton15_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton10_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton11_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton12_Enter(object sender, EventArgs e)
        {

        }
        private void gunaButton12_Leave(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            loadform(new profile());

            gunaPictureBox3.ImageLocation = imagePath;

        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            loadform(new profile());
            gunaPictureBox3.ImageLocation = imagePath;
            InitializeComponent();



        }

        private void gunaButton2_Click_2(object sender, EventArgs e)
        {
            this.Close();
            login secondForm = new login();
            secondForm.Show();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            loadform(new users());
        }
    }
}
