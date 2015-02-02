using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlaceBombFaster
{
    public class Core:IDisposable
    {

        public List<GameObject> GameObjectsList { get; private set; }

        //public  MyProperty { get; set; }

        public Core()
        {

        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}


