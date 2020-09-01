using System;
using System.Collections.Generic;
using System.Text;

namespace Reversi.Classes
{
    class HumanPlayer : Player
    {
        #region Constructors

        public HumanPlayer(Game game, DiscColor color, string name)
            : base(game, color, name)
        { }

        #endregion

        #region Properties

        public override PlayerType Type
        {
            get
            {
                return PlayerType.Human;
            }
        }

        #endregion                        
    }
}
