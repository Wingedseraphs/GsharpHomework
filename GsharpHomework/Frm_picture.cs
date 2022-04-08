using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GsharpHomework
{
    public partial class Frm_picture : Form
    {
        public Frm_picture()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_Show Pic = new Frm_Show();
            Pic.PIC1.Image = new Bitmap(@".\picture\whiami.gif");
            Pic.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_Show Pic = new Frm_Show();
            Pic.PIC1.Image = new Bitmap(@".\picture\005Iu2BQly1gbr8ubn28kj30yi22okhn.jpg");
            Pic.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Frm_Show Pic = new Frm_Show();
            Pic.PIC1.Image = new Bitmap(@".\picture\2880.jpg_wh1200.jpg");
            Pic.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Frm_Show Pic = new Frm_Show();
            Pic.PIC1.Image = new Bitmap(@".\picture\Beer.1.jpg");
            Pic.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Frm_Show Pic = new Frm_Show();
            Pic.PIC1.Image = new Bitmap(@".\picture\teahub.io-lok-wallpaper-3114284.jpg");
            Pic.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Frm_Show Pic = new Frm_Show();
            Pic.PIC1.Image = new Bitmap(@".\picture\Tequila.1.jpg");
            Pic.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Frm_Show Pic = new Frm_Show();
            Pic.PIC1.Image = new Bitmap(@".\picture\Wine.jpg");
            Pic.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Frm_Show Pic = new Frm_Show();
            Pic.PIC1.Image = new Bitmap(@".\picture\CAT.jpg");
            Pic.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Frm_Show Pic = new Frm_Show();
            Pic.PIC1.Image = new Bitmap(@".\picture\girl.jpg");
            Pic.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Frm_Show Pic = new Frm_Show();
            Pic.PIC1.Image = new Bitmap(@".\picture\landscape.jpg");
            Pic.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Frm_Show Pic = new Frm_Show();
            Pic.PIC1.Image = new Bitmap(@".\picture\landscape1.jpg");
            Pic.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Frm_Show Pic = new Frm_Show();
            Pic.PIC1.Image = new Bitmap(@".\picture\landscape2.jpg");
            Pic.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Frm_Show Pic = new Frm_Show();
            Pic.PIC1.Image = new Bitmap(@".\picture\landscape3.jpg");
            Pic.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Frm_Show Pic = new Frm_Show();
            Pic.PIC1.Image = new Bitmap(@".\picture\hope.jpg");
            Pic.Show();
        }
    }
}
