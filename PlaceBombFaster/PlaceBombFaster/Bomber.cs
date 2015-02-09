using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Input;
using System.Runtime.Serialization;

namespace PlaceBombFaster
{
    [Serializable]
    public class Bomber : GamePhysicalObject, IUpdatable, IDrawable, IControlable
    {
        public int DrawIndex { get; set; }

        public static List<DrawingImage> AnimationTexture;

        public Bomber()
        {
            
            controls = new Controls(this);
        }

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
            get;
            set;
        }

        public Key GoDown
        {
            get;
            set;
        }

        public Key GoLeft
        {
            get;
            set;
        }

        public Key GoRight
        {
            get;
            set;
        }

        public Key SpecialKey1
        {
            get;
            set;
        }

        public Key SpecialKey2
        {
            get;
            set;
        }

        #endregion

        #region KeysActions



        public void GoLeftMethod()
        {
            throw new NotImplementedException();
        }

        public void GoRightMethod()
        {
            throw new NotImplementedException();
        }

        public void GoDownMethod()
        {
            throw new NotImplementedException();
        }

        public void GoUpMethod()
        {
            throw new NotImplementedException();
        }

        public void SpecialKey1Method()
        {
            throw new NotImplementedException();
        }

        public void SpecialKey2Method()
        {
            throw new NotImplementedException();
        }

        #endregion


        public Controls controls
        {
            get;
            set;
        }


    }
}
