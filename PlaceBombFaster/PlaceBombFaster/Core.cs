using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlaceBombFaster
{
    public class Core:IDisposable
    {
        private Core _core;
        public Core core
        {
            get
            {
                if (_core == null) _core = new Core();
                return _core;
            }
            set
            {
                if (value == null)
                {
                    _core.Dispose();
                }
               _core = value;
            }
        }


        Core()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}


