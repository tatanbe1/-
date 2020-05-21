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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = (Convert.ToDouble(textBox1.Text) * 12) + Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text);
            Class1.setmoney(sum);
            Form2 form = new Form2();
            form.Show();
        }
    }
}
