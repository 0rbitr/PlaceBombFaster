using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace PlaceBombFaster
{
    
    interface IControlable
    {
        public Key GoUp { get; protected set; }
        public Key GoDown { get; protected set; }
        public Key GoLeft { get; protected set; }
        public Key GoRight { get; protected set; }
        public Key SpecialKey1 { get; protected set; }
        public Key SpecialKey2 { get; protected set; }


        public void GoLeft();
        public void GoRight();
        public void GoDown();
        public void GoUp();
        public void SpecialKey1();
        public void SpecialKey2();

    }
}
