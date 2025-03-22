using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double a = double.Parse(textBox2.Text);
            double v = Math.Pow(a, 3) - Math.Pow(x, 2);
            if (x != 0 && a != 0 && v >= 0)
            {
                double b = 2 / x;

                double c = Math.Sqrt(v);
                double d = b * c;
                double s = Math.Pow(a, 2) / 2;
                double r = Math.Asin(x / Math.Abs(a));
                double g = s * r;
                double F = d + g;
                label4.Text = "Значение F в 10 с. и.: " + F.ToString();
                int q = (int)Math.Floor(F);
                string bF = Convert.ToString(q, 2);
                label5.Text = "Значение F в 2 с. и.: " + bF.ToString();
            }
            else
            {
                label4.Text = "Невозможно посчитать";
                label5.Text = "Невозможно посчитать";
            }
        }
    }
}
