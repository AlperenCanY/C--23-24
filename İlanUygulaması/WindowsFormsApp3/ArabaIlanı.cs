using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp3
{
    public class Araballanı : Bilan
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int ModelYili { get; set; }
        public string Renk { get; set; }
        public string Vites { get; set; }

        public override void IlanYazdir()
        {
            base.IlanYazdir();
            System.Windows.Forms.MessageBox.Show(string.Format("Marka: {0}\nModel: {1}\nModel Yılı: {2}\nRenk: {3}\nVites: {4}",Marka,Model,ModelYili,Renk,Vites));
        }
    }

}
