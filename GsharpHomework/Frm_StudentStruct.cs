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
    public partial class Frm_StudentStruct : Form
    {
        public Frm_StudentStruct()
        {
            InitializeComponent();
        }

        String name = " ";
        int Chinese = 0;
        int English = 0;
        int math = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "姓名：" + name + "\n" + 
                          "國文：" + Chinese + "分" + "\n" +
                          "英文：" + English + "分" + "\n" +
                          "數學：" + math + "分" ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = TxtName.Text;
            Chinese = int.Parse(TxtEnglish.Text);
            English = int.Parse(TxtEnglish.Text);
            math = int.Parse(TxtMath.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (math >= Chinese && math >= English)
            {
                LblShowHightest.Text = "最高科目成績為：數學" + math +"分";
            }else if (Chinese >= math && Chinese >= English)
            {
                LblShowHightest.Text = "最高科目成績為：國文" + English + "分";
            }
            else
            {
                LblShowHightest.Text = "最高科目成績為：英文" + Chinese + "分";
            }

            if (math <= Chinese && math <= English)
            {
                LblShowLowest.Text = "最低科目成績為：數學" + math + "分";
            }
            else if (Chinese <= math && Chinese <= English )
            {
                LblShowLowest.Text = "最低科目成績為：國文" + Chinese + "分";
            }
            else
            {
                LblShowLowest.Text = "最低科目成績為：英文" + English + "分";
            }
            
        }
    }
}
