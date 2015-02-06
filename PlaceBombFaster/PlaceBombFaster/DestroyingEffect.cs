using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace PlaceBombFaster
{
    abstract class DestroyingEffect:GameEffect,IUpdatable,IDrawable
    {


        public void Update(TimeSpan timeSpan);


        public void Draw(Canvas canvas);
    }
}
