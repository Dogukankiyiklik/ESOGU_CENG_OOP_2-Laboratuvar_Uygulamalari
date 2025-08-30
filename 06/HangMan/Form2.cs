using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HangMan
{
    public partial class Form2 : Form
    {
        public Timer timer;
        public int remainingTimeInSeconds = 10; 
        // Class for game variables
        public class kelime_ipucu
        {
            public Dictionary<int, string> kelimeler = new Dictionary<int, string>();
            public Dictionary<int, string> ipuclari = new Dictionary<int, string>();
            public string kelime;
            public string ipucu;
            public int random_sayi;
            public void Main_Start()
            {

                kelimeler.Add(0, "gül");
                kelimeler.Add(1, "sunflower");
                kelimeler.Add(2, "bougainvillea");

                kelimeler.Add(3, "cat");
                kelimeler.Add(4, "leopard");
                kelimeler.Add(5, "hummingbird");

                kelimeler.Add(6, "phone"); 
                kelimeler.Add(7, "internet");
                kelimeler.Add(8, "headphones");

                ipuclari.Add(0, "flower type");
                ipuclari.Add(1, "garden flower");
                ipuclari.Add(2, "found in deserts");

                ipuclari.Add(3, "Long-necked");
                ipuclari.Add(4, "Small reptile");
                ipuclari.Add(5, "big cat");

                ipuclari.Add(6, "Automatic systems");
                ipuclari.Add(7, "Information network");
                ipuclari.Add(8, "Communication device");
            }

            public void random_sayi_uretme()
            {
                Random rnd = new Random();
                random_sayi = rnd.Next(0, kelimeler.Count());
            }

            public void kelime_start()
            {
                kelime = kelimeler[random_sayi];
            }

            public void ipucu_start()
            {
                ipucu = ipuclari[random_sayi];
            }
        }

        // global variables
        kelime_ipucu game = new kelime_ipucu();
        string harf;
        int puan;
        int count_hata = 0;
        HashSet<string> hatalar = new HashSet<string>();
        HashSet<string> dogrular = new HashSet<string>();


        string rastgele_kelime;

        List<string> tercihler = new List<string>();

        string oyun_kategori;
        string oyun_seviye;
        string oyun_sure;
        string oyun_ipucu;

        public Form2()
        {
            InitializeComponent();

            // initialize
            game.Main_Start();
            game.random_sayi_uretme();
            game.kelime_start();
            game.ipucu_start();

            Form4 form4 = new Form4();
            form4.ShowDialog();
            form4.Hide();

            tercihler = new List<string>();
            tercihler = form4.strings;

            oyun_kategori = tercihler[0];
            oyun_seviye = tercihler[1];
            oyun_sure = tercihler[2]; ;
            oyun_ipucu = tercihler[3]; ;


            lbl_tercih.Text = "TERCİHLER: " + oyun_kategori + "," + oyun_seviye + "," + oyun_sure + "," + oyun_ipucu;

            if(oyun_ipucu == "Hayır")
            {
                btn_ipucu.Hide();
            }

            kelime_belirle(oyun_kategori, oyun_seviye);

            string temp_kelime = rastgele_kelime;
            string temp_ipucu = game.ipucu;
            int lenght_string = temp_kelime.Length;

            for (int i = 0; i < lenght_string; i++)
            {
                lbl_kelime.Text += "_" + " ";
            }

            lbl_kelimeUzunlugu.Text += lenght_string.ToString();

            if(!(oyun_sure == "Süresiz"))
            {
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                timer.Start();
                UpdateLabel();
            }
            else
            {
                label2.Text = "Süre: Süresiz";
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Her tetiklendiğinde kalan süreyi bir saniye azalt
            remainingTimeInSeconds--;

            // Label'i güncelle
            UpdateLabel();

            // Süre bittiğinde timer'ı durdur
            if (remainingTimeInSeconds <= 0)
            {
                timer.Stop();
                MessageBox.Show("Süre doldu!");
                this.BackColor = Color.Red;
                DialogResult lose = MessageBox.Show("Kaybettiniz!");
                if (lose == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void UpdateLabel()
        {
            // Kalan süreyi label'e güncelle
            int minutes = remainingTimeInSeconds / 60;
            int seconds = remainingTimeInSeconds % 60;
            label2.Text = $"Kalan Süre: {minutes:00}:{seconds:00}";
        }

        // letter control
        private void txt_letter_guess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(txt_letter_guess.Text) && !(txt_letter_guess.Text.Length > 1))
                {
                    harf = txt_letter_guess.Text;
                    oyun(sender, e);
                    txt_letter_guess.Text = "";
                }
            }
        }
        private void oyun(object sender, EventArgs e)
        {
            string game_kelime = rastgele_kelime;
            string game_ipucu = game.ipucu;
            int game_lenght = rastgele_kelime.Length;
            int count = 0;
            string kelime_label = lbl_kelime.Text;
            char[] charArray = lbl_kelime.Text.ToCharArray();

            for (int i=0; i<game_lenght; i++) 
            {
                if(game_kelime[i].ToString() == harf)
                {
                    count++;
                }
            }

            if(count == 0)
            {
                if(lbl_yanlışTahminler.Text == "" && hatalar.Contains(harf))
                {
                    lbl_yanlışTahminler.Text = harf;
                }
                else
                {
                    if (!hatalar.Contains(harf)) 
                    { 
                        lbl_yanlışTahminler.Text += harf + ","; 
                    }
                }

                puan -= 10;
                lbl_puan.Text = "Puan: " + puan.ToString();
                hatalar.Add(harf);

                count_hata++;
                // Lose Statement
                if (count_hata == 9)
                {
                    this.BackColor = Color.Red;
                    DialogResult lose = MessageBox.Show("Kaybettiniz!");
                    if(lose == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                string jpeg_source = "man_" + $"{count_hata}";
                pictureBox1.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(jpeg_source);
            }

            else
            {
                if (!dogrular.Contains(harf))
                {
                    puan += count * 10;
                }
                dogrular.Add(harf);

                char[] charArrayHarf = harf.ToCharArray();
                int charArrayIndex = 1;

                for (int i = 0; i < game_lenght; i++, charArrayIndex+=2)
                {
                    if (game_kelime[i].ToString() == harf)
                    {
                        charArray[charArrayIndex] = charArrayHarf[0];
                    }
                }

                lbl_kelime.Text = new string(charArray);
                lbl_puan.Text = "Puan: " + puan.ToString(); 

                // Win Statement
                if(lbl_kelime.Text.Replace(" ", "") == game_kelime)
                {
                    this.BackColor = Color.Green;
                    DialogResult won = MessageBox.Show("Kazandınız!");
                    if(won == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }
        private void btn_ipucu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(game.ipucu, "Hint");
        }
        private void btn_tahmin_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            string guess = form3.InputValue;

            if( guess == rastgele_kelime)
            {
                this.BackColor = Color.Green;
                DialogResult guess_right = MessageBox.Show("Tahmin Doğru. Kazandınız!");
                if (guess_right == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Tahmin Yanlış!");
                puan -= 50;
                lbl_puan.Text = "Puan: " + puan.ToString();
            }
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] != null)
            {
                Application.OpenForms["Form1"].Close();
            }
        }

        private void btn_bitir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış Yapmak İstiyor musunuz?", "Onay", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void lbl_tercih_Click(object sender, EventArgs e)
        {

        }

        void kelime_belirle(string kat, string seviye)
        {
            if(kat == "Bitkiler")
            {
                if(seviye == "Kolay")
                {
                    rastgele_kelime = game.kelimeler[0];
                }

                else if (seviye == "Orta")
                {
                    rastgele_kelime = game.kelimeler[1];
                }

                else if (seviye == "Zor")
                {
                    rastgele_kelime = game.kelimeler[2];
                }
            }

            else if(kat == "Hayvanlar")
            {
                if (seviye == "Kolay")
                {
                    rastgele_kelime = game.kelimeler[3];
                }

                else if (seviye == "Orta")
                {
                    rastgele_kelime = game.kelimeler[4];
                }

                else if (seviye == "Zor")
                {
                    rastgele_kelime = game.kelimeler[5];
                }
            }

           else if(kat == "Teknoloji")
            {
                if (seviye == "Kolay")
                {
                    rastgele_kelime = game.kelimeler[6];
                }

                else if (seviye == "Orta")
                {
                    rastgele_kelime = game.kelimeler[7];
                }

                else if (seviye == "Zor")
                {
                    rastgele_kelime = game.kelimeler[8];
                }
            }
        }
    }
}
