using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
          
            
        }
        TxtDurum Durum = new TxtDurum();
        private void rbUcgen_CheckedChanged(object sender, EventArgs e)
        {
            txtYariCap.Enabled = false;
            txtValue1.Enabled = true;
            txtValue2.Enabled = false;
            txtYukseklik.Enabled = true;
         
        }
        private void rbDikdortgen_CheckedChanged(object sender, EventArgs e)
        {
            txtYariCap.Enabled = false;
            txtValue1.Enabled = true;
            txtValue2.Enabled = true;
            txtYukseklik.Enabled = false;
        }
        private void rbDaire_CheckedChanged(object sender, EventArgs e)
        {
            txtYariCap.Enabled = true;
            txtValue1.Enabled = false;
            txtValue2.Enabled = false;
            txtYukseklik.Enabled = false;
        }

        private void txtValue2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Durum.SayiKeyWord(e);
        }
        private void txtYariCap_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Durum.SayiKeyWord(e);
        }
        private void txtYukseklik_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Durum.SayiKeyWord(e);
        }
        private void txtValue1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Durum.SayiKeyWord(e);

        }
        private void txtValue3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Durum.SayiKeyWord(e);
        }
        private void txtValue4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Durum.SayiKeyWord(e);
        }
        private void txtYukseklik1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Durum.SayiKeyWord(e);


        }
        private void txtTabanAlan_KeyPress(object sender, KeyPressEventArgs e)
        {
            Durum.SayiKeyWord(e);
        }
        //Hacim Hesaplama private tanımladım bu metodum bu classdan başka yerde çağrılamaz
        private void Hacim()
        {
            IslemDikdortgen hesapla = new IslemDikdortgen();
            if (txtTabanAlan.Text != "" && txtYukseklik1.Text != "")
            {
                txtHacimSonuc.Text = hesapla.Hacim(Convert.ToInt32(txtTabanAlan.Text), Convert.ToInt32(txtYukseklik1.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Lütfe Taban Alan ve Yükseliği giriniz.");
            }
            Temizle();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
          Hacim();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            IslemDikdortgen hesapla = new IslemDikdortgen();
            if (txtValue3.Text != "" && txtValue4.Text != "")
            {
                if (rbToplama.Checked == true)
                {
                    lblSonuc.Text = hesapla.Toplama(Convert.ToInt32(txtValue3.Text), Convert.ToInt32(txtValue4.Text)).ToString();
                }
                else if (rbCarpma.Checked == true)
                {
                    lblSonuc.Text = hesapla.Carp(Convert.ToInt32(txtValue3.Text), Convert.ToInt32(txtValue4.Text)).ToString();
                }
                else if (rbBolme.Checked == true)
                {
                    lblSonuc.Text = hesapla.Boll(Convert.ToInt32(txtValue3.Text), Convert.ToInt32(txtValue4.Text)).ToString();
                }
                else{
                    lblSonuc.Text = hesapla.Cikar(Convert.ToInt32(txtValue3.Text), Convert.ToInt32(txtValue4.Text)).ToString();
                }
            }
            else
            {

                MessageBox.Show("Lütfe İlk Value Ve Son Value Giriniz.");
            }
            Temizle();
           
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (rbDikdortgen.Checked == true)
            {
                if (txtValue1.Text != "" && txtValue2.Text != "")
                {
                    IslemDikdortgen hesapla = new IslemDikdortgen();
                    txtAlanSonuc.Text = hesapla.Alan(Convert.ToInt32(txtValue1.Text), Convert.ToInt32(txtValue2.Text)).ToString();
                    hesapla.KenarSay(4);
                }
                else
                {
                    MessageBox.Show("Lütfe Kenar Değerlerinizi Giriniz.");
                }

            }
            else if (rbDaire.Checked == true)
            {
                if (txtYariCap.Text != "")
                {
                    IslemDaire hesaplama = new IslemDaire();
                    int value = 1;
                    txtAlanSonuc.Text = hesaplama.Alan(Convert.ToInt32(txtYariCap.Text), value).ToString();
                    hesaplama.KenarSay(0);
                }
                else
                {
                    MessageBox.Show("Lütfe Yarı Çap  Giriniz.");

                }
            }
            else if (rbUcgen.Checked == true)
            {
                if (txtValue1.Text != "" && txtYukseklik.Text != "")
                {
                    IslemUcgen hesaplama = new IslemUcgen();
                    txtAlanSonuc.Text = hesaplama.Alan(Convert.ToInt32(txtValue1.Text), Convert.ToInt32(txtYukseklik.Text)).ToString();
                    hesaplama.KenarSay(3);
                }
                else
                {
                    MessageBox.Show("Lütfe İlk Kenar Ve Yükseliği Giriniz.");
                }
            }
            else
            {
                MessageBox.Show("RadioButon Seçiniz.");
            }
            Temizle();
        }
        //yalnızca  bu class içinde kullanabilirim
        private void Temizle()
        {
            txtValue1.Text = "";
            txtValue2.Text = "";
            txtYariCap.Text = "";
            txtYukseklik.Text = "";
            txtYukseklik1.Text = "";
            txtTabanAlan.Text = "";
            txtValue3.Text = "";
            txtValue4.Text = "";

        }
       
        
        

       
  
     

    }
}
