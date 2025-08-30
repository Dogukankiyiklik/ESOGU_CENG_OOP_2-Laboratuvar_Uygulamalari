namespace HangMan
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_letter_guess = new System.Windows.Forms.TextBox();
            this.lbl_yanlışTahminler = new System.Windows.Forms.Label();
            this.lbl_puan = new System.Windows.Forms.Label();
            this.lbl_kelimeUzunlugu = new System.Windows.Forms.Label();
            this.lbl_kelime = new System.Windows.Forms.Label();
            this.btn_ipucu = new System.Windows.Forms.Button();
            this.btn_bitir = new System.Windows.Forms.Button();
            this.btn_tahmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_tercih = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(530, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hangman";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_letter_guess);
            this.groupBox1.Controls.Add(this.lbl_yanlışTahminler);
            this.groupBox1.Controls.Add(this.lbl_puan);
            this.groupBox1.Controls.Add(this.lbl_kelimeUzunlugu);
            this.groupBox1.Controls.Add(this.lbl_kelime);
            this.groupBox1.Controls.Add(this.btn_ipucu);
            this.groupBox1.Controls.Add(this.btn_bitir);
            this.groupBox1.Controls.Add(this.btn_tahmin);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 408);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txt_letter_guess
            // 
            this.txt_letter_guess.Location = new System.Drawing.Point(12, 368);
            this.txt_letter_guess.Name = "txt_letter_guess";
            this.txt_letter_guess.Size = new System.Drawing.Size(82, 22);
            this.txt_letter_guess.TabIndex = 7;
            this.txt_letter_guess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_letter_guess_KeyDown);
            // 
            // lbl_yanlışTahminler
            // 
            this.lbl_yanlışTahminler.AutoSize = true;
            this.lbl_yanlışTahminler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yanlışTahminler.Location = new System.Drawing.Point(6, 269);
            this.lbl_yanlışTahminler.Name = "lbl_yanlışTahminler";
            this.lbl_yanlışTahminler.Size = new System.Drawing.Size(155, 20);
            this.lbl_yanlışTahminler.TabIndex = 6;
            this.lbl_yanlışTahminler.Text = "Yanlış Tahminler:";
            // 
            // lbl_puan
            // 
            this.lbl_puan.AutoSize = true;
            this.lbl_puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_puan.Location = new System.Drawing.Point(7, 309);
            this.lbl_puan.Name = "lbl_puan";
            this.lbl_puan.Size = new System.Drawing.Size(69, 25);
            this.lbl_puan.TabIndex = 5;
            this.lbl_puan.Text = "Puan:";
            // 
            // lbl_kelimeUzunlugu
            // 
            this.lbl_kelimeUzunlugu.AutoSize = true;
            this.lbl_kelimeUzunlugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kelimeUzunlugu.Location = new System.Drawing.Point(8, 229);
            this.lbl_kelimeUzunlugu.Name = "lbl_kelimeUzunlugu";
            this.lbl_kelimeUzunlugu.Size = new System.Drawing.Size(162, 20);
            this.lbl_kelimeUzunlugu.TabIndex = 4;
            this.lbl_kelimeUzunlugu.Text = "Kelime Uzunluğu: ";
            // 
            // lbl_kelime
            // 
            this.lbl_kelime.AutoSize = true;
            this.lbl_kelime.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_kelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kelime.Location = new System.Drawing.Point(22, 21);
            this.lbl_kelime.Name = "lbl_kelime";
            this.lbl_kelime.Size = new System.Drawing.Size(32, 46);
            this.lbl_kelime.TabIndex = 3;
            this.lbl_kelime.Text = " ";
            // 
            // btn_ipucu
            // 
            this.btn_ipucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ipucu.Location = new System.Drawing.Point(116, 359);
            this.btn_ipucu.Name = "btn_ipucu";
            this.btn_ipucu.Size = new System.Drawing.Size(100, 38);
            this.btn_ipucu.TabIndex = 2;
            this.btn_ipucu.Text = "İpucu?";
            this.btn_ipucu.UseVisualStyleBackColor = true;
            this.btn_ipucu.Click += new System.EventHandler(this.btn_ipucu_Click);
            // 
            // btn_bitir
            // 
            this.btn_bitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bitir.Location = new System.Drawing.Point(340, 359);
            this.btn_bitir.Name = "btn_bitir";
            this.btn_bitir.Size = new System.Drawing.Size(151, 38);
            this.btn_bitir.TabIndex = 1;
            this.btn_bitir.Text = "Oyunu Bitir";
            this.btn_bitir.UseVisualStyleBackColor = true;
            this.btn_bitir.Click += new System.EventHandler(this.btn_bitir_Click);
            // 
            // btn_tahmin
            // 
            this.btn_tahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tahmin.Location = new System.Drawing.Point(231, 359);
            this.btn_tahmin.Name = "btn_tahmin";
            this.btn_tahmin.Size = new System.Drawing.Size(103, 38);
            this.btn_tahmin.TabIndex = 0;
            this.btn_tahmin.Text = "Tahmin Et";
            this.btn_tahmin.UseVisualStyleBackColor = true;
            this.btn_tahmin.Click += new System.EventHandler(this.btn_tahmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HangMan.Properties.Resources.man_0;
            this.pictureBox1.Image = global::HangMan.Properties.Resources.man_0;
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(531, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 408);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lbl_tercih
            // 
            this.lbl_tercih.AutoSize = true;
            this.lbl_tercih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tercih.Location = new System.Drawing.Point(24, 90);
            this.lbl_tercih.Name = "lbl_tercih";
            this.lbl_tercih.Size = new System.Drawing.Size(106, 18);
            this.lbl_tercih.TabIndex = 3;
            this.lbl_tercih.Text = "TERCİHLER:";
            this.lbl_tercih.Click += new System.EventHandler(this.lbl_tercih_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Süre: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(896, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_tercih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_yanlışTahminler;
        private System.Windows.Forms.Label lbl_puan;
        private System.Windows.Forms.Label lbl_kelimeUzunlugu;
        private System.Windows.Forms.Label lbl_kelime;
        private System.Windows.Forms.Button btn_ipucu;
        private System.Windows.Forms.Button btn_bitir;
        private System.Windows.Forms.Button btn_tahmin;
        private System.Windows.Forms.TextBox txt_letter_guess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_tercih;
        private System.Windows.Forms.Label label2;
    }
}