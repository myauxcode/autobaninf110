using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenrecsd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Fact(double n)
        {
            double f;
            double i;


            if (n != 0)
            {
                f = 1;
                for (i = Math.Abs(n); i >= 1; i--)
                {
                    f = f * i;
                    if (n < 0)
                    {
                        f = -f;
                    }

                }
            }
            else
            {
                f = 1;
            }

            return f;
        }

        public double examen(double x1, double A, double B, double vim, double m, double BASE)
        {
            bool ba = true;
            double raiz = 2.0;
            double i = 1.0;
            double C = 0;
            double f = 0.0;
            double i2 = -1.0;
            vim /= m;
            do
            {
                raiz += i - 1.0;
                i += 1.0;

                C = (A - B);
                A = B;
                B = C;
                vim *= m;
                i2 += 1.0;
                f = ((!ba) ? (f + Math.Pow((x1 + C) / (Math.Cos(vim) + Math.Pow(BASE, i2)), 1.0 / raiz)) : (f - Math.Pow((x1 + C) / (Math.Cos(vim) + Math.Pow(BASE, i2)), 1.0 / raiz)));
                ba = !ba;
            }
            while (C != 0);
            return f;
        }

    



        public string examen_texto(double x1, double A, double B, double vim, double m, double BASE)
        {
            bool ba = true;
            double raiz = 2.0;
            double i = 1.0;
            double C = 0;
            string f = "";
            double i2 = -1.0;
            vim /= m;
            do
            {
                raiz += i - 1.0;
                i += 1.0;
                C = (A - B);
                A = B;
                B = C;
                vim *= m;
                i2 += 1.0;
                f = ((!ba) ? (f + " + ((x1 + " + (C) + ") / (Cos(" + (vim) + ") + (b1 ^ " + (i2) + "))) ^ (1 / " + (raiz) + ")") : (f + "   -   ((x1 + " + (C) + ") / (Cos(" + (vim) + ") + (b1 ^ " + (i2) + "))) ^ (1 / " + (raiz) + ")"));
                ba = !ba;
            }
            while (C != 0);
            return f;
        }


        private void examenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = string.Concat(examen(int.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text), double.Parse(textBox6.Text)));
            textBox8.Text = string.Concat(examen_texto(int.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text), double.Parse(textBox6.Text)));




        }
    }
}
