using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ooplab_memory
{
    public partial class GameForm : Form
    {
        public Timer timer;
        public int remainingTimeInSeconds = 10;

        private Random random;
        private int timeToDisplay = 5000; // 5 seconds
        private PictureBox pictureBox;
        private char[] symbols;
        private Point[] symbolLocations;
        public string UserName { get; private set; }
        public int Score { get; private set; }

        public GameForm(string userName)
        {
            UserName = userName;
            Text = userName;

            pictureBox = new PictureBox();
            pictureBox.Location = new Point(12, 12);
            pictureBox.Size = new Size(776, 317);
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Paint += PictureBox_Paint; // Ensure repainting
            random = new Random();
            symbols = new char[15];
            symbolLocations = new Point[30];

            Controls.Add(pictureBox);
            Controls.Add(txt_artı);
            Controls.Add(submitButton);

            Load += GameForm_Load;
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void DisplaySymbols()
        {
            char[] possibleSymbols = { '+', 'o', '*' };

            for (int i = 0; i < symbols.Length; i++)
            {
                symbols[i] = possibleSymbols[random.Next(possibleSymbols.Length)]; // Random symbol
                int x = random.Next(10, 700);
                int y = random.Next(10, 260);
                symbolLocations[i] = new Point(x, y);
            }
            pictureBox.Invalidate(); // This will call the PictureBox_Paint method
        }
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White); // Clear the PictureBox

            for (int i = 0; i < symbols.Length; i++)
            {
                g.DrawString(symbols[i].ToString(), new Font("Arial", 24), Brushes.Black, symbolLocations[i]);
            }
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            DisplaySymbols();
        }
       

        private void submitButton_Click(object sender, EventArgs e)
        {

            string[] guesses = { txt_artı.Text, txt_o.Text, txt_yıldız.Text };
            if (guesses.Length == 3)
            {
                try
                {
                    int[] guessNumbers = Array.ConvertAll(guesses, int.Parse);
                    Score = CalculateScore(guessNumbers);
                    Close();
                }
                catch
                {
                    MessageBox.Show("Please enter valid numbers separated by commas.");
                }
            }
            else
            {
                MessageBox.Show("Please enter exactly three numbers separated by commas.");
            }
        }
        private int CalculateScore(int[] guesses)
        {
            int score = 0;
            int count_artı = 0;
            int count_yıldız = 0;
            int count_o = 0;

            for(int i=0; i<guesses.Length; i++)
            {
                if (symbols[i] == '*')
                {
                    count_yıldız++;
                }
                else if(symbols[i] == 'o')
                {
                    count_o++;
                }
                else if (symbols[i] == '+')
                {
                    count_artı++;
                }
            }

            int tahmin_artı = count_artı - guesses[0];
            int tahmin_o = count_o - guesses[1];
            int tahmin_yıldız = count_yıldız - guesses[2];

            if(tahmin_artı < 0)
            {
                tahmin_artı *= -1;
            }

            if (tahmin_o < 0)
            {
                tahmin_o *= -1;
            }

            if (tahmin_yıldız < 0)
            {
                tahmin_yıldız *= -1;
            }

            score = tahmin_artı + tahmin_o + tahmin_yıldız;
            return score;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_artı_TextChanged(object sender, EventArgs e)
        {

        }


        // Timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Her tetiklendiğinde kalan süreyi bir saniye azalt
            remainingTimeInSeconds--;

            // Süre bittiğinde timer'ı durdur
            if (remainingTimeInSeconds <= 0)
            {
                timer.Stop();
                pictureBox.Hide();
            }
        }
    }
    
}
