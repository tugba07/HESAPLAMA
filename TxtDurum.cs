using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    class TxtDurum
    {
     //public class gibi Fakat Tek bir proje için geçerli
     internal void SayiKeyWord(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                    break;
                default:
                    e.Handled = true;
                    break;
            }
       
        }
   
    }
}
