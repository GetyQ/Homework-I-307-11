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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            else
                textBox1.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            newEntry = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "0"; newEntry = false; }
            if (!textBox1.Text.Contains(",")) textBox1.Text = textBox1.Text + ",";
        }
        private void buttom14_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "1"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "1"; }
        }
        private void buttom15_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "2"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "2"; }
        }
        private void buttom16_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "3"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "3"; }
        }
        private void buttom11_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "4"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "4"; }
        }
        private void buttom12_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "5"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "5"; }
        }
        private void buttom13_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "6"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "6"; }
        }
        private void buttom6_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "7"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "7"; }
        }
        private void buttom7_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "8"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "8"; }
        }
        private void buttom8_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "9"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "9"; }
        }
        private void buttom20_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "0"; newEntry = false; }
            else { if (textBox1.Text == "0") textBox1.Text = ""; textBox1.Text = textBox1.Text + "0"; }
        }
        private void buttom19_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "+";
            newEntry = true;
        }
        private void buttom18_Click(object sender, EventArgs e)
        {
            firstNumber += Convert.ToDouble(textBox1.Text);
            operation = "-";
            newEntry = true;
        }
        private void buttom17_Click(object sender, EventArgs e)
        {
            firstNumber -= Convert.ToDouble(textBox1.Text);
            operation = "*";
            newEntry = true;
        }
        private void buttom9_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "/";
            newEntry = true;
        }
        private void buttom23_Click(object sender, EventArgs e)
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
        private void buttom2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            newEntry = true;
        }
        private void buttom3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
            newEntry = true;
        }
        private void buttom21_Click(object sender, EventArgs e)
        {
            if (newEntry == true) { textBox1.Text = "0"; newEntry = false; }
            if (!textBox1.Text.Contains(",")) textBox1.Text = textBox1.Text + ",";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '-') { textBox1.Text = textBox1.Text.Substring(1); }
            else if (textBox1.Text != "0") { textBox1.Text = "-" + textBox1.Text; }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text.Replace(",", "."));
            if (num < 0) { MessageBox.Show("Корень не извлекается из открицательного числа"); return; }
            textBox1.Text = Math.Sqrt(num).ToString();
            newEntry = true;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text.Replace(",", "."));
            textBox1.Text = (num / 100).ToString();
            newEntry = true;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text.Replace(",", "."));
            if (num == 0) { MessageBox.Show("На ноль делить нельзя"); return; }
            textBox1.Text = (1 / num).ToString();
            newEntry = true;
        }
    }
}
