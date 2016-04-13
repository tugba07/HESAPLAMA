using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    abstract class AbstrHesapla:Ihesap
    {   //Base class o
        //Abstruct classın en az 1 tane abstruct methodu olmalı
        //İnterfacimizin bütün methodlarını yazmalıyız 

        protected int KenarSayisi { set; get; }
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
        public abstract  float Alan(int kenar1, int kenar2);
        public  float Hacim(int Tabanalan, int Yukseklik) {
            return Tabanalan * Yukseklik;
        }
        public virtual void KenarSay(int KenarSayisi)
        {
            MessageBox.Show("Kenar Sayısı" + this.KenarSayisi);
        }
        protected virtual  void Hosgeldiniz()
        {
            MessageBox.Show("Hoşgeldiniz");
        }
       
      
    }
}
