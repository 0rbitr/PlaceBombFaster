using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace PlaceBombFaster
{
    [Serializable]
    public class Player
    {
        public int ID { get; private set; }
        public string Name { get;  set; }
        public Color PlayerColor { get; set; }

    }
}