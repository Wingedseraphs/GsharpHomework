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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHollo_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_Hello Hello = new Frm_Hello();
            Hello.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(Hello);
            Hello.Show();
                
        }

        private void btnLora_Click(object sender, EventArgs e)
        {
            Frm_Loan loan = new Frm_Loan();
            splitContainer1.Panel2.Controls.Clear();
            loan.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(loan);
            loan.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_Pos Pos = new Frm_Pos();
            Pos.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(Pos);
            Pos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_StudentStruct StudentStruct = new Frm_StudentStruct();
            StudentStruct.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(StudentStruct);
            StudentStruct.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_StudentsGrade StudentsGrade = new Frm_StudentsGrade();
            StudentsGrade.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(StudentsGrade);
            StudentsGrade.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_studentGrade_list studentGrade_List = new Frm_studentGrade_list();
            studentGrade_List.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(studentGrade_List);
            studentGrade_List.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_Method Method = new Frm_Method();
            Method.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(Method);
            Method.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_MyClac MyClac = new Frm_MyClac();
            MyClac.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(MyClac);
            MyClac.Show();
        }

        private void btn小畫家_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_JuniorPainter JuniorPainter = new Frm_JuniorPainter();
            JuniorPainter.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(JuniorPainter);
            JuniorPainter.Show();

        }
        Frm_JuniorPainter JuniorPainter = new Frm_JuniorPainter();
        private void btn_XOGame_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_XOGame XOGame = new Frm_XOGame();
            XOGame.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(XOGame);
            XOGame.Show();
        }


        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
        {
            //btnHollo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_picture picture = new Frm_picture();
            picture.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(picture);
            picture.Show();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_Guess Guess = new Frm_Guess();
            Guess.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(Guess);
            Guess.Show();
        }

        private void btnScreemSaver_Click(object sender, EventArgs e)
        {      
            Frm_ScreenSaver ScreenSaver = new Frm_ScreenSaver();
            ScreenSaver.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_XOGame XOGame = new Frm_XOGame();
            XOGame.MdiParent = this;
            splitContainer1.Panel2.Controls.Add(XOGame);
            XOGame.Show();
        }
    }
}
