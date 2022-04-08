using Microsoft.VisualBasic;
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
    public partial class Frm_Guess : Form
    {
        public Frm_Guess()
        {
            InitializeComponent();
            start();
        }

        Random Answer = new Random();
        string Ans = "";
        int sum = 0;
        int Min = 1;
        int Max = 100;
        bool a = true;

        public void start()
        {
            sum = Answer.Next(1, 100);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            sum = Answer.Next(1, 100);
            while (a)
            {
                Ans = Interaction.InputBox("Please Input a Number", "Guess");
                if (Ans == "")
                {
                    Min = 1;
                    Max = 100;
                    break;
                }
                int UseAns = int.Parse(Ans);
                if (UseAns >= Min)
                {
                    if (UseAns < sum)
                    {
                        Min = UseAns;
                        label1.Text = "Too  Smail!!!! \n" + "Between " + Min + " and  " + Max;
                    }
                }
                else
                {
                    MessageBox.Show($"請輸入{Min}~{Max}之間的數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (UseAns <= Max)
                {
                    if (UseAns > sum)
                    {
                        Max = UseAns;
                        label1.Text = "Too  Large!!!! \n" + "Between " + Min + " and  " + Max;
                    }
                }
                else
                {
                    MessageBox.Show($"請輸入{Min}~{Max}之間的數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (UseAns == sum)
                {
                    MessageBox.Show($"Congradulations!!! You got {sum} !!!"); 
                    Min = 1;
                    Max = 100;
                }
            }  
        }
        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer : " + sum.ToString());
        }
    }
}
