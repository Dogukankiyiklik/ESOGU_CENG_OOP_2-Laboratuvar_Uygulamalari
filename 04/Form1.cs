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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            int value = Convert.ToInt32(selected);

            DateTime currentTime = DateTime.Now;
            DateTime newTime = currentTime.AddHours(value);

            lbl_timer.Text = newTime.ToString("hh:mm:ss");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void lbl_timer_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = checkedListBox1.CheckedIndices.Count;

            if(count > 1)
            {
                btn_update.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int selectedIndex = checkedListBox1.SelectedIndex;
            string yeniMetin = textBox1.Text;
            checkedListBox1.Items[selectedIndex] = yeniMetin;

            comboBox1.Items[selectedIndex] = yeniMetin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
            comboBox1.Items.Add(textBox1.Text);
        }

        private void utc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            List<string> removing = new List<string>();

            int selectedCount = checkedListBox1.CheckedIndices.Count;
            for (int i = selectedCount - 1; i >= 0; i--)
            {
                int index = checkedListBox1.CheckedIndices[i];
                string deletedItem = checkedListBox1.Items[index].ToString();
    
                checkedListBox1.Items.RemoveAt(index);
      
                if (comboBox1.Items.Contains(deletedItem))
                {
                    comboBox1.Items.Remove(deletedItem);
                }
            }
        }
    }
}