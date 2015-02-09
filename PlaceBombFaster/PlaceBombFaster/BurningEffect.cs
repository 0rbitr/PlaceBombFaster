using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace PlaceBombFaster
{
    class BurningEffect:GameEffect,IUpdatable,IDrawable
    {
        const int BurningDemage = 1;
        public int DrawIndex { get; set; }


        public BurningEffect(GamePhysicalObject target):base(target)
        {
            target.Effects.Add(this);
            target.SetDamage(BurningDemage);
        }

        public void Update(TimeSpan timeSpan)
        {
            throw new NotImplementedException();
        }

        public void Draw(Canvas canvas)
        {
            throw new NotImplementedException();
        }
    }
}
