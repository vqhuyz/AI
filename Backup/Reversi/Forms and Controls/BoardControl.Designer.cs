namespace Reversi.Controls
{
    partial class BoardControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }    

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.plBoard = new System.Windows.Forms.Panel();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.lblLastMove = new System.Windows.Forms.Label();
            this.lblMoveDuration = new System.Windows.Forms.Label();
            this.ctrlPlayer2 = new Reversi.Controls.PlayerInfoControl();
            this.ctrlPlayer1 = new Reversi.Controls.PlayerInfoControl();
            this.timerCurrentMove = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // plBoard
            // 
            this.plBoard.BackColor = System.Drawing.Color.BurlyWood;
            this.plBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plBoard.Location = new System.Drawing.Point(162, 6);
            this.plBoard.Name = "plBoard";
            this.plBoard.Size = new System.Drawing.Size(282, 315);
            this.plBoard.TabIndex = 0;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentPlayer.Location = new System.Drawing.Point(6, 238);
            this.lblCurrentPlayer.Margin = new System.Windows.Forms.Padding(3);
            this.lblCurrentPlayer.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(126, 16);
            this.lblCurrentPlayer.TabIndex = 3;
            this.lblCurrentPlayer.Text = "Game not started";
            // 
            // lblLastMove
            // 
            this.lblLastMove.AutoSize = true;
            this.lblLastMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastMove.Location = new System.Drawing.Point(6, 200);
            this.lblLastMove.Margin = new System.Windows.Forms.Padding(3);
            this.lblLastMove.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblLastMove.Name = "lblLastMove";
            this.lblLastMove.Size = new System.Drawing.Size(0, 16);
            this.lblLastMove.TabIndex = 4;
            // 
            // lblMoveDuration
            // 
            this.lblMoveDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMoveDuration.AutoSize = true;
            this.lblMoveDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoveDuration.Location = new System.Drawing.Point(6, 305);
            this.lblMoveDuration.Margin = new System.Windows.Forms.Padding(3);
            this.lblMoveDuration.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblMoveDuration.Name = "lblMoveDuration";
            this.lblMoveDuration.Size = new System.Drawing.Size(133, 16);
            this.lblMoveDuration.TabIndex = 5;
            this.lblMoveDuration.Text = "Move duration   00:00";
            // 
            // ctrlPlayer2
            // 
            this.ctrlPlayer2.Location = new System.Drawing.Point(6, 103);
            this.ctrlPlayer2.MinimumSize = new System.Drawing.Size(128, 91);
            this.ctrlPlayer2.Name = "ctrlPlayer2";
            this.ctrlPlayer2.Size = new System.Drawing.Size(150, 91);
            this.ctrlPlayer2.TabIndex = 2;
            // 
            // ctrlPlayer1
            // 
            this.ctrlPlayer1.Location = new System.Drawing.Point(6, 6);
            this.ctrlPlayer1.MinimumSize = new System.Drawing.Size(128, 91);
            this.ctrlPlayer1.Name = "ctrlPlayer1";
            this.ctrlPlayer1.Size = new System.Drawing.Size(150, 91);
            this.ctrlPlayer1.TabIndex = 1;
            // 
            // timerCurrentMove
            // 
            this.timerCurrentMove.Interval = 1000;
            this.timerCurrentMove.Tick += new System.EventHandler(this.timerCurrentMove_Tick);
            // 
            // BoardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMoveDuration);
            this.Controls.Add(this.lblLastMove);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.ctrlPlayer2);
            this.Controls.Add(this.ctrlPlayer1);
            this.Controls.Add(this.plBoard);
            this.Name = "BoardControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(450, 327);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plBoard;
        private PlayerInfoControl ctrlPlayer1;
        private PlayerInfoControl ctrlPlayer2;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Label lblLastMove;
        private System.Windows.Forms.Label lblMoveDuration;
        private System.Windows.Forms.Timer timerCurrentMove;
    }
}
