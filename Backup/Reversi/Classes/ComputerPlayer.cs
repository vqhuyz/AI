using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Reversi.Classes
{
    class ComputerPlayer : Player
    {
        #region Static

        public static readonly int MinDepth = 2;
        public static readonly int MaxDepth = 7;

        #endregion

        #region ReadOnly

        private int mMaxDepth;

        #endregion

        #region Constructors

        public ComputerPlayer(Game game, DiscColor color, string name, int maxDepth)
            : base(game, color, name)
        {
            this.mMaxDepth = maxDepth;
        }

        #endregion

        #region Properties

        public override PlayerType Type
        {
            get
            {
                return PlayerType.Computer;
            }
        }

        private int Depth
        {
            get
            {
                return this.mMaxDepth;
            }
        }

        #endregion

        #region Methods

        public override void StartMove()
        {
            base.StartMove();
           
            

            Thread threadDoNextMove = new Thread(this.DoNextMove);
            threadDoNextMove.Start();            
        }

        private void DoNextMove()
        {
            MoveSolver solver = new MoveSolver(this, this.Depth);
            int rowIndex;
            int columnIndex;

            solver.GetNextMove(out rowIndex, out columnIndex);
            if (!this.Game.IsStopped && !this.Game.IsPaused && (rowIndex >= 0) && (columnIndex >= 0))
            {
                this.Game.Board.SetFieldColor(rowIndex, columnIndex, this.Color);
            }
        }

        #endregion
    }
}
