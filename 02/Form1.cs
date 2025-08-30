using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Text = "Generate-Calculate";
            }
            else
            {
                button1.Text = "Generate";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Multiline = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            label1.Text = "Average: ";

            string inputS = textBox1.Text;
            int input;
            bool valid = int.TryParse(inputS, out input);

            if (valid)
            {
                input = Convert.ToInt32(inputS);
                if(input < 0) 
                {
                    MessageBox.Show("Invalid Value", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid Value", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int firstNumber = 1;
            int secondNumber = 1;
            int temp;
            int[] fibonacci = new int[input];

            if(input > 1)
            {
                fibonacci[0] = firstNumber;
                fibonacci[1] = secondNumber;
            }

            else if(input == 1)
            {
                fibonacci[0] = firstNumber;
            }

            for (int i = 2; i < input; i++)
            {
                temp = firstNumber + secondNumber;
                fibonacci[i] = temp;
                firstNumber = secondNumber;
                secondNumber = temp;
            }

            for (int i = 0; i < input; i++)
            {
                textBox2.Text = string.Join(Environment.NewLine, fibonacci );
            }

            if (checkBox1.Checked)
            {
                float average = 0;

                for (int i = 0; i < input; i++)
                {
                    average+= fibonacci[i];
                }
                if(input != 0)
                {
                    average = average / input;
                    label1.Text += " " + average.ToString();
                }
                else
                {
                    label1.Text = "Average:";
                }
                
            }
        }
    }
}
