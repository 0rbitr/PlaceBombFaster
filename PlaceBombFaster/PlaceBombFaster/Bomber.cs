using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Input;

namespace PlaceBombFaster
{
    public class Bomber:GameObject,IUpdatable,IDrawable, IControlable
    {
        private DrawingImage CurrentTexture;
        public static List<DrawingImage> AnimationTexture;
 


        public void Update(TimeSpan timeSpan)
        {
            throw new NotImplementedException();
        }

        public void Draw(System.Windows.Controls.Canvas canvas)
        {
            throw new NotImplementedException();
        }

        #region Keys


        public Key GoUp
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }

        public Key GoDown
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }

        public Key GoLeft
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }

        public Key GoRight
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }

        public Key SpecialKey1
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }

        public Key SpecialKey2
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region KeysActions

        void IControlable.GoLeft()
        {
            throw new NotImplementedException();
        }

        void IControlable.GoRight()
        {
            throw new NotImplementedException();
        }

        void IControlable.GoDown()
        {
            throw new NotImplementedException();
        }

        void IControlable.GoUp()
        {
            throw new NotImplementedException();
        }

        void IControlable.SpecialKey1()
        {
            throw new NotImplementedException();
        }

        void IControlable.SpecialKey2()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
