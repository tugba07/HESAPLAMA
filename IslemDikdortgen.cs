using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    internal class IslemDikdortgen:AbstrHesapla
    {
        
        public int Toplama(int a, int b)
        {
            return a + b;
        }
        public int Carp(int a, int b)
        {
            return a * b;
        }
        public float Boll(int a, int b)
        {
            return a/b;
        }
        public int Cikar(int a, int b)
        {
            return a-b;
        }
        public  float Hacim(int Tabanalan, int Yukseklik)
        {
            return Tabanalan * Yukseklik;
        }
        public override float Alan(int kenar1, int kenar2)
        {
                return kenar1 * kenar2;
        }
        public override void KenarSay(int KenarSayisi)
        {

            MessageBox.Show("Kenar Sayısı Dikdörtgen="+KenarSayisi); 
        }
      
       
        }
    }

