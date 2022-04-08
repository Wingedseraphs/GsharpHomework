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
    public partial class Frm_StudentsGrade : Form
    {
        public Frm_StudentsGrade()
        {
            InitializeComponent();
        }

        int NameNumber;
        string name, Highest, Lowest;
        double Chinese,English,math,Average,Total,ChineseTotal,EnglishTotal,mathTotal,
               ChineseAverage,EnglishAverage,mathAverage,ChineseHihgest, EnglishHihgest, mathHihgest,
               ChineseLowest=100, EnglishLowest=100, mathLowest=100;
        string[] Sum = new string[8];
        ListViewItem item;

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] ss = Sum;
            foreach(string item in ss)
            {
                listView2.Items.Add(item);
            }
        }



        //統計
        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            BtnStatistics.Enabled = false;
            BtnJoin.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;

            Sum[0] = "總分";
            Sum[1] = ChineseTotal.ToString();
            Sum[2] = EnglishTotal.ToString();
            Sum[3] = mathTotal.ToString();

            item = new ListViewItem(Sum);
            listView2.Items.Add(item);

            Sum[0] = "平均";
            Sum[1] = ChineseAverage.ToString("0.0");
            Sum[2] = EnglishAverage.ToString("0.0");
            Sum[3] = mathAverage.ToString("0.0");

            item = new ListViewItem(Sum);
            listView2.Items.Add(item);

            Sum[0] = "最高分";
            Sum[1] = ChineseHihgest.ToString();
            Sum[2] = EnglishHihgest.ToString();
            Sum[3] = mathHihgest.ToString();

            item = new ListViewItem(Sum);
            listView2.Items.Add(item);

            Sum[0] = "最低分";
            Sum[1] = ChineseLowest.ToString();
            Sum[2] = EnglishLowest.ToString();
            Sum[3] = mathLowest.ToString();

            item = new ListViewItem(Sum);
            listView2.Items.Add(item);

            

        }
       
        //隨機加入20筆
        private void button5_Click(object sender, EventArgs e)
        {
            BtnStatistics.Enabled = true;
            Random Random = new Random();
            for (int j = 0; j < 20; j++)
            {

                NameNumber += 1;

                for (int i = 1; i < Sum.Length; i++)
                {
                    int ranNum = Random.Next(0, 100);
                    Sum[i] = ranNum.ToString();
                }

                name = TxtName.Text;
                Chinese = double.Parse(Sum[1]);
                English = double.Parse(Sum[2]);
                math = double.Parse(Sum[3]);

                Total = Chinese + English + math;
                Average = Math.Round((Total / 3), 1);

                ChineseTotal += Chinese;
                EnglishTotal += English;
                mathTotal += math;

                ChineseAverage = ChineseTotal / NameNumber;
                EnglishAverage = EnglishTotal / NameNumber;
                mathAverage = mathTotal / NameNumber;

                if (ChineseHihgest <= Chinese)
                {
                    ChineseHihgest = Chinese;
                }
                if (EnglishHihgest <= English)
                {
                    EnglishHihgest = English;
                }
                if (mathHihgest <= math)
                {
                    mathHihgest = math;
                }

                if (ChineseLowest >= Chinese)
                {
                    ChineseLowest = Chinese;
                }
                if (EnglishLowest >= English)
                {
                    EnglishLowest = English;
                }
                if (mathLowest >= math)
                {
                    mathLowest = math;
                }

                if (math <= Chinese && math <= English)
                {
                    Lowest = "數學" + math;
                }
                else if (Chinese <= math && Chinese <= English)
                {
                    Lowest = "國文" + Chinese;
                }
                else
                {
                    Lowest = "英文" + English;
                }

                if (math >= Chinese && math >= English)
                {
                    Highest = "數學" + math;
                }
                else if (Chinese >= math && Chinese >= English)
                {
                    Highest = "國文" + Chinese;
                }
                else
                {
                    Highest = "英文" + English;
                }

                Sum[0] = NameNumber.ToString();
                Sum[4] = Total.ToString();
                Sum[5] = Average.ToString("0.0");
                Sum[6] = Lowest;
                Sum[7] = Highest;

                item = new ListViewItem(Sum);
                listView1.Items.Add(item);
            }
        }
        
        //重設
        private void button4_Click(object sender, EventArgs e)
        {
            BtnStatistics.Enabled = false;
            BtnJoin.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;

            NameNumber = 0;
            ChineseTotal = 0;
            EnglishTotal = 0;
            mathTotal = 0;
            listView1.Items.Clear();
            listView2.Items.Clear();

        }
        
        //隨機加入1筆
        private void button2_Click(object sender, EventArgs e)
        {
            BtnStatistics.Enabled = true;

            NameNumber += 1;

            Random Random = new Random();

            for (int i = 1; i < Sum.Length; i++)
            {
                int ranNum = Random.Next(0, 100);
                Sum[i] = ranNum.ToString();
            }

            name = TxtName.Text;
            Chinese = double.Parse(Sum[1]);
            English = double.Parse(Sum[2]);
            math = double.Parse(Sum[3]);

            Total = Chinese + English + math;
            Average = Math.Round((Total / 3), 1);

            ChineseTotal += Chinese;
            EnglishTotal += English;
            mathTotal += math;

            ChineseAverage = ChineseTotal / NameNumber;
            EnglishAverage = EnglishTotal / NameNumber;
            mathAverage = mathTotal / NameNumber;

            if (ChineseHihgest <= Chinese)
            {
                ChineseHihgest = Chinese;
            }
            if (EnglishHihgest <= English)
            {
                EnglishHihgest = English;
            }
            if (mathHihgest <= math)
            {
                mathHihgest = math;
            }

            if (ChineseLowest >= Chinese)
            {
                ChineseLowest = Chinese;
            }
            if (EnglishLowest >= English)
            {
                EnglishLowest = English;
            }
            if (mathLowest >= math)
            {
                mathLowest = math;
            }

            if (math <= Chinese && math <= English)
            {
                Lowest = "數學" + math;
            }
            else if (Chinese <= math && Chinese <= English)
            {
                Lowest = "國文" + Chinese;
            }
            else
            {
                Lowest = "英文" + English;
            }

            if (math >= Chinese && math >= English)
            {
                Highest = "數學" + math;
            }
            else if (Chinese >= math && Chinese >= English)
            {
                Highest = "國文" + Chinese;
            }
            else
            {
                Highest = "英文" + English;
            }
            
            Sum[0] = NameNumber.ToString();
            Sum[4] = Total.ToString();
            Sum[5] = Average.ToString("0.0");
            Sum[6] = Lowest;
            Sum[7] = Highest;

            item = new ListViewItem(Sum);
            listView1.Items.Add(item);
        }
        
        //手動加入
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                MessageBox.Show("請輸入姓名", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(TxtChinese.Text))
            {
                MessageBox.Show("請輸入國文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(TxtEnglish.Text))
            {
                MessageBox.Show("請輸入英文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(TxtMath.Text))
            {
                MessageBox.Show("請輸入數學成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BtnStatistics.Enabled = true;

                NameNumber += 1;
                name = TxtName.Text;
                Chinese = int.Parse(TxtChinese.Text);
                English = int.Parse(TxtEnglish.Text);
                math = int.Parse(TxtMath.Text);

                Total = Chinese + English + math;
                Average = Math.Round((Total / 3), 1);

                ChineseTotal += Chinese;
                EnglishTotal += English;
                mathTotal += math;

                ChineseAverage = ChineseTotal / NameNumber;
                EnglishAverage = EnglishTotal / NameNumber;
                mathAverage = mathTotal / NameNumber;

                if (ChineseHihgest <= Chinese)
                {
                    ChineseHihgest = Chinese;
                }
                if (EnglishHihgest <= English)
                {
                    EnglishHihgest = English;
                }
                if (mathHihgest <= math)
                {
                    mathHihgest = math;
                }

                if (ChineseLowest >= Chinese)
                {
                    ChineseLowest = Chinese;
                }
                if (EnglishLowest >= English)
                {
                    EnglishLowest = English;
                }
                if (mathLowest >= math)
                {
                    mathLowest = math;
                }



                if (math <= Chinese && math <= English)
                {
                    Lowest = "數學" + math;
                }
                else if (Chinese <= math && Chinese <= English)
                {
                    Lowest = "國文" + Chinese;
                }
                else
                {
                    Lowest = "英文" + English;
                }

                if (math >= Chinese && math >= English)
                {
                    Highest = "數學" + math;
                }
                else if (Chinese >= math && Chinese >= English)
                {
                    Highest = "國文" + Chinese;
                }
                else
                {
                    Highest = "英文" + English;
                }

                Sum[0] = name;
                Sum[1] = Chinese.ToString();
                Sum[2] = English.ToString();
                Sum[3] = math.ToString();
                Sum[4] = Total.ToString();
                Sum[5] = Average.ToString("0.0");
                Sum[6] = Lowest;
                Sum[7] = Highest;

                item = new ListViewItem(Sum);
                listView1.Items.Add(item);
            }

        }

    }
}
