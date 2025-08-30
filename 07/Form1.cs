using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Yazılan sayılar
        string işlem = "";

        List<string> history = new List<string>();
        List<string> history_answer = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sıfır_Click(object sender, EventArgs e)
        {
            işlem += "0";
            txt_işlem.Text = işlem;
        }

        private void btn_bir_Click(object sender, EventArgs e)
        {
            işlem += "1";
            txt_işlem.Text = işlem;
        }

        private void btn_iki_Click(object sender, EventArgs e)
        {
            işlem += "2";
            txt_işlem.Text = işlem;
        }

        private void btn_üç_Click(object sender, EventArgs e)
        {
            işlem += "3";
            txt_işlem.Text = işlem;
        }

        private void btn_dört_Click(object sender, EventArgs e)
        {
            işlem += "4";
            txt_işlem.Text = işlem;
        }

        private void btn_beş_Click(object sender, EventArgs e)
        {
            işlem += "5";
            txt_işlem.Text = işlem;
        }

        private void btn_altı_Click(object sender, EventArgs e)
        {
            işlem += "6";
            txt_işlem.Text = işlem;
        }

        private void btn_yedi_Click(object sender, EventArgs e)
        {
            işlem += "7";
            txt_işlem.Text = işlem;
        }

        private void btn_sekiz_Click(object sender, EventArgs e)
        {
            işlem += "8";
            txt_işlem.Text = işlem;
        }

        private void btn_dokuz_Click(object sender, EventArgs e)
        {
            işlem += "9";
            txt_işlem.Text = işlem;
        }

        private void btn_artı_Click(object sender, EventArgs e)
        {
            işlem += "+";
            txt_işlem.Text = işlem;
        }

        private void btn_eksi_Click(object sender, EventArgs e)
        {
            işlem += "-";
            txt_işlem.Text = işlem;
        }

        private void btn_çarpı_Click(object sender, EventArgs e)
        {
            işlem += "*";
            txt_işlem.Text = işlem;
        }

        private void btn_bölme_Click(object sender, EventArgs e)
        {
            işlem += "/";
            txt_işlem.Text = işlem;
        }

        private void btn_sol_parantez_Click(object sender, EventArgs e)
        {
            işlem += " (";
            txt_işlem.Text = işlem;
        }

        private void btn_sağ_parantez_Click(object sender, EventArgs e)
        {
            işlem += ") ";
            txt_işlem.Text = işlem;
        }

        private void btn_yüzde_Click(object sender, EventArgs e)
        {
            işlem += " % ";
            txt_işlem.Text = işlem;
        }

        private void btn_nokta_Click(object sender, EventArgs e)
        {
            işlem += ".";
            txt_işlem.Text = işlem;
        }

        private void btn_silme_Click(object sender, EventArgs e)
        {
            işlem = "";
            txt_işlem.Text = işlem;
        }

        private void btn_ln_Click(object sender, EventArgs e)
        {
            işlem += " ln(";
            txt_işlem.Text = işlem;
        }

        private void btn_üssü_Click(object sender, EventArgs e)
        {
            işlem += "^";
            txt_işlem.Text = işlem;
        }

        private void btn_eşittir_Click(object sender, EventArgs e)
        {
            history.Add(işlem);
            string[] words = işlem.Split(' ');

            for(int i=0; i<words.Length; i++)
            {
                // cos için
                if (words[i].Contains("cos"))
                {
                    string[] temp = words[i].Split('s');
                    string[] temp2 = temp[1].Split('(');
                    string[] temp3 = temp2[1].Split(')');

                    object computed = new DataTable().Compute(temp3[0], null);
                    double resultComputed = Math.Cos(Convert.ToDouble(computed));

                    words[i] = resultComputed.ToString();
                }

                // sin için
                if (words[i].Contains("sin"))
                {
                    string[] temp = words[i].Split('n');
                    string[] temp2 = temp[1].Split('(');
                    string[] temp3 = temp2[1].Split(')');

                    object computed = new DataTable().Compute(temp3[0], null);
                    double resultComputed = Math.Sin(Convert.ToDouble(computed));

                    words[i] = resultComputed.ToString();
                }

                // sin için
                if (words[i].Contains("ln"))
                {
                    string[] temp = words[i].Split('n');
                    string[] temp2 = temp[1].Split('(');
                    string[] temp3 = temp2[1].Split(')');

                    object computed = new DataTable().Compute(temp3[0], null);
                    double resultComputed = Math.Log(Convert.ToDouble(computed), 2.71);

                    words[i] = resultComputed.ToString();
                }

                // tan için
                if (words[i].Contains("tan"))
                {
                    string[] temp = words[i].Split('n');
                    string[] temp2 = temp[1].Split('(');
                    string[] temp3 = temp2[1].Split(')');

                    object computed = new DataTable().Compute(temp3[0], null);
                    double resultComputed = Math.Tan(Convert.ToDouble(computed));

                    words[i] = resultComputed.ToString();
                }

                // log için
                if (words[i].Contains("log"))
                {
                    string[] temp = words[i].Split('g');
                    string[] temp2 = temp[1].Split('(');
                    string[] temp3 = temp2[1].Split(')');

                    object computed = new DataTable().Compute(temp3[0], null);
                    double resultComputed = Math.Log(Convert.ToDouble(computed), 10);

                    words[i] = resultComputed.ToString();
                }

                // karekök için
                if (words[i].Contains("√"))
                {
                    string[] temp = words[i].Split('√');
                    string[] temp2 = temp[1].Split('(');
                    string[] temp3 = temp2[1].Split(')');

                    object computed = new DataTable().Compute(temp3[0], null);
                    double resultComputed = Math.Sqrt(Convert.ToDouble(computed));

                    words[i] = resultComputed.ToString();
                }

                // 10 üssü için
                if (words[i].Contains("10^"))
                {
                    string[] temp = words[i].Split('^');
                    string[] temp2 = temp[1].Split('(');
                    string[] temp3 = temp2[1].Split(')');

                    object computed = new DataTable().Compute(temp3[0], null);
                    double resultComputed = Math.Pow(10,Convert.ToDouble(computed));

                    words[i] = resultComputed.ToString();
                }

                // üssü için
                if (words[i].Contains("^"))
                {
                    string[] temp = words[i].Split('^');

                    double resultComputed = Math.Pow(Convert.ToDouble(temp[0]), Convert.ToDouble(temp[1]));
                    words[i] = resultComputed.ToString();
                }
            }

            string birlestirilmis = "";
            for (int i = 0; i < words.Length; i++)
            {
                birlestirilmis += words[i];
            }
            birlestirilmis = birlestirilmis.Replace(",", ".");
            object computed_new = new DataTable().Compute(birlestirilmis, null);
            lbl_sonuç.Text = computed_new.ToString();

            history_answer.Add(computed_new.ToString());
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            işlem += " log(";
            txt_işlem.Text = işlem;
        }

        private void btn_karekök_Click(object sender, EventArgs e)
        {
            işlem += " √(";
            txt_işlem.Text = işlem;
        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            işlem += " sin(";
            txt_işlem.Text = işlem;
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            işlem += " cos(";
            txt_işlem.Text = işlem;
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            işlem += " tan(";
            txt_işlem.Text = işlem;
        }

        private void btn_pi_Click(object sender, EventArgs e)
        {
            işlem += "3.14";
            txt_işlem.Text = işlem;
        }

        private void btn_on_üssü_Click(object sender, EventArgs e)
        {
            işlem += " 10^(";
            txt_işlem.Text = işlem;
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            işlem += "2.71";
            txt_işlem.Text = işlem;
        }

        private void btn_faktöriyel_Click(object sender, EventArgs e)
        {
            işlem += "!";
            txt_işlem.Text = işlem;
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach(string var in history)
            {
                lbl_history.Text += Environment.NewLine;
                lbl_history.Text += var + " = " + history_answer[0].ToString();
                lbl_history.Text += Environment.NewLine;
                index++;
            }
            history.Clear();
            history_answer.Clear();
        }

    }
}
