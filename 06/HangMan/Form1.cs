using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        public string temp1 {  get; set; }
        public string temp2 { get; set; }
        public string temp3 { get; set; }
        public string temp4 { get; set; }

        public Form1()
        {
            this.BackgroundImage = Properties.Resources.Cover;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = ColorTranslator.FromHtml("#F17724");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btn_ayarlar_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
            temp1 = form4.kategori;
            temp2 = form4.süre_durumu;
            temp3 = form4.ipucu_goster;
            temp4 = form4.kategori;
            this.Hide();
        }
    }
}