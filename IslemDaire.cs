using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    internal class IslemDaire : AbstrHesapla
    {
        //abstruct classlarımızı override etmeliyiz
        private float PiSay = (314 / 100);
        public float Hacim(int Tabanalan, int Yukseklik)
        {
            return Tabanalan * Yukseklik;
        } 
        public override float Alan(int R,int value)
        { 
           return  PiSay * R*R;
        }
        public override void KenarSay(int KenarSayisi)
        {
            MessageBox.Show("Kenar Sayısı Daire" + this.KenarSayisi);
        }
    }
}
