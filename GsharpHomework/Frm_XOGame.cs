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
    public partial class Frm_XOGame : Form
    {
        public Frm_XOGame()
        {
            InitializeComponent();

        }

        bool X = true;
        string win = "";
        int sum = 0;

        public void Rule() 
        {
            if (btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "" ||
                btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "" ||
                btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "" ||
                btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "" ||
                btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "" ||
                btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "" ||
                btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "" ||
                btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "" )
            { MessageBox.Show(win + "  手獲勝", "完局", MessageBoxButtons.OK); RestStar(); }
             else if(sum == 9){ MessageBox.Show("平手!按下確定重新開始","完局",MessageBoxButtons.OK); RestStar(); }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (X)
            {
                btn.Text = "X"; btn.Enabled = false;
                X = !X;
                win = "X";
                sum++;
            }
            else
            {
                btn.Text = "O"; btn.Enabled = false;
                X = !X;
                win = "O";
                sum++;
            }
            Rule();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            RestStar();
        }

        public void RestStar()
        {
            btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
            sum = 0;
            X = true;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_XOGame_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.R) { RestStar(); }
            if ( e.KeyCode == Keys.Escape) { this.Close(); }
        }
    }
}
