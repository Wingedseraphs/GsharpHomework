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
    public partial class Frm_Method : Form
    {
        public Frm_Method()
        {
            InitializeComponent();
        }
        int[] arr077 = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string[] arrString = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };

        private void btnOddevenNumber_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int Number = 0;
            bool s = int.TryParse(textBox1.Text,out Number);
            if (s)
            {
                if (Number % 2 == 0)
                {
                    lblResult.Text = "數入的數" + textBox1.Text + "為  偶數";
                }
                else
                {
                    lblResult.Text = "數入的數" + textBox1.Text + "為  奇數";
                }
            }
            else
            {
                lblResult.Text = "";
                lblResult.Text = "結果";
                MessageBox.Show("請輸入數字格式");
                textBox1.Clear();
                textBox1.Focus();
            }

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int a = 0,j = 0;
            for(int i = 0; i < arr077.Length; i++)
            {
                if (arr077[i] % 2 == 0)
                {
                    a++;
                }
                else
                {
                    j++;
                }
            }
            lblResult.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]\n奇數共 " + j + "\n偶數共 " + a;
        }

        private void btnHighestLowest_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int MaxA = arr077.Max();
            int MaxB = arr077.Min();
            lblResult.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]\n最大值為 " + MaxA + "\n最小值為 " + MaxB;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int a = 100, b = 200;

            lblResult.Text = "換位前n1 = " + a + "," + b + "\n";
            swap<int>(ref a,ref b);
            lblResult.Text += "換位後n1 = " + a + "," + b;
        }
        void swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int Sum = 0;
            for (int i = 0; i < arr077.Length; i++)
            {
                Sum = arr077[i] + Sum;
            }
            lblResult.Text = "int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]" +
                            "\n加總為 :" + Sum.ToString();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int a = arr077.Max();
            lblResult.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]\n最大值為 " + a;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int a = arr077.Min();
            lblResult.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]\n最大值為 " + a;
        }

        private void btn陣列1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int[,] arr =
            {
                { 1,1,1,1,1,1,1,1,1,1 },
                { 1,0,0,0,0,0,0,0,0,1 },
                { 1,0,0,0,0,0,0,0,0,1 },
                { 1,0,0,0,0,0,0,0,0,1 },
                { 1,0,0,0,0,0,0,0,0,1 },
                { 1,0,0,0,0,0,0,0,0,1 },
                { 1,0,0,0,0,0,0,0,0,1 },
                { 1,0,0,0,0,0,0,0,0,1 },
                { 1,0,0,0,0,0,0,0,0,1 },
                { 1,1,1,1,1,1,1,1,1,1 },
            };
            string result = "";
                for(int i = 0; i < 10; i++)
                {
                for (int j = 0; j < 10; j++)
                {
                    result += " " + arr[i, j];
                }
                result += "\n";
                }
            lblResult.Text = result;
        }

        private void brn陣列0_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int[,] arr =
            {
                { 0,0,0,0,0,0,0,0,0,0 },
                { 0,1,1,1,1,1,1,1,1,0 },
                { 0,1,1,1,1,1,1,1,1,0 },
                { 0,1,1,1,1,1,1,1,1,0 },
                { 0,1,1,1,1,1,1,1,1,0 },
                { 0,1,1,1,1,1,1,1,1,0 },
                { 0,1,1,1,1,1,1,1,1,0 },
                { 0,1,1,1,1,1,1,1,1,0 },
                { 0,1,1,1,1,1,1,1,1,0 },
                { 0,0,0,0,0,0,0,0,0,0 },
            };
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += " " + arr[i, j];
                }
                result += "\n";
            }
            lblResult.Text = result;
        }

        private void btn陣列1010_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int[,] arr =
            {
                { 1,0,1,0,1,0,1,0,1,0 },
                { 0,1,0,1,0,1,0,1,0,1 },
                { 1,0,1,0,1,0,1,0,1,0 },
                { 0,1,0,1,0,1,0,1,0,1 },
                { 1,0,1,0,1,0,1,0,1,0 },
                { 0,1,0,1,0,1,0,1,0,1 },
                { 1,0,1,0,1,0,1,0,1,0 },
                { 0,1,0,1,0,1,0,1,0,1 },
                { 1,0,1,0,1,0,1,0,1,0 },
                { 0,1,0,1,0,1,0,1,0,1 },
            };
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += " " + arr[i, j];
                }
                result += "\n";
            }
            lblResult.Text = result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblResult.Text = "結果";
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string c="";
            int b = 0;
            for (int i = 0; i<arrString.Length;i++)
            {
                int x = arrString[i].Length;     
                if (b < x)
                {
                    b = x;
                    c = arrString[i];
                }
            }
            lblResult.Text = c;
        }

        private void btnFor_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFrom.Text))
            {
                MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtTo.Text))
            {
                MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtStep.Text))
            {
                MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lblResult.Text = "";
                int i = int.Parse(txtFrom.Text);
                int to = int.Parse(txtTo.Text);
                int Step = int.Parse(txtStep.Text);
                int sum = 0;
                if (Step >= 1)
                {
                    Step -= i;
                }
                for (; i <= to; i++)
                {
                    sum += i;
                    i += Step;
                }
                lblResult.Text = txtFrom.Text + " 到 " + to + " 相隔 " + Step + "\n加總為 " + sum;
            }

        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFrom.Text))
            {
                MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtTo.Text))
            {
                MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtStep.Text))
            {
                MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lblResult.Text = "";
                int i = int.Parse(txtFrom.Text);
                int to = int.Parse(txtTo.Text);
                int Step = int.Parse(txtStep.Text);
                int sum = 0;
                while (i <= to)
                {
                    sum += i;
                    i += Step;
                }

                lblResult.Text = txtFrom.Text + " 到 " + to + " 相隔 " + (Step-1) + "\n加總為 " + sum;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFrom.Text))
            {
                MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtTo.Text))
            {
                MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtStep.Text))
            {
                MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
           {
                lblResult.Text = "";
                int i = int.Parse(txtFrom.Text);
                int to = int.Parse(txtTo.Text);
                int Step = int.Parse(txtStep.Text);
                int sum = 0;
                do
                {
                    sum += i;
                    i += Step;
                } while (i <= to);

                lblResult.Text = txtFrom.Text + " 到 " + to + " 相隔 " +( Step-1) + "\n加總為 " + sum;
            }
            
        }

        private void btnRows_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtRows.Text))
            {
                MessageBox.Show("請輸入數值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                lblResult.Text = "";
                int a = int.Parse(txtRows.Text);
                string b = "";
                for (int i = 0; a > i; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        b += "*";
                    }
                    b += "*\n";
                }
                lblResult.Text = b;

            }
            
        }

        private void btn99_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblResult.Text = "九九乘法表";
            lblResult.Text += "\n";
            for (int i = 1; i <= 9; i++)
            {
                for(int j = 2; j <= 9; j++)
                {
                    if (i * j < 10)
                    {
                        lblResult.Text +=  j + "x" + i + "=" + " " + i*j + "|";
                    }
                    else
                    {
                        lblResult.Text += j + "x" + i + "=" + i * j + "|";
                    }
                }
                lblResult.Text += "\n";
            }
            
        }

        private void btnCarry_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblResult.Text = Convert.ToString(100, 2);
        }

        private void btnRan_Click(object sender, EventArgs e)
        {
            Random Random = new Random();
            List<int> listNumbers = new List<int>();
            int number= 0;
            string b = "";
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    number = Random.Next(1, 49);
                } while (listNumbers.Contains(number));
                listNumbers.Add(number);
                b += " " + listNumbers[i];
            }
            lblResult.Text = "樂透號碼\n" + b;
        }

        private void btnStringCorc_Click(object sender, EventArgs e)
        {
            int a = 0;
            
            for(int i = 0; i < arrString.Length; i++)
            {  
                if (arrString[i].Contains("C") || arrString[i].Contains("c"))
                {
                    a++;
                }
            }
            lblResult.Text = a.ToString();
        }
    }
}
