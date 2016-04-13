using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    internal class IslemUcgen : AbstrHesapla
    {
        public int Kesir = 2;
        public  float Hacim(int Tabanalan, int Yukseklik)
        {  
            return Tabanalan * Yukseklik;
        }
        //Hacim override Ettim Çünkü Diğer alan bulma fonksyonumdan farklı
        public override float Alan(int kenar1, int Yukseklik)
        {   
            return kenar1* Yukseklik/Kesir;
           
        }
        public override void KenarSay(int KenarSayisi)
        {

            MessageBox.Show("Kenar Sayısı Üçgen=" +KenarSayisi);
        }
        //kullanıma kapattım bu metodumu sealed sayesinde 
        protected sealed override void Hosgeldiniz()
        {
            MessageBox.Show("Hoşgeldiniz");
        }
    }
}
