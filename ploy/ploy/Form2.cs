using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ploy
{
    public partial class Form2 : Form
    {
        double sum = Class1.getmoney;
        public Form2()

        {
            InitializeComponent();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label78_Click(object sender, EventArgs e)
        {

        }
        double family;
        double temp;
        private void button1_Click(object sender, EventArgs e)
        {
            family = 0;
            tabControl1.SelectTab("tabPage2");
            double son61 = Convert.ToDouble(textBox2.Text)*30000;
            double son62 = Convert.ToDouble(textBox3.Text);
            double hospital = Convert.ToDouble(textBox5.Text);
            double pikan = Convert.ToDouble(numericUpDown1.Value)*60000;

            if (sum * 0.5 > 100000)
            {
                temp = 100000;
                family += 100000;
            }
            else
            {
                temp = sum * 0.5;
                family += sum * 0.5;
            }
            if (radioButton4.Checked)
            {
                family += 120000;
            }
            else
            {
                family += 60000;
            }
            if (son62>0)
            {
                if (son61==0)
                {
                    family += (son62 - 1) * 60000 + 30000;
                }
                else 
                {
                    family += 60000;
                }
            }
            else
            {
                family += 0;
            }
            if (checkBox1.Checked)
            {
                family += 30000;
            }
            if (checkBox2.Checked)
            {
                family += 30000;
            }
            if (checkBox3.Checked)
            {
                family += 30000;
            }
            if (checkBox4.Checked)
            {
                family += 30000;
            }
            if (hospital>60000)
            {
                family += 60000;
            }
            else
            {
                family += hospital;
            }
            family += son61 + pikan;
        }
        double group2,tmp,tmp2;
        private void button2_Click(object sender, EventArgs e)
        {
            group2 = 0;
            tabControl1.SelectTab("tabPage3");
            double sum15 = sum * 0.15;
            //ประกันสังคม
            if (Convert.ToDouble(textBox4.Text)>9000)
            {
                group2 += 9000;
            }
            else
            {
                group2 += Convert.ToDouble(textBox4.Text);
            }
            //ประกันชีวิต
            if (Convert.ToDouble(textBox6.Text) > 100000)
            {
                tmp += 100000;
            }
            else
            {
                tmp += Convert.ToDouble(textBox6.Text);
            }
            //คู่สมรส
            if (Convert.ToDouble(textBox7.Text) > 10000)
            {
                group2 += 10000;
            }
            else
            {
                group2 += Convert.ToDouble(textBox7.Text);
            }
            //ประกันชีวิตมิดามารดา
            if (Convert.ToDouble(textBox10.Text) > 15000)
            {
                group2 += 15000;
            }
            else
            {
                group2 += Convert.ToDouble(textBox10.Text);
            }
            //กองทุนสำรองเลี้ยงชีพ
            if (Convert.ToDouble(textBox11.Text) > 490000 && Convert.ToDouble(textBox11.Text) < sum15)
            {
                tmp2 += 490000;
            }
            else if (Convert.ToDouble(textBox11.Text) > sum15)
            {
                tmp2 += sum15;
            }
            else
            {
                tmp2 += Convert.ToDouble(textBox11.Text);
            }
            //บำนาญ
            if (Convert.ToDouble(textBox8.Text) > 200000 && Convert.ToDouble(textBox8.Text) < sum15)
            {
                tmp2 += 200000;
            }
            else if (Convert.ToDouble(textBox8.Text) > sum15)
            {
                tmp2 += sum15;
            }
            else
            {
                tmp2 += Convert.ToDouble(textBox8.Text);
            }
            //เบี้้ยประกันสุขภาพ
            if (Convert.ToDouble(textBox12.Text) > 15000)
            {
                tmp += 15000;
            }
            else
            {
                tmp += Convert.ToDouble(textBox12.Text);
            }
            //กอช
            if (Convert.ToDouble(textBox13.Text) > 13200)
            {
                tmp2 += 13200;
            }
            else
            {
                tmp2 += Convert.ToDouble(textBox13.Text);
            }
            //กบข
            if (Convert.ToDouble(textBox9.Text) > 500000 && Convert.ToDouble(textBox9.Text)<sum15)
            {
                group2 += 500000;
            }
            else if (Convert.ToDouble(textBox9.Text) > sum15)
            {
                group2 += sum15;
            }
            else
            {
                group2 += Convert.ToDouble(textBox9.Text);
            }
            //LTF
            if (Convert.ToDouble(textBox31.Text) > 500000 && Convert.ToDouble(textBox31.Text) < sum15)
            {
                group2 += 500000;
            }
            else if (Convert.ToDouble(textBox31.Text) > sum15)
            {
                group2 += sum15;
            }
            else
            {
                group2 += Convert.ToDouble(textBox31.Text);
            }
            //RMF
            if (Convert.ToDouble(textBox32.Text) > 500000 && Convert.ToDouble(textBox32.Text) < sum15)
            {
                group2 += 500000;
            }
            else if (Convert.ToDouble(textBox32.Text) > sum15)
            {
                tmp2 += sum15;
            }
            else
            {
                tmp2 += Convert.ToDouble(textBox32.Text);
            }
            //เช็คเบี้ยประกันชีวิต กับเงินประกันสุขภาพไม่เกินแสน
            if (tmp>100000)
            {
                tmp = 100000;
            }
            //เช็คเบี้ยไม่เกิน ห้าแสน
            if (tmp2 > 500000)
            {
                tmp2 = 500000;
            }
            group2 += tmp2 + tmp;
        }
        double group3;
        private void button3_Click(object sender, EventArgs e)
        {
            group3 = 0;
            tabControl1.SelectTab("tabPage4");
            if (Convert.ToDouble(textBox14.Text) > 100000)
            {
                group3 += 100000;
            }
            else
            {
                group3 += Convert.ToDouble(textBox14.Text);
            }
            //บ้านหลังแรก58
            if (Convert.ToDouble(textBox15.Text) > 3000000)
            {
                group3 += 3000000*0.04;
            }
            else
            {
                group3 += Convert.ToDouble(textBox15.Text)*0.04;
            }
            //บ้านุ62
            if (Convert.ToDouble(textBox16.Text) > 5000000)
            {
                group3 += 5000000 * 0.04;
            }
            else
            {
                group3 += Convert.ToDouble(textBox16.Text) * 0.04;
            }

        }
        double group4;
        private void button4_Click(object sender, EventArgs e)
        {
            group4 = 0;
            tabControl1.SelectTab("tabPage5");
            double ed = Convert.ToDouble(textBox18.Text)*2;
            double nomal = Convert.ToDouble(textBox17.Text);
            if (ed > (sum - (family + group2 + group3 + group5)) * 0.1) 
            {
                ed = (sum - (family + group2 + group3 + group5)) * 0.1;
            }

            if (nomal> (sum - (family + group2 + group3 + group5+ed)) * 0.1) 
            {
                nomal = (sum - (family + group2 + group3 + group5+ed)) * 0.1;
            }
            if (Convert.ToDouble(textBox34.Text)>10000)
            {
                group4 += 10000;
            }
            else
            {
                group4 += Convert.ToDouble(textBox34.Text);
            }
            group4 += ed+ nomal;
            

        }
        double group5,sumgroup5;
        private void button5_Click(object sender, EventArgs e)
        {
            group5 = 0;
            tabControl1.SelectTab("tabPage6");
            //สินค้าในกลุ่มช้อปช่วยชาติ สินค้าการศึกษาและกีฬา หนังสือ สินค้า OTOP
            if (Convert.ToDouble(textBox19.Text) > 15000)
            {
                group5 += 15000;
            }
            else
            {
                group5 += Convert.ToDouble(textBox14.Text);
            }
            if (Convert.ToDouble(textBox35.Text) > 15000)
            {
                group5 += 15000;
            }
            else
            {
                group5 += Convert.ToDouble(textBox35.Text);
            }
            if (Convert.ToDouble(textBox36.Text) > 15000)
            {
                group5 += 15000;
            }
            else
            {
                group5 += Convert.ToDouble(textBox36.Text);
            }
            if (Convert.ToDouble(textBox37.Text) > 15000)
            {
                group5 += 15000;
            }
            else
            {
                group5 += Convert.ToDouble(textBox37.Text);
            }
            //ท่องเที่ยว เมืองหลัก
            if (Convert.ToDouble(textBox20.Text) > 15000)
            {
                sumgroup5 += 15000;
            }
            else
            {
                sumgroup5 += Convert.ToDouble(textBox20.Text);
            }
            //เมืองรอง
            if (Convert.ToDouble(textBox21.Text) > 20000)
            {
                sumgroup5 += 20000;
            }
            else
            {
                sumgroup5 += Convert.ToDouble(textBox21.Text);
            }
            //พายุาบึก
            if (Convert.ToDouble(textBox22.Text) > 100000)
            {
                group5 += 100000;
            }
            else
            {
                group5 += Convert.ToDouble(textBox22.Text);
            }
            if (Convert.ToDouble(textBox23.Text) > 30000)
            {
                group5 += 30000;
            }
            else
            {
                group5 += Convert.ToDouble(textBox23.Text);
            }
            //พายุโพดุล
            if (Convert.ToDouble(textBox24.Text) > 100000)
            {
                group5 += 100000;
            }
            else
            {
                group5 += Convert.ToDouble(textBox24.Text);
            }
            if (Convert.ToDouble(textBox25.Text) > 30000)
            {
                group5 += 30000;
            }
            else
            {
                group5 += Convert.ToDouble(textBox25.Text);
            }
            //เช็คท่องเที่ยวไม่เกินสองหมื่น
            if(sumgroup5>20000)
            {
                sumgroup5 = 20000;
            }
            group5 += sumgroup5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            double tax = (sum - (family + group2 + group3 + group4 + group5));
            textBox27.Text = temp.ToString();
            textBox28.Text = (family + group2 + group3 + group4 + group5).ToString();
            textBox26.Text = sum.ToString();
            if(tax<0)
            {
                tax = 0;
            }
            textBox29.Text = tax.ToString();
            if (tax >= 0 && tax <= 150000)
            {
                tax = 0;
            }
            else if (tax > 150000 && tax <= 300000)//2%
            {
                tax = (tax - 150000) * 0.05;
            }
            else if (tax > 300000 && tax <= 500000)//10%
            {
                tax = ((tax - 300000) * 0.1) + 7500;
            }
            else if (tax > 500000 && tax <= 750000)//15%
            {
                tax = ((tax - 500000) * 0.15) + 27500;
            }
            else if (tax > 750000 && tax <= 1000000)//20%
            {
                tax = ((tax - 750000) * 0.2) + 65000;
            }
            else if (tax > 1000000 && tax <= 2000000)//25%
            {
                tax = ((tax - 1000000) * 0.25) + 115000;
            }
            else if (tax > 2000000 && tax <= 5000000)//30%
            {
                tax = ((tax - 2000000) * 0.3) + 365000;
            }
            else if (tax > 5000000)//35%
            {
                tax = ((tax - 5000000) * 0.35) + 1265000;
            }
            textBox30.Text = tax.ToString();


        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
