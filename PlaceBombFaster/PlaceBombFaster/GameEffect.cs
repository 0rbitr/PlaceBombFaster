using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlaceBombFaster
{
    public abstract class GameEffect:GameObject
    {
        protected int _timeToEnd;
        protected GamePhysicalObject _targetObject;

        public GameEffect(GamePhysicalObject target)
        {
            _targetObject = target;
        }
    }
}
