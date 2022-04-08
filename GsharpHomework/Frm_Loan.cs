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
    public partial class Frm_Loan : Form
    {
        public Frm_Loan()
        {
            InitializeComponent();
        }

        public static double LoanAmount;
        public static double Period;
        public static double InterestRate;
        public double DownPayment;
        public double MonInterestRate;
        public static double MonthPay;
        public static int MonTotal;

        double calculate()
        {
            LoanAmount = int.Parse(txt總貸.Text);
            Period = int.Parse(txt期限.Text);
            InterestRate = int.Parse(txt利率.Text);
            DownPayment = int.Parse(txt頭期款.Text);

            MonInterestRate = InterestRate / 12 / 100;

            double FirstPay = LoanAmount - DownPayment;

            MonthPay = FirstPay * (Math.Pow((1 + MonInterestRate), Period * 12) * MonInterestRate) /
                                           (Math.Pow((1 + MonInterestRate), Period * 12) -1);

            MonTotal = Convert.ToInt32(Period*12) * Convert.ToInt32(MonthPay);



            return MonthPay;
        }

        private void btnPMT_Click(object sender, EventArgs e)
        {

            double A = calculate();
            MessageBox.Show("月付額：" +A.ToString("#"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double A = calculate();
            MessageBox.Show("總付款：" + MonTotal.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Frm_LoabReport loabReport = new Frm_LoabReport();
            loabReport.Show();
        }
    }
}
