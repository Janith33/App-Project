using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1=int.Parse(txtDisplay.Text);

            txtDisplay.Clear();

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtDisplay.Text);

            if(option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("/"))
                result = num1 / num2;

            if (option.Equals("*"))
                result = num1 * num2;

            txtDisplay.Text = result + "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
