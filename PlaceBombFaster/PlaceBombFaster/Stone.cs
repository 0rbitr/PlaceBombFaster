using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace PlaceBombFaster
{
    class Stone:GamePhysicalObject,IDrawable
    {
        static DrawingImage _texture;
        public Stone(int x, int y, int hp, int damageBlock)
            : base(x,y,_texture,hp,damageBlock)
        {
            DrawIndex = 2;
        }

        #region IDrawable

        public int DrawIndex
        {
            get;
            set;
        }

        public void Draw(Canvas canvas)
        {

            throw new NotImplementedException();
        } 
        #endregion
    }
}
