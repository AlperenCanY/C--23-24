using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Araballanı arabaIlan = new Araballanı
                {
                    IlanBaslik = "Satılık Araba",
                    IlanAciklama = txtIlanAciklama.Text,
                    IletisimAd = txtAd.Text,
                    IletisimSoyad = txtSoyad.Text,
                    IletisimNo = txtTelefon.Text,
                    Marka = txtMarka.Text,
                    Model = txtModel.Text,
                    ModelYili = Convert.ToInt32(txtModelYili.Text),
                    Renk = txtRenk.Text,
                    Vites = txtVites.Text,
                };

                arabaIlan.IlanYazdir();
                arabaIlan.IlanYayindaMi = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Giriş Şekliniz Doğru değil");


            }
            





        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Evilanı evIlan = new Evilanı
                {
                    IlanBaslik = "Satılık Ev",
                    IlanAciklama = txtIlanAciklama.Text,
                    IletisimAd = txtAd.Text,
                    IletisimSoyad = txtSoyad.Text,
                    IletisimNo = txtTelefon.Text,
                    Adres = txtAdres.Text,
                    EvUretimYili = int.Parse(txtÜretimYili.Text),
                    OdaSayisi = int.Parse(txtOdaSayisi.Text),
                    IsinmaTipi = txtIsinmaTipi.Text,
                    AsansorVarMi = rbAsansör.Checked,

                    
                };

                evIlan.IlanYazdir();
                evIlan.IlanYayindaMi = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Evilanı evIlan = new Evilanı
            {
                IlanBaslik = "Satılık Ev",
                IlanAciklama = "Merkezi konumda, geniş ve ferah",
                IletisimAd = "Ayşe",
                IletisimSoyad = "Demir",
                IletisimNo = "555-555-5556",
                Adres = "İstanbul, Beşiktaş",
                EvUretimYili = 2010,
                OdaSayisi = 3,
                IsinmaTipi = "Kombi",
                AsansorVarMi = true
            };

            evIlan.IlanYazdir();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Araballanı arabaIlan = new Araballanı
            {
                IlanBaslik = "Satılık Araba",
                IlanAciklama = "Düşük km, bakımlı araba",
                IletisimAd = "Ahmet",
                IletisimSoyad = "Yılmaz",
                IletisimNo = "555-555-5555",
                Marka = "Toyota",
                Model = "Corolla",
                ModelYili = 2018,
                Renk = "Beyaz",
                Vites = "Otomatik"
            };

            arabaIlan.IlanYazdir();

        }

        private void cbİlan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbİlan.Checked = true) { Bilan ilan = new Bilan(); ilan.IlanYayindaMi = true; }
        }
    }
}
