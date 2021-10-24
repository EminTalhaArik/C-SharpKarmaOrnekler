
namespace RandomNumberExample
{
    partial class MukemmelSayi
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
            this.lBoxSayilar = new System.Windows.Forms.ListBox();
            this.tbxBaslangic = new System.Windows.Forms.TextBox();
            this.tbxBitis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBoxSayilar
            // 
            this.lBoxSayilar.FormattingEnabled = true;
            this.lBoxSayilar.ItemHeight = 16;
            this.lBoxSayilar.Location = new System.Drawing.Point(281, 26);
            this.lBoxSayilar.Name = "lBoxSayilar";
            this.lBoxSayilar.Size = new System.Drawing.Size(293, 196);
            this.lBoxSayilar.TabIndex = 0;
            // 
            // tbxBaslangic
            // 
            this.tbxBaslangic.Location = new System.Drawing.Point(114, 52);
            this.tbxBaslangic.Name = "tbxBaslangic";
            this.tbxBaslangic.Size = new System.Drawing.Size(161, 22);
            this.tbxBaslangic.TabIndex = 1;
            // 
            // tbxBitis
            // 
            this.tbxBitis.Location = new System.Drawing.Point(114, 80);
            this.tbxBitis.Name = "tbxBitis";
            this.tbxBitis.Size = new System.Drawing.Size(161, 22);
            this.tbxBitis.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Başlangıç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(185, 124);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(90, 44);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mükemmel Sayı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MukemmelSayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxBitis);
            this.Controls.Add(this.tbxBaslangic);
            this.Controls.Add(this.lBoxSayilar);
            this.Name = "MukemmelSayi";
            this.Text = "Mükemmel Sayi";
            this.Load += new System.EventHandler(this.MukemmelSayi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxSayilar;
        private System.Windows.Forms.TextBox tbxBaslangic;
        private System.Windows.Forms.TextBox tbxBitis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}