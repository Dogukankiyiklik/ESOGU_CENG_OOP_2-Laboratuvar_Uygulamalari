using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oopilabceas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ceaser_textbox.Visible = false;
            ceaser_label.Visible = false;
        }

        public static void Encipher(char[] input, int key, ref bool success, Label successLabel, out string encryptedMessage)
        {

            encryptedMessage = string.Empty;
            success = false;

            if (input.Length < 2)
            {
                success = false;
                successLabel.Text = "Failed";
                successLabel.BackColor = System.Drawing.Color.Red;
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                char encryptedchar = Cipher(ch, key);
                encryptedMessage += encryptedchar;

            }

            success = true;
            successLabel.BackColor = System.Drawing.Color.Green;
            successLabel.Text = "Success";

        }

        public static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
                return ch;

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ceaser_textbox.Visible = false;
            ceaser_label.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ceaser_textbox.Visible = true;
            ceaser_label.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string output = "";

            int ceaser = 2;

            bool success = true;

            if (radioButton1.Checked)
            {
                Encipher(input.ToCharArray(), ceaser, ref success, successLabel, out output);
                label3.Text = output;
            }

            if (radioButton2.Checked)
            {

                if (ceaser_textbox.Text == "")
                {
                    ceaser = 1;
                }
                else
                {

                    ceaser = Convert.ToInt32(ceaser_textbox.Text);
                }
                Encipher(input.ToCharArray(), ceaser, ref success, successLabel, out output);
                label3.Text = output;





            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

