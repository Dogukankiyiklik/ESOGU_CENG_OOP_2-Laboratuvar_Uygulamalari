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
        List<RadioButton> radioButtons = new List<RadioButton>();
        List<string> orders = new List<string>();
        public Form1()
        {
            InitializeComponent();

            List<string> markalar = new List<string>();
            markalar.Add("Nike");
            markalar.Add("Adidas");
            markalar.Add("Puma");
            markalar.Add("Kinetix");
            foreach (string isim in markalar)
            {
                comboBox1.Items.Add(isim);
            }

            List<string> iller = new List<string>();
            iller.Add("Eskisehir");
            iller.Add("Ankara");
            foreach (string isim in iller)
            {
                comboBox2.Items.Add(isim);
            }

            radioButtons.Add(radioButton1);
            radioButtons.Add(radioButton2);
            radioButtons.Add(radioButton3);
            radioButtons.Add(radioButton4);
            radioButtons.Add(radioButton5);
            radioButtons.Add(radioButton6);
            radioButtons.Add(radioButton7);
            radioButtons.Add(radioButton8);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> esIlceler = new List<string>();
            esIlceler.Add("Tepebasi");
            esIlceler.Add("Odunpazari");
            esIlceler.Add("Cifteler");
            esIlceler.Add("Sivrihisar");

            List<string> ankIlceler = new List<string>();
            ankIlceler.Add("Kecioren");
            ankIlceler.Add("Etimesgut");
            ankIlceler.Add("Mamak");
            ankIlceler.Add("Cankaya");

            if (comboBox2.SelectedIndex == 0)
            {
                comboBox3.Items.Clear();
                foreach (string isim in esIlceler)
                {
                    comboBox3.Items.Add(isim);
                }
            }
            if (comboBox2.SelectedIndex == 1)
            {
                comboBox3.Items.Clear();
                foreach (string isim in ankIlceler)
                {
                    comboBox3.Items.Add(isim);
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad_soyad = textBox1.Text;
            string telefon_num = textBox2.Text;
            int check;

            if (int.TryParse(ad_soyad, out check))
            {
                MessageBox.Show("Invalid!");
            }

            if (!(int.TryParse(telefon_num, out check)))
            {
                MessageBox.Show("Invalid!");
            }

            string name = textBox1.Text;
            string phoneNumber = textBox2.Text;
            string selectedModel = comboBox1.SelectedItem?.ToString();
            string selectedCity = comboBox2.SelectedItem?.ToString();
            string selectedDistrict = comboBox3.SelectedItem?.ToString();
            string ayakkabi_numara = "";
            DateTime today = DateTime.Now;

            foreach (RadioButton btn in radioButtons)
            {
                if (btn.Checked)
                {
                    ayakkabi_numara = btn.Text;
                }
            }

            string order = $" {today} tarihli siparişiniz oluşturuldu. " +
                  $"İsim: {name}  " +
                  $"Numara: {phoneNumber}  " +
                  $"Marka: {selectedModel}  " +
                  $"Ayakkabı Numarası: {ayakkabi_numara}  " +
                  $"Şehir: {selectedCity}  " +
                  $"İlçe: {selectedDistrict}  ";

            orders.Add(order);

            listBox1.Items.Add(order);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = "Siparişim" + listBox1.SelectedItem.ToString();
        }
    }
}
