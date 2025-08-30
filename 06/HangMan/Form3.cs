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
    public partial class Form3 : Form
    {
        public string InputValue { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_guess_Click(object sender, EventArgs e)
        {
            InputValue = txt_guess.Text;
            this.Close();
        }
    }
}
