using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GsharpHomework
{
    public partial class Frm_JuniorPainter : Form
    {
        public Frm_JuniorPainter()
        {
            InitializeComponent();
        }


        int x, y;
        Bitmap bbb;

        private void Frm_JuniorPainter_Load(object sender, EventArgs e)
        {
            label1.Text = 1.ToString();
            bbb = new Bitmap(10000, 10000);
            pictureBox1.Image = bbb;
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.BackColor = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Graphics ss = Graphics.FromImage(bbb);
                Pen p = new Pen(colorDialog1.Color,int.Parse(trackBar1.Value.ToString()));
                ss.DrawLine(p, x, y, e.X, e.Y);
                pictureBox1.Image = bbb;
                x = e.X;
                y = e.Y;

            }
        }
    }
}
