using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            input.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input.Text += "9";
        }

        private void equals_Click(object sender, EventArgs e)
        {
             result.Text = new DataTable().Compute(input.Text, null).ToString();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            input.Text += "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            input.Text += "-";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            input.Text += "*";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            input.Text += "/";
        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            input.Text = input.Text.Length > 0 ? input.Text.Remove(input.Text.Length - 1) : "";
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            input.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
