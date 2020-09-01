using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Reversi.Classes
{
    public class DiscColor
    {
        private Color mColor;

        private DiscColor(Color color)
        {
            this.mColor = color;
        }

        public Color Color
        {
            get
            {
                return this.mColor;
            }
        }

        public static readonly DiscColor Black = new DiscColor(Color.Black);
        public static readonly DiscColor White = new DiscColor(Color.White);
        public static readonly DiscColor None = new DiscColor(Color.Empty);

        public static DiscColor GetOpposite(DiscColor color)
        {
            if (color == DiscColor.Black)
            {
                return DiscColor.White;
            }
            else if (color == DiscColor.White)
            {
                return DiscColor.Black;
            }
            else
            {
                return DiscColor.None;
            }
        }
    }
}
