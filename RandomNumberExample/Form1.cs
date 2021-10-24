using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int baslangic = 0;
        int adet = 0;
        int bitis = 0;
        int rastgeleSayi = 0;


        //Uygulamada istenilen adet bitis değerinden büyük olduğunda sonsuz döngüye giriyor.

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lBoxSayilar.Items.Clear();

            if (tbxBaslangic.Text != "" || tbxBitis.Text != "" || tbxAdet.Text != "")
            {
                baslangic = Convert.ToInt32(tbxBaslangic.Text);
                bitis = Convert.ToInt32(tbxBitis.Text);
                adet = Convert.ToInt32(tbxAdet.Text);

                if (adet >= 0)
                {
                    if (adet <= bitis - baslangic)
                    {
                        for (int i = 0; i < adet; i++)
                        {
                            rastgeleSayi = random.Next(baslangic, bitis);
                            if (!lBoxSayilar.Items.Contains(rastgeleSayi))
                            {
                                lBoxSayilar.Items.Add(rastgeleSayi);
                            }
                            else
                            {
                                bool kontrol = true;
                                for (; kontrol;)
                                {
                                    rastgeleSayi = random.Next(baslangic, bitis);

                                    if (!lBoxSayilar.Items.Contains(rastgeleSayi))
                                    {
                                        lBoxSayilar.Items.Add(rastgeleSayi);
                                        kontrol = false;
                                    }
                                }
                            }
                        }
                        lBoxSayilar.Sorted = true;
                    }
                    else
                    {
                        MessageBox.Show("İstenilen Adeti Küçültünüz!");
                    }
                }
                else
                {
                    MessageBox.Show("Adet sayısı sıfırdan küçük olamaz!");
                }
            }
            else
            {
                MessageBox.Show("Tüm Değerleri Giriniz!");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lBoxSayilar.Items.Clear();
            tbxAdet.Text = "";
            tbxBaslangic.Text = "";
            tbxBitis.Text = "";
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            MukemmelSayi mukemmelSayi = new MukemmelSayi();
            mukemmelSayi.Show();
            this.Hide();
        }
    }
}
