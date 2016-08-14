using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcersiseB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double x = Convert.ToDouble(textBox1.Text);
            double totalsalary = (((3.00 / 100) * x) + ((10.00 / 100) * x) + x);
            textBox2.Text = totalsalary.ToString();

        }
        private void setBold(object sender, EventArgs e)
        {
            textBox2.Font = new Font(textBox2.Font, FontStyle.Bold);
        }
    }
}
