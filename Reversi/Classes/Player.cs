using System;
using System.Collections.Generic;
using System.Text;

namespace Reversi.Classes
{
    public enum PlayerType
    {
        Human,
        Computer
    }

    public abstract class Player
    {
        #region Fields

        protected DiscColor mColor;
        protected Game mGame;
        protected string mName;

        #endregion

        #region Constructors

        internal Player(Game game, DiscColor color, string name)
        {
            this.mGame = game;
            this.mColor = color;
            this.mName = name;
        }

        #endregion

        #region Properties

        public Game Game
        {
            get
            {
                return this.mGame;
            }
        }

        public DiscColor Color
        {
            get
            {                
                return this.mColor;
            }
        }

        public string Name
        {
            get
            {
                return this.mName;
            }
        }

        #endregion

        #region Methods

        public virtual void StartMove()
        { }

        public abstract PlayerType Type
        {
            get;
        }

        public bool CanMove()
        {
            return this.Game.Board.CanSetAnyField(this.Color);
        }

        public int GetDiscsCount()
        {
            return this.Game.Board.GetDiscsCount(this.Color);
        }

        #endregion
    }
}
