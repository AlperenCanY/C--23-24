using System;

namespace WindowsFormsApp3
{
    public class Bilan
    {
        public int IlanID { get; set; }
        public bool IlanYayindaMi { get; set; }
        public string IlanBaslik { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public int YayinSuresi { get; set; }
        public string IlanAciklama { get; set; }
        public string IletisimAd { get; set; }
        public string IletisimSoyad { get; set; }
        public string IletisimNo { get; set; }

        public Bilan()
        {
            IlanID = new Random().Next(1, 1001);
            EklenmeTarihi = DateTime.Now;
        }

        public virtual void IlanYazdir()
        {
            System.Windows.Forms.MessageBox.Show(string.Format("ID: {0}\nBaşlık: {1}\nEklenme Tarihi: {2}\nAçıklama: {3}\nİletişim: {4} {5} - {6}", IlanID, IlanBaslik, EklenmeTarihi, IlanAciklama, IletisimAd, IletisimSoyad, IletisimNo, IlanYayindaMi));
        }
        public void IlaniYayinaAlKaldır()
        {
            IlanYayindaMi = !IlanYayindaMi;
            System.Windows.Forms.MessageBox.Show(IlanYayindaMi ? "İlan yayına alındı." : "İlan kaldırıldı.");
        }
    }
}
