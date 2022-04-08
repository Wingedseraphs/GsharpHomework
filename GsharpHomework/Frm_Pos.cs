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
    public partial class Frm_Pos : Form
    {
        public Frm_Pos()
        {
            InitializeComponent();
        }

        int Beer = 0;
        int BeerSum = 0;
        int Tequila = 0;
        int TequilaSum = 0;
        int Whisky = 0;
        int WhiskySum = 0;
        int Wine = 0;
        int WineSum = 0;
        int Total = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Beer += 1;
            BeerSum += 120;
            Total = BeerSum + TequilaSum + WhiskySum + WineSum;

            TxtTotal.Text = "NT$ " + Total.ToString();
            listBox1.Items.Remove("尚未點餐");
            listBox1.Items.Remove("啤酒Beer x" + (Beer - 1) + "," + "共NT$" + (BeerSum - 120) + "元");
            listBox1.Items.Add("啤酒Beer x"+ Beer +"," + "共NT$" + BeerSum + "元");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tequila += 1;
            TequilaSum += 180;
            Total = BeerSum + TequilaSum + WhiskySum + WineSum;

            TxtTotal.Text = "NT$ " + Total.ToString();
            listBox1.Items.Remove("尚未點餐");
            listBox1.Items.Remove("龍舌蘭Tequila x" + (Tequila- 1) + "," + "共NT$" + (TequilaSum - 180) + "元");
            listBox1.Items.Add("龍舌蘭Tequila x" + Tequila + "," + "共NT$" + TequilaSum + "元");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Whisky += 1;
            WhiskySum += 350;
            Total = BeerSum + TequilaSum + WhiskySum + WineSum;

            TxtTotal.Text = "NT$ " + Total.ToString();
            listBox1.Items.Remove("尚未點餐");
            listBox1.Items.Remove("威士忌Whisky x" + (Whisky - 1) + "," + "共NT$" + (WhiskySum - 350) + "元");
            listBox1.Items.Add("威士忌Whisky x" + Whisky + "," + "共NT$" + WhiskySum + "元");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Wine += 1;
            WineSum += 320;
            Total = BeerSum + TequilaSum + WhiskySum + WineSum;

            TxtTotal.Text = "NT$ " + Total.ToString();
            listBox1.Items.Remove("尚未點餐");
            listBox1.Items.Remove("紅酒Wine x" + (Wine - 1) + "," + "共NT$" + ( WineSum - 320) + "元");
            listBox1.Items.Add("紅酒Wine x" + Wine + "," + "共NT$" + WineSum + "元");
        }

        private void BtnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額：NT$" + Total, "確定付款");
        }

        private void BtnCreditCard_Click(object sender, EventArgs e)
        {

            double TotalSum = Total * 0.9; 
            MessageBox.Show("總金額：NT$" + Total + "\n" + "折扣後金額：NT$" + TotalSum.ToString("#") , "確定付款");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("尚未點餐");
            Total = 0;
            TxtTotal.Text = "NT$ 0" ;
        }
    }
} 
