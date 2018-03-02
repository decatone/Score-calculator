using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private double lblmk1 = 1.00;
        private double lblmk2 = 1.00;
        private double lblmk3 = 1.00;
        private double lblmk4 = 1.00;
        private double workScore = 0.00;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblrpt1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int scrlb1 = this.hScrollBar1.Value;
            lblmk1 = (scrlb1 + 1) / 100.00;
            this.lblmark1.Text = lblmk1.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int scrlb2 = this.hScrollBar2.Value;
            lblmk2 = (scrlb2 + 1) / 100.00;
            this.lblmark2.Text = lblmk2.ToString();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            int scrlb3 = this.hScrollBar3.Value;
            lblmk3 = (scrlb3 + 1) / 100.00;
            this.lblmark3.Text = lblmk3.ToString();
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            int scrlb4 = this.hScrollBar4.Value;
            lblmk4 = (scrlb4 + 1) / 100.00;
            this.lblmark4.Text = lblmk4.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "") { this.textBox1.Text = "0"; };//不允许输入null
            double originScore = 0.00;
            double extraScore = 0.00;
            int workOrigin = 0;
            int workExtra = 0;
            int total = Convert.ToInt32(this.textBox1.Text);
            if (total >= 60) //总工作时长大于60，有可能需要计算附加分。
            {
                if ((total - 60)*lblmk1/6*5 < 50) //基础分不到50时
                {

                }
                else
                {
                    workOrigin = 60;
                    workExtra = total - 60;
                    originScore = 60 * lblmk1 / 6 * 5;
                }
                if (workExtra*lblmk1/6 < 15)//附加分不足15分时
                {
                    extraScore = workExtra * lblmk1 / 6;
              
                }
                else { extraScore = 15; }//附加分15分
                workScore = originScore + extraScore;
                lblrpt1.Text = "总分：" + workScore.ToString() + "。基础分：" + originScore.ToString() + "，附加时长：" + workExtra.ToString() + "，附加分：" + extraScore.ToString();

            }
            else //不足60s的情况，不需要附加分
            {
                workOrigin = Convert.ToInt32(this.textBox1.Text);
                originScore = workOrigin * lblmk1 / 6 * 5;
                workScore = originScore;
                lblrpt1.Text = "总分：" + workScore.ToString() + "。基础分：" + originScore.ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//textbox1只能输入数字
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)//char8是退格
            {
                e.Handled = true;
            }//e.keychar和e.handled不知道是什么……
        }
    }
}
