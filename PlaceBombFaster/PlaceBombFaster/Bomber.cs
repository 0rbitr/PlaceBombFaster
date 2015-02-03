using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace PlaceBombFaster
{
    public class Bomber:GameObject,IUpdatable,IDrawable
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
    }
}
