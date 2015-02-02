using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace PlaceBombFaster
{
    public class Control
    {

        public Key Controlkey { get; set; }

        public Action ControlAction { get; private set; }

        public String Desctiption { get; private set; }

        public Control(Key key, Action action, string desription)
        {
            Controlkey = key;
            ControlAction = action;
            Desctiption = desription;
        }
    }
}
