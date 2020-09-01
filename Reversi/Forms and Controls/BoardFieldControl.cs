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
    public partial class BoardFieldControl : UserControl
    {
        #region ReadOnly

        public const int SIZE = 48;

        #endregion

        #region Fields

        private DiscColor mCurrentColor;

        private BoardControl mBoardControl;
        private int mRowIndex;
        private int mColumnIndex;

        private bool mIsMouseOver = false;

        #endregion

        #region Constructors

        public BoardFieldControl(BoardControl boardControl, int rowIndex, int columnIndex, DiscColor currentColor)
        {
            this.mBoardControl = boardControl;
            this.mRowIndex = rowIndex;
            this.mColumnIndex = columnIndex;
            this.mCurrentColor = currentColor;

            this.InitializeComponent();

            this.Width = SIZE;
            this.Height = SIZE;
        }

        #endregion

        #region Properties

        public BoardControl BoardControl
        {
            get
            {
                return this.mBoardControl;
            }
        }

        public int RowIndex
        {
            get
            {
                return this.mRowIndex;
            }
        }

        public int ColumnIndex
        {
            get
            {
                return this.mColumnIndex;
            }
        }

        public DiscColor CurrentColor
        {
            get
            {
                return this.mCurrentColor;
            }
            set
            {
                this.mCurrentColor = value;
            }
        }


        private bool CanMove()
        {
            return this.BoardControl.Game.Board.CanSetFieldColor(
                this.RowIndex,
                this.ColumnIndex,
                this.BoardControl.Game.CurrentPlayer.Color);
        }

        #endregion

        #region Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            this.DrawDisc(e);
            this.DrawBorder(e);           
        }

        private void DrawDisc(PaintEventArgs e)
        {
            if (this.CurrentColor != DiscColor.None)
            {
                Color discColor = this.CurrentColor.Color;
                int discStart = this.Width / 6;
                int discWidth = 2 * this.Width / 3;
                Rectangle rectangle = new Rectangle(discStart, discStart, discWidth, discWidth);

                e.Graphics.FillEllipse(new SolidBrush(discColor), rectangle);
                e.Graphics.DrawEllipse(Pens.Black, rectangle);
            }
        }

        private void DrawBorder(PaintEventArgs e)
        {
            if (this.RowIndex == 0)
            {
                e.Graphics.DrawLine(Pens.Black, 0, 0, this.Width - 1, 0);
            }
            if (this.ColumnIndex == 0)
            {
                e.Graphics.DrawLine(Pens.Black, 0, 0, 0, this.Height - 1);
            }
            e.Graphics.DrawLine(Pens.Black, 0, this.Height - 1, this.Width - 1, this.Height - 1);
            e.Graphics.DrawLine(Pens.Black, this.Width - 1, 0, this.Width - 1, this.Height - 1);
        }        


        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            if (this.BoardControl.IsHumanPlayerToMove && !this.BoardControl.Game.IsPaused && this.CanMove())
            {
                this.mIsMouseOver = true;                
                this.Cursor = Cursors.Hand;
                this.DrawPotentialMove();
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void DrawPotentialMove()
        {
            if (this.mIsMouseOver)
            {
                Graphics graphics = this.CreateGraphics();
                graphics.DrawRectangle(Pens.Black, 0, 0, this.Width - 2, this.Height - 2);
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (this.mIsMouseOver)
            {
                // Clears potential move
                this.Refresh();
                this.mIsMouseOver = false;
            }
        }        


        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            if (this.mIsMouseOver)
            {
                this.BoardControl.Game.Board.SetFieldColor(this.RowIndex, this.ColumnIndex, this.BoardControl.Game.CurrentPlayer.Color);
                this.mIsMouseOver = false;
            }
        }

        #endregion
    }
}
