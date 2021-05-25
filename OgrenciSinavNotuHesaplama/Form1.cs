using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciSinavNotuHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2, proje;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            s1 = Convert.ToInt16(textBox3.Text);
            s2 = Convert.ToInt16(textBox4.Text);
            proje = Convert.ToInt16(textBox5.Text);
            ortalama = (s1 + s2 + proje) / 3;
            listBox1.Items.Add
                (
                "Ad = " + ad +
                " Soyad = " + soyad+
                " Sınav 1 = " + s1 +
                " Sınav 2 = " + s2 +
                " Proje = " + proje +
                " Ortalama = " + ortalama
                );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string urunadi;
            urunadi = textBox6.Text;
            double urunfiyati, kdv1, kdv8, kdv18;
            urunfiyati = Convert.ToDouble(textBox7.Text);
            kdv1 = urunfiyati +(urunfiyati * 0.01);
            kdv8 = urunfiyati + (urunfiyati * 0.08);
            kdv18 = urunfiyati + (urunfiyati * 0.18);
            listBox2.Items.Add(
                "Ürünün Adı = " + urunadi +
                "Ürünün Fiyatı = " + urunfiyati+
                "%1 Kdvli   = " + kdv1 +
                "%8 Kdvli = " + kdv8 +
                "%18 Kdvli = " + kdv18
                );
        }
    }
}
