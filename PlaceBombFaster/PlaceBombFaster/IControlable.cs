using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace PlaceBombFaster
{
    
    public interface IControlable
    {
         Key GoUp { get;  set; }
         Key GoDown { get;  set; }
         Key GoLeft { get;  set; }
         Key GoRight { get;  set; }
         Key SpecialKey1 { get;  set; }
         Key SpecialKey2 { get;  set; }


         Controls controls { get;  set; }


         void GoLeftMethod();
         void GoRightMethod();
         void GoDownMethod();
         void GoUpMethod();
         void SpecialKey1Method();
         void SpecialKey2Method();

    }
}
