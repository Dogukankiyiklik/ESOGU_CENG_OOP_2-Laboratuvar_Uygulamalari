using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput1 = textBox1.Text;
            string userInput2 = textBox2.Text;

            int value1 = Convert.ToInt32(userInput1);
            int value2 = Convert.ToInt32(userInput2);

            int result = value1 + value2;

            if(result > 0)
            {
                label1.BackColor = Color.Green;
            }
            else
            {
                label1.BackColor = Color.Red;
            }

            label1.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userInput1 = textBox1.Text;
            string userInput2 = textBox2.Text;

            int value1 = Convert.ToInt32(userInput1);
            int value2 = Convert.ToInt32(userInput2);

            int result = value1 - value2;

            if (result > 0)
            {
                label1.BackColor = Color.Green;
            }
            else
            {
                label1.BackColor = Color.Red;
            }

            label1.Text = Convert.ToString(result);
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Red;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Red;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userInput1 = textBox1.Text;
            string userInput2 = textBox2.Text;

            int value1 = Convert.ToInt32(userInput1);
            int value2 = Convert.ToInt32(userInput2);

            int result = value1 * value2;

            if (result > 0)
            {
                label1.BackColor = Color.Green;
            }
            else
            {
                label1.BackColor = Color.Red;
            }

            label1.Text = Convert.ToString(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string userInput1 = textBox1.Text;
            string userInput2 = textBox2.Text;

            int value1 = Convert.ToInt32(userInput1);
            int value2 = Convert.ToInt32(userInput2);
            int result;

            if (value2 != 0)
            {
                result = value1 / value2;

                if (result > 0)
                {
                    label1.BackColor = Color.Green;
                }
                else
                {
                    label1.BackColor = Color.Red;
                }

                label1.Text = Convert.ToString(result);
            }

            else
            {
                label1.Text = "Invalid!";
                label1.BackColor= Color.Red;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
