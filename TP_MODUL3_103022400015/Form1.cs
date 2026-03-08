using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MODUL3_103022400015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double nilai1 = 0;
        string operasi = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            labelOutput.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            labelOutput.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            labelOutput.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            labelOutput.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            labelOutput.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            labelOutput.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            labelOutput.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            labelOutput.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            labelOutput.Text += "9";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            labelOutput.Text += "0";
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToDouble(labelOutput.Text);
            operasi = "+";
            labelOutput.Text = "";
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double nilai2 = Convert.ToDouble(labelOutput.Text);

            if (operasi == "+")
            {
                labelOutput.Text = (nilai1 + nilai2).ToString();
            }
        }
    }
}
