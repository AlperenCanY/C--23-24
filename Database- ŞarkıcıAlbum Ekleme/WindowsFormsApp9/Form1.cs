using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DatabaseP dp=new DatabaseP();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            dp.baglanti();
            string aekle= @"INSERT INTO SanatcilarS (Ad, Soyad, DogumTarihi) VALUES (@Ad, @Soyad, @DogumTarihi)";
            SqlCommand snt = new SqlCommand(aekle, dp.baglanti());

            snt.Parameters.AddWithValue("@Ad", txtSIsim.Text);
            snt.Parameters.AddWithValue("@Soyad", txtSoyisim.Text);
            snt.Parameters.AddWithValue("@DogumTarihi", txtDgm.Text);

            if (snt.ExecuteNonQuery() > 0)
            { MessageBox.Show("Sanatçı Eklendi!"); }
            else { MessageBox.Show("Sanatçı Eklenemedi");}
            dp.baglanti().Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dp.baglanti();
            string arananSanatci = txtAIsım.Text;
            string ArananS = txtASoyısım.Text;
            string ara = "SELECT * FROM SanatcilarS WHERE Ad = @arananSanatci and Soyad= @ArananS";

            SqlCommand arn = new SqlCommand(ara, dp.baglanti());
            arn.Parameters.AddWithValue("@arananSanatci", arananSanatci);
            arn.Parameters.AddWithValue("@ArananS", ArananS);

            SqlDataReader reader = arn.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    MessageBox.Show($"Sanatçı Bulundu!\n\n ID: {reader["sanatciID"]}\nAd: {reader["Ad"]}\nSoyad: {reader["Soyad"]}\nYaşı: {reader["Yas"]}\nDoğum Tarihi: {reader["DogumTarihi"]}");

                }

            }
            else
            { MessageBox.Show("Bu Bilgiler İle Eşleşen Sanatçı Bulunamadı"); }
            dp.baglanti().Close();
            
        
        }

        private void btnIDAra_Click(object sender, EventArgs e)
        {
            dp.baglanti();
            string ArananID = txtAID.Text;
            string ara = "SELECT * FROM SanatcilarS WHERE sanatciID = @ArananID";
            SqlCommand arn = new SqlCommand(ara, dp.baglanti());
            arn.Parameters.AddWithValue("@arananID", ArananID);

            SqlDataReader reader = arn.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    MessageBox.Show($"Sanatçı Bulundu!\nAd: {reader["Ad"]}\nSoyad: {reader["Soyad"]}\nYaşı: {reader["Yas"]}\nDoğum Tarihi: {reader["DogumTarihi"]}");

                }

            }
            else
            { MessageBox.Show("Bu Bilgiler İle Eşleşen Sanatçı Bulunamadı");}


            dp.baglanti().Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dp.baglanti();
            string guncID = txtGID.Text;
            string guncAD = txtGIsım.Text;
            string guncSoyad = txtGSoyad.Text;
            string guncTarih = txtDogumTarihi.Text;
            string ara = "Update SanatcilarS Set Ad=@guncAD,Soyad=@guncSoyad,DogumTarihi=@guncTarih Where sanatciID=@guncID";
            SqlCommand arn = new SqlCommand(ara, dp.baglanti());
            if (!string.IsNullOrEmpty(guncAD) && !string.IsNullOrEmpty(guncSoyad) && !string.IsNullOrEmpty(guncTarih))
            {

                arn.Parameters.AddWithValue("@guncID", guncID);
                arn.Parameters.AddWithValue("@guncAD", guncAD);
                arn.Parameters.AddWithValue("@guncSoyad", guncSoyad);
                arn.Parameters.AddWithValue("@guncTarih", guncTarih);

            }
            else { MessageBox.Show("TextBoxlar Dolu Olmalıdır!");}

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dp.baglanti();
            string silID = txtSil.Text;
            string sil = "Delete SanatcilarS Where sanatciID=@silID";
            SqlCommand arn = new SqlCommand(sil, dp.baglanti());

            arn.Parameters.AddWithValue("@silID", silID);
            if (arn.ExecuteNonQuery() > 0) { MessageBox.Show("Silindi"); }
            else { MessageBox.Show("Başarısız"); dp.baglanti().Close(); }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lbSanatci.Items.Clear();
            string listele = "Select * from SanatcilarS";
            SqlCommand arn = new SqlCommand(listele, dp.baglanti());
            SqlDataReader rdd = arn.ExecuteReader();
            while (rdd.Read())
            {
                lbSanatci.Items.Add(string.Format("Adı: {0} {1} - Yaşı: {2} - Doğum Tarihi: {3} ", rdd["Ad"], rdd["Soyad"], rdd["Yas"], rdd["DogumTarihi"]));
            
            }
        }
    }
}
