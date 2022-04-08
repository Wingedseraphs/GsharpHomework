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
    public partial class Frm_LoabReport : Form
    {
        public Frm_LoabReport()
        {
            InitializeComponent();
        }

        private void Frm_LoabReport_Load(object sender, EventArgs e)
        {
            lbl總款.Text = Frm_Loan.LoanAmount.ToString(); 
            lbl期限.Text = Frm_Loan.Period.ToString();
            lbl利率.Text = Frm_Loan.InterestRate.ToString();
            lbl月付.Text = Frm_Loan.MonthPay.ToString("#");
            lbl總付.Text = Frm_Loan.MonTotal.ToString();
        }
    }
}
