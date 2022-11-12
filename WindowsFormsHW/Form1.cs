using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (int.TryParse(s, out int speed))
            {
                if (speed > 0 && speed <= 250)
                {
                    textBox1.BackColor = Color.Green;
                }
                else
                {
                    textBox1.BackColor = Color.Red;
                }
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (int.TryParse(s, out int speed))
            {
                if (speed > 0 && speed <= 250)
                {
                    textBox1.BackColor = Color.Green;
                }
                else
                {
                    label4.Text = "Error";
                }
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
