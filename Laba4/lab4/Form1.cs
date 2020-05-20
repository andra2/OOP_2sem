using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Калькулятор : Form
    {
        public static string Savedmem;
        public string Memory;
        public Калькулятор()
        {
            InitializeComponent();
        }

        private void sin(object sender, EventArgs e)
        {
            try
            {
                Memory = textBox1.Text = $"{Math.Sin(Convert.ToDouble(textBox1.Text))}";
            }
            catch (Exception)
            {
                Memory = textBox1.Text = "";
            }
        }

        private void memory(object sender, EventArgs e)
        {
            //m
            Memory = textBox1.Text = Savedmem;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //0
            Memory += "0";
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1
            Memory += "1";
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //2
            Memory += "2";
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //3
            Memory += "3";
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //4
            Memory += "4";
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //5
            Memory += "5";
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //6
            Memory += "6";
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //7
            Memory += "7";
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //8
            Memory += "8";
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //9
            Memory += "9";
            textBox1.Text += "9";
        }

        private void cos(object sender, EventArgs e)
        {
            try
            {
                Memory = textBox1.Text = $"{Math.Cos(Convert.ToDouble(textBox1.Text))}";
            }
            catch (Exception)
            {
                Memory = textBox1.Text = "";
            }
        }

        private void tan(object sender, EventArgs e)
        {
            try
            {
                Memory = textBox1.Text = $"{Math.Tan(Convert.ToDouble(textBox1.Text))}";
            }
            catch (Exception)
            {
                Memory = textBox1.Text = "";
            }
        }

        private void cat(object sender, EventArgs e)
        {
            try
            {
                Memory = textBox1.Text = $"{1.0 / Math.Tan(Convert.ToDouble(textBox1.Text))}";
            }
            catch (Exception)
            {
                Memory = textBox1.Text = "";
            }
        }

        private void equals(object sender, EventArgs e)
        {
            //=

            if (textBox1.Text != "")
            {
                string[] buff = textBox1.Text.Split('^');
                double a, b;
                try
                {
                    a = Convert.ToDouble(buff[0]);
                    b = Convert.ToDouble(buff[1]);
                    Memory = textBox1.Text = Math.Pow(a, b).ToString();
                }
                catch (Exception)
                {

                }
            }
        }

        private void clear(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Memory = "";
        }

        private void memPlus(object sender, EventArgs e)
        {
            Savedmem = Memory;
        }

        private void dot(object sender, EventArgs e)
        {
            Memory += ",";
            textBox1.Text += ",";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.ToString().Contains("^"))
            {
                Memory += "^";
                textBox1.Text += "^";
            }
            else
            {
                textBox1.Text = textBox1.Text.ToString().Trim('^');
                Memory = Memory.Trim('^');
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.ToString().StartsWith("-"))
            {
                Memory = "-" + Memory;
                string buf = textBox1.Text;
                buf = "-" + buf;
                textBox1.Text = buf;
            }
            else
            {
                string buf = textBox1.Text;
                buf = buf.Trim('-');
                textBox1.Text = buf;
                Memory = Memory.Trim('-');
            }
        }
    }
}
