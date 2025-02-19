using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Properties;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Televizyon tv = new Televizyon();
        bool Guc = false;

        private void button1_Click(object sender, EventArgs e)
        {
            tv.GucAcKapat();
            


            if (Guc == false) { Guc = true; pictureBox1.Image = WindowsFormsApp6.Properties.Resources.y5ck2sbh9pw91; label1.Visible = true; label2.Visible = true; tv.kanalsayisi = tv.kanalsayisi; tv.SesSeviyesi = tv.SesSeviyesi; }
            else { pictureBox1.Image = null; Guc = false; label1.Visible = false; label2.Visible = false; }

            label1.Text = tv.kanalsayisi.ToString();
            label2.Text = tv.SesSeviyesi.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tv.kanalsayisi = 30;
            tv.SesSeviyesi = 30;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtArtirSay.Text =="")
                {
                    if (tv.kanalsayisi >= 100) { MessageBox.Show("Kanal Sayısı 100'den fazla olamaz"); }
                    else { tv.Artkanaldegistir(); }
                }
                else { int sayi = int.Parse(txtArtirSay.Text); if (tv.kanalsayisi + sayi > 100) { MessageBox.Show("Kanal Sayısı 100'den fazla olamaz"); } else { tv.Artskanaldegistirint(sayi); } }

                label1.Text = tv.kanalsayisi.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tv.kanalsayisi ==  1) { tv.kanalsayisi = 100; }
            else { tv.Ekkanaldegistir(); }
            label1.Text = tv.kanalsayisi.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tv.SesSeviyesi <=100 ) { tv.sesarttir(); }
            else { MessageBox.Show("Ses Seviyesi En fazla 100 Olabilir");}
            label2.Text = Convert.ToString(tv.sesseviyesioku());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tv.SesSeviyesi == 0) { MessageBox.Show("Ses Seviyesi En az 0 Olabilir");  }
            else { tv.sesazalt(); }
            label2.Text = Convert.ToString(tv.sesseviyesioku());
        }
    }
    }

