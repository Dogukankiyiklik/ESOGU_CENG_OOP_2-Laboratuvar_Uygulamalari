using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HangMan
{
    public partial class Form4 : Form
    {
        public string kategori { get; set; }
        public string seviye { get; set; }
        public string süre_durumu { get; set; }
        public string ipucu_goster { get; set; }

        public List<string> strings { get; set; }
        public Form4()
        {
            InitializeComponent();

            strings = new List<string>();

            radio_btn_kolay.Checked = true;
            radio_btn_suresiz.Checked = true;
            radio_btn_evet.Checked = true;
            comboBox1.SelectedIndex = 0;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kategori = comboBox1.SelectedItem.ToString();
            seviye = groupBox2.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked).Text;
            süre_durumu = groupBox1.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked).Text;
            ipucu_goster = groupBox3.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked).Text;

            strings.Add(kategori);
            strings.Add(seviye);
            strings.Add(süre_durumu);
            strings.Add(ipucu_goster);

            Form1 form = new Form1();
            form.Show();
            this.Close();

        }
    }
}
