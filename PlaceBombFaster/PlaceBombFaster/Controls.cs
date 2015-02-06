using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace PlaceBombFaster
{
    public class Controls
    {

        //public Key GoUp { get; set; }
        //public Key GoDown { get; set; }
        //public Key GoLeft { get; set; }
        //public Key GoRight { get; set; }
        //public Key SpecialKey1 { get; set; }
        //public Key SpecialKey2 { get; set; }
        IControlable ControlableUnit;

        public Dictionary<Key, Action> GetActionByKey;
        public Dictionary<string, Action> GetActionByDescription;


        public Controls(IControlable unit)
        {
            ControlableUnit = unit;
            foreach (var item in ControlableUnit.GetType().GetProperties())
            {
                GetActionByKey.Add((Key)item.GetValue(ControlableUnit,null), (Action)Delegate.CreateDelegate(
                    typeof(Action),
                    ControlableUnit,
                    ControlableUnit.GetType().GetMethod(item.Name))
                   );
                GetActionByDescription.Add(item.Name, (Action)Delegate.CreateDelegate(
                    typeof(Action),
                    ControlableUnit,
                    ControlableUnit.GetType().GetMethod(item.Name))
                    );
            }
        }
    }
}
