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
    public partial class Frm_MyClac : Form
    {
        public Frm_MyClac()
        {
            InitializeComponent();
        }
        int Answer;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum1.Text))
            {
                MessageBox.Show("請輸入數值");
                txtNum1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtNum2.Text))
            {
                MessageBox.Show("請輸入數值");
                txtNum2.Focus();
                return;
            }
            else
            {
                Answer = int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text);
                txtAnswer.Text = Answer.ToString();            
            }
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum1.Text))
            {
                MessageBox.Show("請輸入數值");
                txtNum1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtNum2.Text))
            {
                MessageBox.Show("請輸入數值");
                txtNum2.Focus();
                return;
            }
            else
            {
                Answer = int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text);
                txtAnswer.Text = Answer.ToString();
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum1.Text))
            {
                MessageBox.Show("請輸入數值");
                txtNum1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtNum2.Text))
            {
                MessageBox.Show("請輸入數值");
                txtNum2.Focus();
                return;
            }
            else
            {
                Answer = int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text);
                txtAnswer.Text = Answer.ToString();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum1.Text))
            {
                MessageBox.Show("請輸入數值");
                txtNum1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtNum2.Text))
            {
                MessageBox.Show("請輸入數值");
                txtNum2.Focus();
                return;
            }
            else
            {
                Answer = int.Parse(txtNum1.Text) / int.Parse(txtNum2.Text);
                txtAnswer.Text = Answer.ToString("0.0000");
            }
        }
    }
}
