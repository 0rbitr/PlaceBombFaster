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
        public Action this[string key]
        {
            get
            {
                return GetActionByDescription[key];
            }
        }
        public Action this[Key key]
        {
            get
            {
                return GetActionByKey[key];
            }
        }

        IControlable ControlableUnit;

        private Dictionary<Key, Action> GetActionByKey;
        private Dictionary<string, Action> GetActionByDescription;


        public Controls(IControlable unit)
        {

            ControlableUnit = unit;
            foreach (var item in ControlableUnit.GetType().GetProperties())
            {
                AddActionOnKey((Key)item.GetValue(ControlableUnit,null), item.Name, 
                    (Action)Delegate.CreateDelegate(
                    typeof(Action),
                    ControlableUnit,
                    ControlableUnit.GetType().GetMethod(item.Name+ "Method"))
                   );
            }
        }

        public void AddActionOnKey(Key key, string descrption, Action action)
        {
            GetActionByKey.Add(key, action);
            GetActionByDescription.Add(descrption, action);
        }
    }
}
