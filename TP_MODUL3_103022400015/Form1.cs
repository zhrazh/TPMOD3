using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
//Di awal syntax ada import library digunakan untuk menyediakan
//fungsi dasar C# serta GUI seperti Form, Label, dan Button.

namespace TP_MODUL3_103022400015
{
    public partial class Form1 : Form
    {
        double nilai1 = 0; // untuk menyimpan angka pertama yang dimasukkan pengguna
        string operasi = ""; // untuk menyimpan jenis operasi matematika yang dipilih

        public Form1()
        {
            InitializeComponent(); // memuat semua komponen GUI seperti label dan button yang telah dibuat di desain form
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // setiap tombol angka memiliki event Click,
        // berfungsi untuk menampilkan angka ke dalam label output
        // berlaku untuk button1 sampai button0
        private void button1_Click(object sender, EventArgs e)
        {
            labelOutput.Text += "1";
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            labelOutput.Text += "2";
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            labelOutput.Text += "3";
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            labelOutput.Text += "4";
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            labelOutput.Text += "5";
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            labelOutput.Text += "6";
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            labelOutput.Text += "7";
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            labelOutput.Text += "8";
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            labelOutput.Text += "9";
        }
        private void button0_Click_1(object sender, EventArgs e)
        {
            labelOutput.Text += "0";
        }
        private void buttonPlus_Click_1(object sender, EventArgs e)
        {
            nilai1 = Convert.ToDouble(labelOutput.Text);
            operasi = "+";
            labelOutput.Text = "";
        }
        private void buttonEqual_Click_1(object sender, EventArgs e)
        {
            double nilai2 = Convert.ToDouble(labelOutput.Text);

            if (operasi == "+")
            {
                labelOutput.Text = (nilai1 + nilai2).ToString();
            }
        }
    }
}
