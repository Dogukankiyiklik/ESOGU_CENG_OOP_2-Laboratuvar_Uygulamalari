namespace ooplab_memory
{
    partial class GameForm
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
            this.txt_artı = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.txt_yıldız = new System.Windows.Forms.TextBox();
            this.txt_o = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_artı
            // 
            this.txt_artı.Location = new System.Drawing.Point(215, 461);
            this.txt_artı.Margin = new System.Windows.Forms.Padding(4);
            this.txt_artı.Name = "txt_artı";
            this.txt_artı.Size = new System.Drawing.Size(132, 22);
            this.txt_artı.TabIndex = 1;
            this.txt_artı.TextChanged += new System.EventHandler(this.txt_artı_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.submitButton.Location = new System.Drawing.Point(330, 502);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(279, 28);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // txt_yıldız
            // 
            this.txt_yıldız.Location = new System.Drawing.Point(422, 461);
            this.txt_yıldız.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yıldız.Name = "txt_yıldız";
            this.txt_yıldız.Size = new System.Drawing.Size(132, 22);
            this.txt_yıldız.TabIndex = 3;
            // 
            // txt_o
            // 
            this.txt_o.Location = new System.Drawing.Point(594, 461);
            this.txt_o.Margin = new System.Windows.Forms.Padding(4);
            this.txt_o.Name = "txt_o";
            this.txt_o.Size = new System.Drawing.Size(132, 22);
            this.txt_o.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(211, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(593, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(418, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "o";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_o);
            this.Controls.Add(this.txt_yıldız);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.txt_artı);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_artı;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox txt_yıldız;
        private System.Windows.Forms.TextBox txt_o;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}