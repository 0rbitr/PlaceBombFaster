using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlaceBombFaster
{
    class GameEngine:IDisposable,IDrawable
    {

        public List<GameObject> GameObjectsList { get; private set; }



       
        public void Draw(System.Windows.Controls.Canvas canvas)
        {
            
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
