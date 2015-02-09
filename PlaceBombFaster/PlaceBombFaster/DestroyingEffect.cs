using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace PlaceBombFaster
{
    abstract class DestroyingEffect:GameEffect,IUpdatable,IDrawable
    {
        public int DrawIndex { get; set; }

        public DestroyingEffect(GamePhysicalObject target):base(target)
        {

        }

        public abstract void Update(TimeSpan timeSpan);


        public abstract void Draw(Canvas canvas);
    }
}
