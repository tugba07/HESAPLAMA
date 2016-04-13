using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{   
      sealed class SealedSinif
    {
          //Kes değişkenimi sealeda tanımlayarak diğer classlara kapattım
           private SealedSinif(){ 
            IslemUcgen Islem = new IslemUcgen();   
            Islem.Kesir=2;
              }  
  }
     
    
}
