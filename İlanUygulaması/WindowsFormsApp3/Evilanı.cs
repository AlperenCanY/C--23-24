using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp3
{
    internal class Evilanı:Bilan
    {
        public string Adres { get; set; }
        public int EvUretimYili { get; set; }
        public int OdaSayisi { get; set; }
        public string IsinmaTipi { get; set; }
        public bool AsansorVarMi { get; set; }

        public override void IlanYazdir()
        {
            base.IlanYazdir();
            System.Windows.Forms.MessageBox.Show(string.Format("Adres: {0}\nÜretim Yılı: {1}\nOda Sayısı: {2}\nIsınma Tipi: {3}\nAsansör: {4}\nEv Yaşı: {5} yıl",Adres, EvUretimYili, OdaSayisi, IsinmaTipi, (AsansorVarMi ? "Var" : "Yok"), EvYasiHesapla()));
        }

        public int EvYasiHesapla()
        {
            return DateTime.Now.Year - EvUretimYili;
        }
    }
}
