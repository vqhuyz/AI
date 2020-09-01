using System;
using System.Collections.Generic;
using System.Text;

namespace Reversi.Classes
{
    public delegate void GameEventHandler();

    public class Game
    {
        #region Events

        public event GameEventHandler Started;
        public event FieldColorEventHandler MoveFinished;
        public event GameEventHandler MoveStarted;
        public event GameEventHandler Finished;

        #endregion

        #region Fields

        private Board mBoard;
        private Player mPlayer1;
        private Player mPlayer2;

        private Player mCurrentPlayer;
        private bool mIsFinished = false;
        private bool mIsStopped = false;
        private bool mIsPaused = false;

        #endregion

        #region Constructors

        public Game(Board board)
        {
            this.mBoard = board;
        }

        #endregion

        #region Properties

        public Board Board
        {
            get
            {
                return this.mBoard;
            }
        }

        public Player Player1
        {
            get
            {
                return this.mPlayer1;
            }
        }

        public Player Player2
        {
            get
            {
                return this.mPlayer2;
            }
        }

        public Player CurrentPlayer
        {
            get
            {
                return this.mCurrentPlayer;
            }
        }

        public bool IsFinished
        {
            get
            {
                return this.mIsFinished;
            }
        }

        public bool IsStarted
        {
            get
            {
                return (this.CurrentPlayer != null) || this.IsFinished;
            }
        }

        public bool IsStopped
        {
            get
            {
                return this.mIsStopped;
            }
        }

        public bool IsPaused
        {
            get
            {
                return this.mIsPaused;
            }
        }

        #endregion

        #region Methods

        public Player CreatePlayer1(PlayerProperties properties)
        {
            this.mPlayer1 = this.CreatePlayer(properties, DiscColor.Black);
            return this.mPlayer1;
        }

        public Player CreatePlayer2(PlayerProperties properties)
        {
            this.mPlayer2 = this.CreatePlayer(properties, DiscColor.White);
            return this.mPlayer2;
        }

        private Player CreatePlayer(PlayerProperties properties, DiscColor color)
        {
            switch (properties.Type)
            {
                case PlayerType.Human:
                    return new HumanPlayer(this, color, properties.Name);
                    
                case PlayerType.Computer:
                    return new ComputerPlayer(this, color, properties.Name, properties.MaxDepth);
            }

            return null;
        }


        public bool Start()
        {
            if ((this.Player1 != null) && (this.Player2 != null))
            {
                this.Board.MoveFinished += new FieldColorEventHandler(this.OnMoveFinished);

                if (this.Started != null)
                {
                    this.Started();
                }

                this.SetPlayerToMove(this.Player1);                               
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SetPlayerToMove(Player player)
        {
            this.mCurrentPlayer = player;

            if (this.MoveStarted != null)
            {
                this.MoveStarted();
            }

            this.CurrentPlayer.StartMove();
        }

        public void Stop()
        {
            this.mIsStopped = true;
        }

        public void Pause()
        {
            if (!this.IsFinished && !this.IsStopped)
            {
                this.mIsPaused = true;
            }
        }

        public void Continue()
        {
            if (!this.IsFinished && !this.IsStopped)
            {
                this.mIsPaused = false;
                this.SetPlayerToMove(this.CurrentPlayer);
            }
        }

        #endregion

        #region Events Handling

        private void OnMoveFinished(int rowIndex, int columnIndex, DiscColor color)
        {
            if (!this.mIsStopped)
            {
                if (this.MoveFinished != null)
                {
                    this.MoveFinished(rowIndex, columnIndex, color);
                }

                Player opositePlayer = (this.CurrentPlayer == this.Player1) ? this.Player2 : this.Player1;
                if (opositePlayer.CanMove())
                {
                    this.SetPlayerToMove(opositePlayer);
                }
                else if (this.CurrentPlayer.CanMove())
                {
                    this.SetPlayerToMove(this.CurrentPlayer);
                }
                else
                {
                    this.mCurrentPlayer = null;
                    this.mIsFinished = true;

                    if (this.Finished != null)
                    {
                        this.Finished();
                    }
                }                
            }
        }

        #endregion
    }
}
