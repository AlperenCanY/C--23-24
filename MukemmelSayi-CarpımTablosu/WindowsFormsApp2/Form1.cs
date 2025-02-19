using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
                int sayi = Convert.ToInt32(txtSayi.Text);

                int toplam = 0;

                for (int i = 1; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        toplam += i;
                    }
                }

                if (toplam == sayi)
                {
                    lblSonuc.Text = sayi + " Mükemmel bir sayıdır.";
                }
                else
                {
                    lblSonuc.Text = sayi + " Mükemmel bir sayı değildir.";
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Sayı Hatalı");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.BackColor = Color.Green;
            lstCarpimTablosu.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int carpim = i * j;
                    lstCarpimTablosu.Items.Add($"{i} x {j} = {carpim}");
                }
            }
        }
    }
}
