using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Reversi.Classes;
using System.Threading;

namespace Reversi.Controls
{
    public partial class BoardControl : UserControl
    {
        #region ReadOnly

        private const int BOARD_BORDER_WIDTH = 20;
        private const int DISTANCE_BETWEEN_CONTROLS = 6;

        #endregion

        #region Nested

        private delegate void MoveDelegate(int rowIndex, int columnIndex, DiscColor color);
        private delegate void GameDelegate();

        #endregion

        #region Fields

        private Game mGame;
        
        private DateTime mCurrentMoveStart;

        #endregion

        #region Constructors

        public BoardControl()
        {   
            this.InitializeComponent();            
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

        public bool IsHumanPlayerToMove
        {
            get
            {
                if (this.Game != null)
                {
                    return this.Game.CurrentPlayer is HumanPlayer;
                }
                else
                {
                    return false;
                }
            }
        }

        #endregion

        #region Methods

        public bool SetGame(Game game)
        {
            if ((game != null) && (game.Player1 != null) && (game.Player2 != null))
            {
                this.mGame = game;

                this.Game.Started += new GameEventHandler(this.OnGameStarted);
                this.Game.Finished += new GameEventHandler(this.OnGameFinished);
                this.CreateFields();
                this.RefreshFieldsColors();
                this.SetPlayers();
                this.RefreshTime();                

                return true;
            }
            else
            {
                return false;
            }
        }

        private void SetPlayers()
        {           
            this.ctrlPlayer1.SetPlayer(this.Game.Player1);
            this.ctrlPlayer2.SetPlayer(this.Game.Player2);
        }

        private void CreateFields()
        {
            this.plBoard.Width = 2 * BOARD_BORDER_WIDTH + this.Game.Board.Size * BoardFieldControl.SIZE;            
            this.plBoard.Height = this.plBoard.Width;

            this.Width = 3 * DISTANCE_BETWEEN_CONTROLS + this.ctrlPlayer1.Width + this.plBoard.Width;
            this.Height = 2 * DISTANCE_BETWEEN_CONTROLS + Math.Max(this.plBoard.Height, this.lblMoveDuration.Bottom);

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            Graphics graphics = this.plBoard.CreateGraphics();
            Font numbersFont = new Font(this.plBoard.Font, FontStyle.Bold);            

            int locationY = BOARD_BORDER_WIDTH - 1;
            for (int rowIndex = 0; rowIndex < this.Game.Board.Size; rowIndex++)            
            {                           
                int locationX = BOARD_BORDER_WIDTH - 1;
                for (int columnIndex = 0; columnIndex < this.Game.Board.Size; columnIndex++)
                {
                    BoardFieldControl field = new BoardFieldControl(this, rowIndex, columnIndex, this.Game.Board[rowIndex, columnIndex]);
                    field.Location = new Point(locationX, locationY);
                    this.plBoard.Controls.Add(field);

                    #region Column Number

                    if (rowIndex == 0)
                    {
                        string columnNumber = new string((char)('a' + columnIndex), 1);
                        SizeF columnNumberSize = graphics.MeasureString(columnNumber, numbersFont);
                        int columnNumberLocationX = locationX + (BoardFieldControl.SIZE - (int)columnNumberSize.Width) / 2;
                        int columnNumberLocationY = (BOARD_BORDER_WIDTH - (int)columnNumberSize.Height) / 2;

                        Label lblColumnNumber = new Label();
                        lblColumnNumber.Text = columnNumber;
                        lblColumnNumber.Font = numbersFont;
                        lblColumnNumber.AutoSize = true;                        
                        lblColumnNumber.Location = new Point(columnNumberLocationX, columnNumberLocationY);
                        this.plBoard.Controls.Add(lblColumnNumber);
                    }

                    #endregion

                    locationX += BoardFieldControl.SIZE;
                }

                #region Row Number

                int rowNumber = rowIndex + 1;
                SizeF rowNumberSize = graphics.MeasureString(rowNumber.ToString(), numbersFont);
                int rowNumberLocationY = locationY + (BoardFieldControl.SIZE - (int)rowNumberSize.Height) / 2;
                int rowNumberLocationX = (BOARD_BORDER_WIDTH - (int)rowNumberSize.Width) / 2;

                Label lblRowNumber = new Label();
                lblRowNumber.Text = rowNumber.ToString();
                lblRowNumber.Font = numbersFont;
                lblRowNumber.AutoSize = true;
                lblRowNumber.Location = new Point(rowNumberLocationX, rowNumberLocationY);                
                this.plBoard.Controls.Add(lblRowNumber);

                #endregion

                locationY += BoardFieldControl.SIZE;
            }
        }

        private void RefreshFieldsColors()
        {
            foreach (Control control in this.plBoard.Controls)
            {
                if (control is BoardFieldControl)
                {
                    BoardFieldControl boardField = control as BoardFieldControl;
                    boardField.CurrentColor = this.Game.Board[boardField.RowIndex, boardField.ColumnIndex];
                }
            }
            this.plBoard.Refresh();
        }

        private void ShowGameFinished()
        {
            int player1Score = this.Game.Player1.GetDiscsCount();
            int player2Score = this.Game.Player2.GetDiscsCount();

            string message;
            if (player1Score != player2Score)
            {
                string winnerName = (player1Score > player2Score) ? this.Game.Player1.Name : this.Game.Player2.Name;
                message = String.Format("{0} won the game.", winnerName);
            }
            else
            {
                message = "The game ended in a draw.";
            }

            this.lblCurrentPlayer.Text = message;
            MessageBox.Show(message);                        
        }

        private void RefreshCurrentMoveInfo()
        {
            Player nextPlayer = this.Game.CurrentPlayer;
            if (nextPlayer == null)
            {
                nextPlayer = this.Game.Player1;
            }

            this.lblCurrentPlayer.Text = String.Format("It's {0}'s move.", nextPlayer.Name);
        }

        private void RefreshLastMoveInfo(Player lastPlayer, int lastMoveRowIndex, int lastMoveColumnIndex)
        {
            string lastMove = String.Empty;
            if ((lastPlayer != null) && (lastMoveColumnIndex >= 0) && (lastMoveRowIndex >= 0))
            {
                lastMove = String.Format("{0}'s last move was {1}{2}.",
                    lastPlayer.Name,
                    (char)('a' + lastMoveColumnIndex),
                    lastMoveRowIndex + 1);            
            }
            this.lblLastMove.Text = lastMove;
        }

        private void RefreshTime()
        {
            TimeSpan timeElapsed = new TimeSpan(0);
            if (this.Game.IsStarted)
            {
                timeElapsed = DateTime.Now - this.mCurrentMoveStart;
            }

            this.lblMoveDuration.Text = String.Format("Move duration:   {0:00}:{1:00}", timeElapsed.Minutes, timeElapsed.Seconds);
        }

        private void StartTimer()
        {
            this.timerCurrentMove.Stop();
            this.mCurrentMoveStart = DateTime.Now;
            this.timerCurrentMove.Start();
            
            this.RefreshTime();
        }

        private void RefreshControl(int rowIndex, int columnIndex, DiscColor color)
        {
            this.RefreshFieldsColors();
            this.ctrlPlayer1.RefreshInfo();
            this.ctrlPlayer2.RefreshInfo();

            Player player = (this.Game.Player2.Color == color) ? this.Game.Player2 : this.Game.Player1;
            this.RefreshLastMoveInfo(player, rowIndex, columnIndex);
            this.RefreshCurrentMoveInfo();

            this.StartTimer();
        }

        #endregion

        #region Events Handling

        private void OnGameStarted()
        {
            this.Game.MoveFinished += new FieldColorEventHandler(this.OnPlayerMoveFinished);
            this.Game.MoveStarted += new GameEventHandler(this.OnPlayerMoveStarted);
            this.RefreshLastMoveInfo(null, -1, -1);
            this.StartTimer();
        }

        private void OnGameFinished()
        {
            this.timerCurrentMove.Stop();

            GameDelegate showGameFinished = new GameDelegate(this.ShowGameFinished);
            this.Invoke(showGameFinished);
        }

        private void OnPlayerMoveFinished(int rowIndex, int columnIndex, DiscColor color)
        {
            if (!this.Game.IsStopped)
            {
                MoveDelegate refreshControl = new MoveDelegate(this.RefreshControl);
                this.Invoke(refreshControl, rowIndex, columnIndex, color);
            }
        }

        private void OnPlayerMoveStarted()
        {
            if (!this.Game.IsStopped)
            {
                GameDelegate refreshControl = new GameDelegate(this.RefreshCurrentMoveInfo);
                this.Invoke(refreshControl);
            }
        }

        private void timerCurrentMove_Tick(object sender, EventArgs e)
        {
            this.RefreshTime();            
        }

        #endregion
    }
}

