namespace Reversi.Forms
{
    partial class MainForm
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuItemGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlBoard = new Reversi.Controls.BoardControl();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGame});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(450, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuItemGame
            // 
            this.menuItemGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewGame,
            this.menuItemSeparator,
            this.menuItemExit});
            this.menuItemGame.Name = "menuItemGame";
            this.menuItemGame.Size = new System.Drawing.Size(46, 20);
            this.menuItemGame.Text = "Game";
            // 
            // menuItemNewGame
            // 
            this.menuItemNewGame.Name = "menuItemNewGame";
            this.menuItemNewGame.Size = new System.Drawing.Size(106, 22);
            this.menuItemNewGame.Text = "New";
            this.menuItemNewGame.Click += new System.EventHandler(this.menuItemNewGame_Click);
            // 
            // menuItemSeparator
            // 
            this.menuItemSeparator.Name = "menuItemSeparator";
            this.menuItemSeparator.Size = new System.Drawing.Size(103, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(106, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // ctrlBoard
            // 
            this.ctrlBoard.Location = new System.Drawing.Point(1, 27);
            this.ctrlBoard.Name = "ctrlBoard";
            this.ctrlBoard.Padding = new System.Windows.Forms.Padding(3);
            this.ctrlBoard.Size = new System.Drawing.Size(451, 328);
            this.ctrlBoard.TabIndex = 0;
            this.ctrlBoard.Resize += new System.EventHandler(this.ctrlBoard_Resize);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 353);
            this.Controls.Add(this.ctrlBoard);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reversi";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Reversi.Controls.BoardControl ctrlBoard;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemGame;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewGame;
        private System.Windows.Forms.ToolStripSeparator menuItemSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
    }
}

