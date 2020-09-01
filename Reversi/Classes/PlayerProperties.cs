using System;
using System.Collections.Generic;
using System.Text;

namespace Reversi.Classes
{
    [Serializable]
    public class PlayerProperties
    {
        public readonly PlayerType Type;
        public readonly string Name;
        public readonly int MaxDepth;

        public PlayerProperties(PlayerType type, string name, int maxDepth)
        {
            this.Type = type;
            this.Name = name;
            this.MaxDepth = maxDepth;
        }

        public PlayerProperties(PlayerType type, string name)
            : this(type, name, 2)
        { }
    }
}
