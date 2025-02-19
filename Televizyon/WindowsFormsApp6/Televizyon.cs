using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    internal class Televizyon : Televizyonlar
    {
        public int SesSeviyesi { get; set; }
        public int EkranBoyutu { get; set; }
        public string GoruntuTeknolojisi { get; set; }
        bool gucac = false;

        public int kanalsayisi { get; set; }

        public void televizyonkalites()
        { System.Windows.Forms.MessageBox.Show("Televizyon Kaliteee");}
    public virtual void GucAcKapat()
        {
            if (gucac == false)
            { gucac = true; }
            else if (gucac == true) { gucac = false; }
        }
        public void Artkanaldegistir()
        { kanalsayisi++; }
        public void Ekkanaldegistir()
        { kanalsayisi--; }
        public int Artskanaldegistirint(int artir)
        { return kanalsayisi += artir; }

        public virtual int sesseviyesioku()
        { return SesSeviyesi; }
        public void sesazalt()
        { SesSeviyesi--; }
        public void sesarttir()
        { SesSeviyesi++; }
    }
}
