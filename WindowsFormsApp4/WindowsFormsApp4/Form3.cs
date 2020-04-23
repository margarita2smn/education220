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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Text = Class5.text;
            dateTimePicker1.Text = Class6.text;
            dateTimePicker2.Text = Class7.text;
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("http://www.okotsit.ru");
        }

        private void Ссылка_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.okotsit.ru");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Process.Start("http://www.okotsit.ru");
        }
    }
}
