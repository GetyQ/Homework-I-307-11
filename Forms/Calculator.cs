using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Calculator : Form
    {
        double firstNumber = 0;
        double secondNumber = 0;
        string operation = "";
        bool newEntry = true;

        public Calculator()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox1.TextChanged += TextBox1_TextChanged;
        }

        public void TextBox1_TextChanged(object? sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
                return;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            else
                textBox1.Text = "0";
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
                return;
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            newEntry = true;
        }
        public void button14_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "1"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "1"; }
        }
        public void button15_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "2"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "2"; }
        }
        public void button16_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "3"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "3"; }
        }
        public void button11_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "4"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "4"; }
        }
        public void button12_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "5"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "5"; }
        }
        public void button13_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "6"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "6"; }
        }
        public void button6_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "7"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "7"; }
        }
        public void button7_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "8"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "8"; }
        }
        public void button8_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "9"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "9"; }
        }
        public void button20_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "0"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "0"; }
        }
        public void button19_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "+";
            newEntry = true;
        }
        public void button18_Click(object sender, EventArgs e)
        {
            firstNumber += Convert.ToDouble(textBox1.Text);
            operation = "-";
            newEntry = true;
        }
        public void button17_Click(object sender, EventArgs e)
        {
            firstNumber -= Convert.ToDouble(textBox1.Text);
            operation = "*";
            newEntry = true;
        }
        public void button9_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "/";
            newEntry = true;
        }
        public void button23_Click(object sender, EventArgs e)
        {
            if (operation == "") return;

            secondNumber = Convert.ToDouble(textBox1.Text.Replace(",", "."));
            double result = 0;

            if (operation == "+") { result = firstNumber + secondNumber; }
            else if (operation == "-") { result = firstNumber - secondNumber; }
            else if (operation == "*") { result = firstNumber * secondNumber; }
            else if (operation == "/")
            {
                if (secondNumber == 0) { MessageBox.Show("На ноль делить нельзя"); return; }
                result = firstNumber / secondNumber;
            }

            textBox1.Text = result.ToString();
            operation = "";
            newEntry = true;
        }
        public void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
            newEntry = true;
        }
        public void button21_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "0"; newEntry = false; }
            if (!textBox1.Text.Contains(",")) textBox1.Text = textBox1.Text + ",";
        }
        public void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '-') { textBox1.Text = textBox1.Text.Substring(1); }
            else if (textBox1.Text != "0") { textBox1.Text = "-" + textBox1.Text; }
        }
        public void button5_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text.Replace(",", "."));
            if (num < 0) { MessageBox.Show("Корень не извлекается из открицательного числа"); return; }
            textBox1.Text = Math.Sqrt(num).ToString();
            newEntry = true;
        }
        public void button10_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text.Replace(",", "."));
            textBox1.Text = (num / 100).ToString();
            newEntry = true;
        }
        public void button22_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text.Replace(",", "."));
            if (num == 0) { MessageBox.Show("На ноль делить нельзя"); return; }
            textBox1.Text = (1 / num).ToString();
            newEntry = true;
        }
    }
}
