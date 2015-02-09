using System.Windows.Controls;

namespace PlaceBombFaster
{
    interface IDrawable
    {
         int DrawIndex { get; set; }
         void Draw(Canvas canvas);
    }
}
