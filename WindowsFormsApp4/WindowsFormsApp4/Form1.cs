using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Form2 frm2; Form3 frm3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.text = textBox1.Text ;
            Class2.text = dateTimePicker1.Text;
            Class3.text = textBox3.Text;
            Class4.text = button4.Text;


            frm2 = new Form2();
            frm2.Show();
            textBox1.Text = "Button was clicked!";


        }

        private void button2_Click(object sender, EventArgs e)

        {
            Class5.text =button1.Text;
            Class6.text = dateTimePicker2.Text;
            Class7.text = dateTimePicker3.Text;
          
            frm3 = new Form3();
            frm3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start ("https://mail.ru");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.okotsit.ru");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
