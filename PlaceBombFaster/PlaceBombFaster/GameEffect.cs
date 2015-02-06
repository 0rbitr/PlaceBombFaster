using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlaceBombFaster
{
    abstract class GameEffect:GameObject
    {
        protected GamePhysicalObject _targetObject;

        public GameEffect(GamePhysicalObject target)
        {
            _targetObject = target;
        }
    }
}
