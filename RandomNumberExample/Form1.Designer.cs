
namespace RandomNumberExample
{
    partial class Form1
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
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAdet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBoxSayilar
            // 
            this.lBoxSayilar.FormattingEnabled = true;
            this.lBoxSayilar.ItemHeight = 16;
            this.lBoxSayilar.Location = new System.Drawing.Point(230, 11);
            this.lBoxSayilar.Name = "lBoxSayilar";
            this.lBoxSayilar.Size = new System.Drawing.Size(236, 388);
            this.lBoxSayilar.TabIndex = 0;
            // 
            // tbxBaslangic
            // 
            this.tbxBaslangic.Location = new System.Drawing.Point(95, 44);
            this.tbxBaslangic.Name = "tbxBaslangic";
            this.tbxBaslangic.Size = new System.Drawing.Size(119, 22);
            this.tbxBaslangic.TabIndex = 1;
            // 
            // tbxBitis
            // 
            this.tbxBitis.Location = new System.Drawing.Point(95, 84);
            this.tbxBitis.Name = "tbxBitis";
            this.tbxBitis.Size = new System.Drawing.Size(119, 22);
            this.tbxBitis.TabIndex = 2;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(22, 159);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(94, 37);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(130, 159);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(84, 37);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Başlangıç";
            // 
            // tbxAdet
            // 
            this.tbxAdet.Location = new System.Drawing.Point(95, 121);
            this.tbxAdet.Name = "tbxAdet";
            this.tbxAdet.Size = new System.Drawing.Size(119, 22);
            this.tbxAdet.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bitiş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adet";
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(83, 335);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(94, 37);
            this.btnIleri.TabIndex = 9;
            this.btnIleri.Text = "İleri";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 411);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.tbxBitis);
            this.Controls.Add(this.tbxBaslangic);
            this.Controls.Add(this.lBoxSayilar);
            this.Name = "Form1";
            this.Text = "Rastgele Sayı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxSayilar;
        private System.Windows.Forms.TextBox tbxBaslangic;
        private System.Windows.Forms.TextBox tbxBitis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIleri;
    }
}

