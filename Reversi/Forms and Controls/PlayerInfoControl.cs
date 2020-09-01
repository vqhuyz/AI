using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Reversi.Classes;

namespace Reversi.Controls
{
    public partial class PlayerInfoControl : UserControl
    {
        #region Fields

        private Player mPlayer;

        #endregion

        #region Constructors

        public PlayerInfoControl()
        {            
            this.InitializeComponent();            
        }

        #endregion

        #region Properties

        public Player Player
        {
            get
            {
                return this.mPlayer;
            }
        }

        #endregion

        #region Methods

        public void SetPlayer(Player player)
        {
            this.mPlayer = player;
            this.RefreshInfo();
        }

        public void RefreshInfo()
        {
            this.grbPlayerName.Text = this.Player.Name;
            this.plColor.BackColor = this.Player.Color.Color;
            this.txtType.Text = this.Player.Type.ToString();
            this.txtDiscsCount.Text = this.Player.GetDiscsCount().ToString();
        }

        #endregion
    }
}
