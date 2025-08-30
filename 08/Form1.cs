using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooplab_memory
{
    public partial class Form1 : Form
    {

        int user1_skor = -1;
        int user2_skor = -1;
        GameForm form1 = new GameForm("User1");
        GameForm form2 = new GameForm("User2");

        int count_skor_user1 = 0;
        int count_skor_user2 = 0;


        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            GameForm form1 = new GameForm("User1");
            GameForm form2 = new GameForm("User2");
            form1.FormClosed += GameForm_FormClosed;
            form2.FormClosed += GameForm_FormClosed;

            form1.Show();
            form2.Show();
        }

        private void UpdateScores(string userName, int score)
        {
            scoreLabel.Text += $"{userName}: {score} ";
        }
        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GameForm form = sender as GameForm;
            UpdateScores(form.UserName, form.Score);

            if (form.UserName == "User1")
            {
                user1_skor = form.Score;
            }
            else if (form.UserName == "User2")
            {
                user2_skor = form.Score;
            }

            if(user1_skor != -1 && user2_skor != -1)
            {
                if(user1_skor > user2_skor)
                {
                    count_skor_user2++;
                }
                else if (user1_skor < user2_skor)
                {
                    count_skor_user1++;
                }

                lbl_skor.Text = "Skor: " + "User1: " + count_skor_user1 + " User2: " + count_skor_user2;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
