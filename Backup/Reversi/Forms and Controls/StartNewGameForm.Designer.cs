namespace Reversi.Forms
{
    partial class StartNewGameForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ctrlPlayer2 = new Reversi.Controls.PlayerPropertiesControl();
            this.ctrlPlayer1 = new Reversi.Controls.PlayerPropertiesControl();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(57, 232);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(138, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ctrlPlayer2
            // 
            this.ctrlPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlPlayer2.Location = new System.Drawing.Point(8, 120);
            this.ctrlPlayer2.MaxDepth = 2;
            this.ctrlPlayer2.Name = "ctrlPlayer2";
            this.ctrlPlayer2.PlayerColor = "Player 2 (white)";
            this.ctrlPlayer2.PlayerName = "Computer";
            this.ctrlPlayer2.Size = new System.Drawing.Size(205, 106);
            this.ctrlPlayer2.TabIndex = 1;
            this.ctrlPlayer2.Type = Reversi.Classes.PlayerType.Computer;
            // 
            // ctrlPlayer1
            // 
            this.ctrlPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlPlayer1.Location = new System.Drawing.Point(8, 8);
            this.ctrlPlayer1.MaxDepth = 2;
            this.ctrlPlayer1.Name = "ctrlPlayer1";
            this.ctrlPlayer1.PlayerColor = "Player 1 (black)";
            this.ctrlPlayer1.PlayerName = "";
            this.ctrlPlayer1.Size = new System.Drawing.Size(205, 106);
            this.ctrlPlayer1.TabIndex = 0;
            this.ctrlPlayer1.Type = Reversi.Classes.PlayerType.Human;
            // 
            // StartNewGameForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(221, 263);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctrlPlayer2);
            this.Controls.Add(this.ctrlPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(227, 287);
            this.Name = "StartNewGameForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start New Game";
            this.ResumeLayout(false);

        }

        #endregion

        private Reversi.Controls.PlayerPropertiesControl ctrlPlayer1;
        private Reversi.Controls.PlayerPropertiesControl ctrlPlayer2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;        

    }
}