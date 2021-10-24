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
    public partial class MukemmelSayi : Form
    {
        public MukemmelSayi()
        {
            InitializeComponent();
        }

        private void MukemmelSayi_Load(object sender, EventArgs e)
        {

        }

        int baslangic = 0;
        int bitis = 0;
        int muhtesemSayi = 0;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (tbxBaslangic.Text != "" || tbxBitis.Text != "")
            {
                baslangic = Convert.ToInt32(tbxBaslangic.Text);
                bitis = Convert.ToInt32(tbxBitis.Text);
                lBoxSayilar.Items.Clear();

                if (bitis > 0)
                {
                    if (baslangic >= 0)
                    {
                        for (int i = baslangic; i < bitis; i++) //Başlangıç Bitiş Arasındaki Sayılar
                        {
                            muhtesemSayi = 0;
                            for (int bolenAday = 1; bolenAday < i; bolenAday++) //Bölen Olabilecek Sayılar
                            {
                                if (i % bolenAday == 0)
                                {
                                    muhtesemSayi += bolenAday;
                                }
                            }

                            if (muhtesemSayi == i)
                            {
                                lBoxSayilar.Items.Add(muhtesemSayi);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Başlangıç Değeri Sıfırdan Küçük Olamaz!");
                    }
                }
                else
                {
                    MessageBox.Show("Bitiş Değeri Sıfırdan Küçük veya Eşit Olamaz!");
                }

            }
            else
            {
                MessageBox.Show("Tüm Boşlukları Doldurunuz!");
            }
            Temizle();
        }

        private void Temizle()
        {
            tbxBaslangic.Text = "";
            tbxBitis.Text = "";
        }
    }
}
