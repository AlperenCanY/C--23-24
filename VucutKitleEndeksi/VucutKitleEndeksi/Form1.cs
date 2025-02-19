namespace VucutKitleEndeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo, boy, sonuc;
            kilo = Convert.ToDouble(txtKilo.Text);
            boy = Convert.ToDouble(txtBoy.Text);
            sonuc = kilo / (boy * boy);
            lblVki.Text = sonuc.ToString();

            if (sonuc <= 18.5)
            {
                this.BackColor = Color.MistyRose;
                lblDurum.Text = "Düþük Kilolu";


            }
            else if (sonuc <= 24.9)
            {
                this.BackColor = Color.Azure;
                lblDurum.Text = "Normal Kilolu";
            }
            else if (sonuc <= 29.9)
            {
                this.BackColor = Color.Bisque;
                lblDurum.Text = "Fazla Kilolu";
            }
            else if (sonuc <= 40)
            {
                this.BackColor = Color.BurlyWood;
                lblDurum.Text = "Obez";
            }
            else
            {
                this.BackColor = Color.DarkOrange;
                lblDurum.Text = "Aþýrý Obez";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}