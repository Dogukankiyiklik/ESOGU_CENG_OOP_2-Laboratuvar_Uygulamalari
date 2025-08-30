namespace HangMan
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radio_btn_suresiz = new System.Windows.Forms.RadioButton();
            this.radion_btn_sureli = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_btn_kolay = new System.Windows.Forms.RadioButton();
            this.radio_btn_orta = new System.Windows.Forms.RadioButton();
            this.radio_btn_zor = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radio_btn_hayir = new System.Windows.Forms.RadioButton();
            this.radio_btn_evet = new System.Windows.Forms.RadioButton();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(454, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Süre Durumu";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bitkiler",
            "Hayvanlar",
            "Teknoloji"});
            this.comboBox1.Location = new System.Drawing.Point(51, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // radio_btn_suresiz
            // 
            this.radio_btn_suresiz.AutoSize = true;
            this.radio_btn_suresiz.Location = new System.Drawing.Point(6, 10);
            this.radio_btn_suresiz.Name = "radio_btn_suresiz";
            this.radio_btn_suresiz.Size = new System.Drawing.Size(72, 20);
            this.radio_btn_suresiz.TabIndex = 3;
            this.radio_btn_suresiz.TabStop = true;
            this.radio_btn_suresiz.Text = "Süresiz";
            this.radio_btn_suresiz.UseVisualStyleBackColor = true;
            // 
            // radion_btn_sureli
            // 
            this.radion_btn_sureli.AutoSize = true;
            this.radion_btn_sureli.Location = new System.Drawing.Point(6, 36);
            this.radion_btn_sureli.Name = "radion_btn_sureli";
            this.radion_btn_sureli.Size = new System.Drawing.Size(104, 20);
            this.radion_btn_sureli.TabIndex = 4;
            this.radion_btn_sureli.TabStop = true;
            this.radion_btn_sureli.Text = "Süreli (30 sn)";
            this.radion_btn_sureli.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_btn_suresiz);
            this.groupBox1.Controls.Add(this.radion_btn_sureli);
            this.groupBox1.Location = new System.Drawing.Point(459, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seviye Seç";
            // 
            // radio_btn_kolay
            // 
            this.radio_btn_kolay.AutoSize = true;
            this.radio_btn_kolay.Location = new System.Drawing.Point(6, 21);
            this.radio_btn_kolay.Name = "radio_btn_kolay";
            this.radio_btn_kolay.Size = new System.Drawing.Size(62, 20);
            this.radio_btn_kolay.TabIndex = 7;
            this.radio_btn_kolay.TabStop = true;
            this.radio_btn_kolay.Text = "Kolay";
            this.radio_btn_kolay.UseVisualStyleBackColor = true;
            // 
            // radio_btn_orta
            // 
            this.radio_btn_orta.AutoSize = true;
            this.radio_btn_orta.Location = new System.Drawing.Point(6, 56);
            this.radio_btn_orta.Name = "radio_btn_orta";
            this.radio_btn_orta.Size = new System.Drawing.Size(53, 20);
            this.radio_btn_orta.TabIndex = 8;
            this.radio_btn_orta.TabStop = true;
            this.radio_btn_orta.Text = "Orta";
            this.radio_btn_orta.UseVisualStyleBackColor = true;
            // 
            // radio_btn_zor
            // 
            this.radio_btn_zor.AutoSize = true;
            this.radio_btn_zor.Location = new System.Drawing.Point(6, 93);
            this.radio_btn_zor.Name = "radio_btn_zor";
            this.radio_btn_zor.Size = new System.Drawing.Size(48, 20);
            this.radio_btn_zor.TabIndex = 9;
            this.radio_btn_zor.TabStop = true;
            this.radio_btn_zor.Text = "Zor";
            this.radio_btn_zor.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "? 3-6 Harften oluşan kelimeler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "? 7-10 Harften oluşan kelimeler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "? 11 Harften fazla kelimeler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_btn_kolay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.radio_btn_orta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.radio_btn_zor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(51, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 123);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(460, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "İpucu Göster";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radio_btn_hayir);
            this.groupBox3.Controls.Add(this.radio_btn_evet);
            this.groupBox3.Location = new System.Drawing.Point(459, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 101);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // radio_btn_hayir
            // 
            this.radio_btn_hayir.AutoSize = true;
            this.radio_btn_hayir.Location = new System.Drawing.Point(9, 55);
            this.radio_btn_hayir.Name = "radio_btn_hayir";
            this.radio_btn_hayir.Size = new System.Drawing.Size(60, 20);
            this.radio_btn_hayir.TabIndex = 1;
            this.radio_btn_hayir.TabStop = true;
            this.radio_btn_hayir.Text = "Hayır";
            this.radio_btn_hayir.UseVisualStyleBackColor = true;
            // 
            // radio_btn_evet
            // 
            this.radio_btn_evet.AutoSize = true;
            this.radio_btn_evet.Location = new System.Drawing.Point(6, 21);
            this.radio_btn_evet.Name = "radio_btn_evet";
            this.radio_btn_evet.Size = new System.Drawing.Size(55, 20);
            this.radio_btn_evet.TabIndex = 0;
            this.radio_btn_evet.TabStop = true;
            this.radio_btn_evet.Text = "Evet";
            this.radio_btn_evet.UseVisualStyleBackColor = true;
            this.radio_btn_evet.UseWaitCursor = true;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(576, 385);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(195, 37);
            this.btn_kaydet.TabIndex = 16;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radio_btn_suresiz;
        private System.Windows.Forms.RadioButton radion_btn_sureli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio_btn_kolay;
        private System.Windows.Forms.RadioButton radio_btn_orta;
        private System.Windows.Forms.RadioButton radio_btn_zor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radio_btn_hayir;
        private System.Windows.Forms.RadioButton radio_btn_evet;
        private System.Windows.Forms.Button btn_kaydet;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox3;
    }
}