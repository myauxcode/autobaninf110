using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double ejercicio7(int n, double vi1, double r1, double vi2, double r2)
        {
            double f, t1, t2;
            f = 0;
            bool ba;
            ba = true;



            for (int i = 1; i <= n; i++)
            {

                t1 = vi1 + (i - 1) * r1;
                t2 = vi2 + (i - 1) * r2;

                if (ba == true)
                {
                    f = f - Math.Sqrt((Math.Sin(t1)) / (Fact(t2) / 2));
                }
                else
                {
                    f = f + Math.Sqrt((Math.Sin(t1)) / (Fact(t2) / 2));
                }

            }
            return f;
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


        public string ejercicio7t(int n, double vi1, double r1, double vi2, double r2)
        {
            double t1, t2;
            string f, t;
            f = "";
            t = "";
            bool ba;
            ba = true;



            for (int i = 1; i <= n; i++)
            {

                t1 = vi1 + (i - 1) * r1;
                t2 = vi2 + (i - 1) * r2;

                if (ba == true)
                {
                    f = f + "  - Sqrt((Sin(" + t1 + ")) / ((" + t2 + ")! / " + 2 + "))";
                    ba = !ba;
                }
                else
                {
                    f = f + " + Sqrt((Sin(" + t1 + ")) / ((" + t2 + ")! / " + 2 + "))";
                    ba = !ba;
                }

            }
            return f;
        }


        private void eJERCICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Concat(ejercicio7(int.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text)));

            textBox7.Text = string.Concat(ejercicio7t(int.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text)));

        }
    }
}
