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
    public partial class Frm_ScreenSaver : Form
    {

        public Frm_ScreenSaver()
        {
            InitializeComponent();
        }
        int X = 1, Y = 1;
        int MouseX = Control.MousePosition.X, MouseY = Control.MousePosition.Y;

        private void Frm_ScreenSaver_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Frm_ScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }
        private void Frm_ScreenSaver_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureBox1.Location.X + pictureBox1.Width > ClientSize.Width) X = 0 - X;
            if (pictureBox1.Location.X < 0) X = 0 - X;

            if (pictureBox1.Location.Y + pictureBox1.Height > ClientSize.Height) Y = 0 - Y;
            if (pictureBox1.Location.Y < 0) Y = 0 - Y;

            pictureBox1.Location = new Point(pictureBox1.Location.X + X, pictureBox1.Location.Y + Y);
            int MouseXX = Control.MousePosition.X;
            int MouseYY = Control.MousePosition.Y;
            if (MouseX != MouseXX || MouseY != MouseYY)
            {
                this.Close();
            }

        }


    }
}
