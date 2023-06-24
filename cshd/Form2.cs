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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            gunaPictureBox2.ImageLocation = Form1.images[Form1.numberAlb];
            gunaLabel4.Text = "Album, o ktorom budem hovoriť, je jedinečný a nezabudnuteľný\n.Je to umelecké dielo, ktoré prináša hudobné zážitky\n a emócie, ktoré sa dotknú hlboko v srdci.\n Tento album sa vyznačuje vynikajúcimi textami, ktoré\n sa líšia od bežného komerčného popu.Hudba na albume je vynikajúca,\n s bohatou paletou zvukov a šikovne nalinkovanými melódiami.\nInštrumentácia je majstrovsky ovládaná a každý nástroj prispieva\n k vytvoreniu nezabudnuteľnej atmosféry. Album sa venuje rôznym témam,\n od lásky až po životné skúsenosti a existenciálne otázky.";
            gunaLabel2.Text = Form1.albums[Form1.numberAlb];
            gunaLabel3.Text = Form1.author[Form1.numberAlb];
            gunaLabel1.Text = Math.Round(((Form1.ratingspol[Form1.numberAlb]) / (Form1.votes[Form1.numberAlb]) * 10)) + "%";

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (Form1.myvotes[Form1.numberAlb] < 0)
            {
                Form1.votes[Form1.numberAlb] += 1;
                Form1.ratingspol[Form1.numberAlb] += 10;
                Form1.myvotes[Form1.numberAlb] = 10;

            }
            else
            {
                Form1.ratingspol[Form1.numberAlb] = Form1.ratingspol[Form1.numberAlb] - Form1.myvotes[Form1.numberAlb];
                Form1.ratingspol[Form1.numberAlb] += 10;
                Form1.myvotes[Form1.numberAlb] = 10;

            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (Form1.myvotes[Form1.numberAlb] < 0)
            {
                Form1.votes[Form1.numberAlb] += 1;
                Form1.ratingspol[Form1.numberAlb] += 9;
                Form1.myvotes[Form1.numberAlb] = 9;

            }
            else
            {
                Form1.ratingspol[Form1.numberAlb] = Form1.ratingspol[Form1.numberAlb] - Form1.myvotes[Form1.numberAlb];
                Form1.ratingspol[Form1.numberAlb] += 9;
                Form1.myvotes[Form1.numberAlb] = 9;

            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (Form1.myvotes[Form1.numberAlb] < 0)
            {
                Form1.votes[Form1.numberAlb] += 1;
                Form1.ratingspol[Form1.numberAlb] += 8;
                Form1.myvotes[Form1.numberAlb] = 8;

            }
            else
            {
                Form1.ratingspol[Form1.numberAlb] = Form1.ratingspol[Form1.numberAlb] - Form1.myvotes[Form1.numberAlb];
                Form1.ratingspol[Form1.numberAlb] += 8;
                Form1.myvotes[Form1.numberAlb] = 8;

            }
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            if (Form1.myvotes[Form1.numberAlb] < 0)
            {
                Form1.votes[Form1.numberAlb] += 1;
                Form1.ratingspol[Form1.numberAlb] += 7;
                Form1.myvotes[Form1.numberAlb] = 7;

            }
            else
            {
                Form1.ratingspol[Form1.numberAlb] = Form1.ratingspol[Form1.numberAlb] - Form1.myvotes[Form1.numberAlb];
                Form1.ratingspol[Form1.numberAlb] += 7;
                Form1.myvotes[Form1.numberAlb] = 7;

            }
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            if (Form1.myvotes[Form1.numberAlb] < 0)
            {
                Form1.votes[Form1.numberAlb] += 1;
                Form1.ratingspol[Form1.numberAlb] += 6;
                Form1.myvotes[Form1.numberAlb] = 6;

            }
            else
            {
                Form1.ratingspol[Form1.numberAlb] = Form1.ratingspol[Form1.numberAlb] - Form1.myvotes[Form1.numberAlb];
                Form1.ratingspol[Form1.numberAlb] += 6;
                Form1.myvotes[Form1.numberAlb] = 6;

            }
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            if (Form1.myvotes[Form1.numberAlb] < 0)
            {
                Form1.votes[Form1.numberAlb] += 1;
                Form1.ratingspol[Form1.numberAlb] += 5;
                Form1.myvotes[Form1.numberAlb] = 5;

            }
            else
            {
                Form1.ratingspol[Form1.numberAlb] = Form1.ratingspol[Form1.numberAlb] - Form1.myvotes[Form1.numberAlb];
                Form1.ratingspol[Form1.numberAlb] += 5;
                Form1.myvotes[Form1.numberAlb] = 5;

            }
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            if (Form1.myvotes[Form1.numberAlb] < 0)
            {
                Form1.votes[Form1.numberAlb] += 1;
                Form1.ratingspol[Form1.numberAlb] += 4;
                Form1.myvotes[Form1.numberAlb] = 4;

            }
            else
            {
                Form1.ratingspol[Form1.numberAlb] = Form1.ratingspol[Form1.numberAlb] - Form1.myvotes[Form1.numberAlb];
                Form1.ratingspol[Form1.numberAlb] += 4;
                Form1.myvotes[Form1.numberAlb] = 4;

            }
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            if (Form1.myvotes[Form1.numberAlb] < 0)
            {
                Form1.votes[Form1.numberAlb] += 1;
                Form1.ratingspol[Form1.numberAlb] += 3;
                Form1.myvotes[Form1.numberAlb] = 3;

            }
            else
            {
                Form1.ratingspol[Form1.numberAlb] = Form1.ratingspol[Form1.numberAlb] - Form1.myvotes[Form1.numberAlb];
                Form1.ratingspol[Form1.numberAlb] += 3;
                Form1.myvotes[Form1.numberAlb] = 3;

            }
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            if (Form1.myvotes[Form1.numberAlb] < 0)
            {
                Form1.votes[Form1.numberAlb] += 1;
                Form1.ratingspol[Form1.numberAlb] += 2;
                Form1.myvotes[Form1.numberAlb] = 2;

            }
            else
            {
                Form1.ratingspol[Form1.numberAlb] = Form1.ratingspol[Form1.numberAlb] - Form1.myvotes[Form1.numberAlb];
                Form1.ratingspol[Form1.numberAlb] += 2;
                Form1.myvotes[Form1.numberAlb] = 2;

            }
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            if (Form1.myvotes[Form1.numberAlb] < 0)
            {
                Form1.votes[Form1.numberAlb] += 1;
                Form1.ratingspol[Form1.numberAlb] += 1;
                Form1.myvotes[Form1.numberAlb] = 1;

            }
            else
            {
                Form1.ratingspol[Form1.numberAlb] = Form1.ratingspol[Form1.numberAlb] - Form1.myvotes[Form1.numberAlb];
                Form1.ratingspol[Form1.numberAlb] += 1;
                Form1.myvotes[Form1.numberAlb] = 1;

            }
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            if (Form1.myvotes[Form1.numberAlb] < 0)
            {
                Form1.votes[Form1.numberAlb] += 1;
                Form1.ratingspol[Form1.numberAlb] += 0;
                Form1.myvotes[Form1.numberAlb] = 0;

            }
            else {
                Form1.ratingspol[Form1.numberAlb] = Form1.ratingspol[Form1.numberAlb] - Form1.myvotes[Form1.numberAlb];
                Form1.ratingspol[Form1.numberAlb] += 0;
                Form1.myvotes[Form1.numberAlb] = 0;

            }
        }
    }
}
