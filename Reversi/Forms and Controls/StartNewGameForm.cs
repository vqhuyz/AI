using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Reversi.Classes;

namespace Reversi.Forms
{
    public partial class StartNewGameForm : Form
    {
        #region ReadOnly

        private const string FILENAME = "PlayersInfo";

        #endregion

        #region Fields

        private PlayerProperties mPlayer1Properties;
        private PlayerProperties mPlayer2Properties;

        #endregion

        #region Constructors

        public StartNewGameForm()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Properties

        public PlayerProperties Player1Properties
        {
            get
            {
                return this.mPlayer1Properties;
            }
        }

        public PlayerProperties Player2Properties
        {
            get
            {
                return this.mPlayer2Properties;
            }
        }

        #endregion

        #region Methods

        private void SavePlayersProperties()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(FILENAME, FileMode.Create);

            formatter.Serialize(stream, this.Player1Properties);
            formatter.Serialize(stream, this.Player2Properties);

            stream.Close();
        }

        private void LoadPlayersProperties()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                FileStream stream = new FileStream(FILENAME, FileMode.Open);

                PlayerProperties player1Properties = (PlayerProperties)formatter.Deserialize(stream);
                this.ctrlPlayer1.Type = player1Properties.Type;
                this.ctrlPlayer1.PlayerName = player1Properties.Name;
                this.ctrlPlayer1.MaxDepth = player1Properties.MaxDepth;

                PlayerProperties player2Properties = (PlayerProperties)formatter.Deserialize(stream);
                this.ctrlPlayer2.Type = player2Properties.Type;
                this.ctrlPlayer2.PlayerName = player2Properties.Name;
                this.ctrlPlayer2.MaxDepth = player2Properties.MaxDepth;

                stream.Close();
            }
            catch (FileNotFoundException)
            { }
            catch (SerializationException)
            { }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.LoadPlayersProperties();
        }

        #endregion

        #region Events Handling

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.ctrlPlayer1.AreControlValuesCorrect() && this.ctrlPlayer2.AreControlValuesCorrect())
            {
                this.mPlayer1Properties = new PlayerProperties(this.ctrlPlayer1.Type, this.ctrlPlayer1.PlayerName, this.ctrlPlayer1.MaxDepth);
                this.mPlayer2Properties = new PlayerProperties(this.ctrlPlayer2.Type, this.ctrlPlayer2.PlayerName, this.ctrlPlayer2.MaxDepth);

                this.DialogResult = DialogResult.OK;
                this.SavePlayersProperties();
                this.Close();                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion
    }
}