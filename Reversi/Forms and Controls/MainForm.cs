using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Reversi.Classes;
using Reversi.Controls;
using System.Threading;

namespace Reversi.Forms
{
    public partial class MainForm : Form
    {
        #region Nested

        private delegate void StopGameDelegate();

        #endregion

        #region Constructors

        public MainForm()
        {
            this.InitializeComponent();            
        }

        #endregion

        #region Methods

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.StartNewGame();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            lock (this.ctrlBoard)
            {
                StopGameDelegate stopGame = new StopGameDelegate(StopGame);
                this.ctrlBoard.Invoke(stopGame);
            }

        }

        private void StopGame()
        {
            if (this.ctrlBoard.Game != null)
            {
                this.ctrlBoard.Game.Stop();
            }
        }

        private void StartNewGame()
        {
            if (this.ctrlBoard.Game != null)
            {
                this.ctrlBoard.Game.Pause();
            }
            StartNewGameForm frmStartNewGame = new StartNewGameForm();
            if (frmStartNewGame.ShowDialog() == DialogResult.OK)
            {
                Game game = new Game(new Board());
                game.CreatePlayer1(frmStartNewGame.Player1Properties);
                game.CreatePlayer2(frmStartNewGame.Player2Properties);

                this.ctrlBoard.SetGame(game);
                game.Start();
            }
            else
            {
                if (this.ctrlBoard.Game != null)
                {
                    this.ctrlBoard.Game.Continue();
                }
            }
        }

        #endregion

        #region Events Handling

        private void ctrlBoard_Resize(object sender, EventArgs e)
        {
            this.Width = this.ctrlBoard.Left + this.ctrlBoard.Width + 2 * SystemInformation.VerticalResizeBorderThickness;
            this.Height = this.ctrlBoard.Top + this.ctrlBoard.Height + SystemInformation.CaptionHeight + 2 * SystemInformation.HorizontalResizeBorderThickness;
        }

        private void menuItemNewGame_Click(object sender, EventArgs e)
        {
            this.StartNewGame();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion                
    }
}