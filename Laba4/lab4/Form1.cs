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
        public Calculator calculator = new Calculator();
        public Калькулятор()
        {
            InitializeComponent();
        }

        private void sin(object sender, EventArgs e)
        {
            textBox1.Text = $"{Math.Sin(Convert.ToDouble(textBox1.Text))}";
        }

        private void memory(object sender, EventArgs e)
        {
            //m
            textBox1.Text += calculator.getMemory();
            calculator.AddSymbol(calculator.getMemory());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //0
            calculator.AddSymbol("0");
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1
            calculator.AddSymbol("1");
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //2
            calculator.AddSymbol("2");
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //3
            calculator.AddSymbol("3");
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //4
            calculator.AddSymbol("4");
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //5
            calculator.AddSymbol("5");
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //6
            calculator.AddSymbol("6");
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //7
            calculator.AddSymbol("7");
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //8
            calculator.AddSymbol("8");
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //9
            calculator.AddSymbol("9");
            textBox1.Text += "9";
        }

        private void cos(object sender, EventArgs e)
        {
            textBox1.Text = $"{Math.Cos(Convert.ToDouble(textBox1.Text))}";
        }

        private void tan(object sender, EventArgs e)
        {
            textBox1.Text = $"{Math.Tan(Convert.ToDouble(textBox1.Text))}";
        }

        private void cat(object sender, EventArgs e)
        {
            textBox1.Text = $"{1.0/Math.Tan(Convert.ToDouble(textBox1.Text))}";
        }

        private void equals(object sender, EventArgs e)
        {
            textBox1.Text = calculator.Calculate().ToString();
        }

        private void clear(object sender, EventArgs e)
        {
            calculator.SetString("");
            textBox1.Text = "";
        }

        private void memPlus(object sender, EventArgs e)
        {
            calculator.setMemory(textBox1.Text);
        }

        private void dot(object sender, EventArgs e)
        {
            calculator.AddSymbol(".");
            textBox1.Text += ".";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            calculator.AddSymbol("^");
            textBox1.Text += "^";
        }
    }
}
