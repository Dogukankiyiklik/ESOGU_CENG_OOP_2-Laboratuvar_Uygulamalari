namespace HangMan
{
    partial class Form3
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
            this.txt_guess = new System.Windows.Forms.TextBox();
            this.btn_guess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_guess
            // 
            this.txt_guess.Location = new System.Drawing.Point(208, 137);
            this.txt_guess.Name = "txt_guess";
            this.txt_guess.Size = new System.Drawing.Size(373, 22);
            this.txt_guess.TabIndex = 0;
            // 
            // btn_guess
            // 
            this.btn_guess.Location = new System.Drawing.Point(208, 182);
            this.btn_guess.Name = "btn_guess";
            this.btn_guess.Size = new System.Drawing.Size(373, 23);
            this.btn_guess.TabIndex = 1;
            this.btn_guess.Text = "Tahmin";
            this.btn_guess.UseVisualStyleBackColor = true;
            this.btn_guess.Click += new System.EventHandler(this.btn_guess_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_guess);
            this.Controls.Add(this.txt_guess);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_guess;
        private System.Windows.Forms.Button btn_guess;
    }
}