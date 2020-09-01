using System;
using System.Collections.Generic;
using System.Text;

namespace Reversi.Classes
{
    public delegate void FieldColorEventHandler(int rowIndex, int columnIndex, DiscColor color);

    public class Board : ICloneable
    {
        #region ReadOnly

        public const int DEFAULT_BOARD_SIZE = 8;

        #endregion

        #region Events

        public event FieldColorEventHandler MoveFinished;

        #endregion

        #region Fields

        private int mBoardSize;

        private DiscColor[,] mFieldColors;

        private int mInvertedDiscsLastMove = 0;

        #endregion

        #region Constructors

        public Board()
            : this(DEFAULT_BOARD_SIZE)
        { }

        public Board(int boardSize)
        {
            this.mBoardSize = boardSize;
            this.mFieldColors = new DiscColor[boardSize, boardSize];

            for (int rowIndex = 0; rowIndex < boardSize; rowIndex++)            
            {
                for (int columnIndex = 0; columnIndex < boardSize; columnIndex++)
                {
                    this.mFieldColors[rowIndex, columnIndex] = DiscColor.None;
                }
            }

            if (boardSize >= 2)
            {
                this.mFieldColors[boardSize / 2 - 1, boardSize / 2 - 1] = DiscColor.White;
                this.mFieldColors[boardSize / 2, boardSize / 2] = DiscColor.White;
                this.mFieldColors[boardSize / 2 - 1, boardSize / 2] = DiscColor.Black;
                this.mFieldColors[boardSize / 2, boardSize / 2 - 1] = DiscColor.Black;
            }
        }

        private Board(Board orignalBoard)
        {
            this.mBoardSize = orignalBoard.Size;
            this.mFieldColors = new DiscColor[this.Size, this.Size];

            for (int rowIndex = 0; rowIndex < this.Size; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < this.Size; columnIndex++)
                {
                    this.mFieldColors[rowIndex, columnIndex] = orignalBoard[rowIndex, columnIndex];
                }
            }
        }

        #endregion

        #region Properties

        public int Size
        {
            get
            {
                return this.mBoardSize;
            }
        }

        public DiscColor this[int rowIndex, int columnIndex]
        {
            get
            {
                return this.mFieldColors[rowIndex, columnIndex];
            }            
        }

        public int InvertedDiscsLastMove
        {
            get
            {
                return this.mInvertedDiscsLastMove;
            }
        }

        #endregion

        #region Methods

        public void SetFieldColor(int rowIndex, int columnIndex, DiscColor color)
        {
            if (this.CanSetFieldColor(rowIndex, columnIndex, color))
            {
                this.mFieldColors[rowIndex, columnIndex] = color;
                this.InvertOpponentDisks(rowIndex, columnIndex, color, out this.mInvertedDiscsLastMove);

                if (this.MoveFinished != null)
                {
                    this.MoveFinished(rowIndex, columnIndex, color);
                }
            }
        }

        public bool CanSetFieldColor(int rowIndex, int columnIndex, DiscColor color)
        {
            bool hasColor = (this[rowIndex, columnIndex] != DiscColor.None);

            if (!hasColor)
            {
                if (color == DiscColor.None)
                {
                    return true;
                }
                else
                {
                    for (int rowIndexChange = -1; rowIndexChange <= 1; rowIndexChange++)
                    {
                        for (int columnIndexChange = -1; columnIndexChange <= 1; columnIndexChange++)
                        {
                            if ((rowIndexChange != 0) || (columnIndexChange != 0))
                            {
                                if (this.CheckDirection(rowIndex, columnIndex, rowIndexChange, columnIndexChange, color))
                                {
                                    return true;
                                }
                            }
                        }
                    }                
                }
            }
            return false;
        }
        private bool CheckDirection(int rowIndex, int columnIndex, int rowIndexChange, int columnIndexChange, DiscColor color)
        {
            bool areOpositeColorDiscsFound = false;
            rowIndex += rowIndexChange;
            columnIndex += columnIndexChange;
            while ((rowIndex >= 0) && (rowIndex < this.Size) && (columnIndex >= 0) && (columnIndex < this.Size))
            {
                if (areOpositeColorDiscsFound)
                {
                    if (this[rowIndex, columnIndex] == color)
                    {
                        return true;
                    }
                    else if (this[rowIndex, columnIndex] == DiscColor.None)
                    {
                        return false;
                    }
                }
                else
                {
                    DiscColor opositeColor = DiscColor.GetOpposite(color);
                    if (this[rowIndex, columnIndex] == opositeColor)
                    {
                        areOpositeColorDiscsFound = true;
                    }
                    else
                    {
                        return false;
                    }
                }

                rowIndex += rowIndexChange;
                columnIndex += columnIndexChange;
            }

            return false;
        }

        public bool CanSetAnyField(DiscColor color)
        {
            for (int rowIndex = 0; rowIndex < this.Size; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < this.Size; columnIndex++)
                {
                    if (this.CanSetFieldColor(rowIndex, columnIndex, color))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int GetDiscsCount(DiscColor color)
        {
            int result = 0;
            for (int rowIndex = 0; rowIndex < this.Size; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < this.Size; columnIndex++)
                {
                    if (this[rowIndex, columnIndex] == color)
                    {
                        result++;
                    }
                }
            }
            return result;
        }        

        private void InvertOpponentDisks(int rowIndex, int columnIndex, DiscColor color, out int invertedDiscsCount)
        {
            invertedDiscsCount = 0;
            for (int rowIndexChange = -1; rowIndexChange <= 1; rowIndexChange++)
            {
                for (int columnIndexChange = -1; columnIndexChange <= 1; columnIndexChange++)
                {
                    if ((rowIndexChange != 0) || (columnIndexChange != 0))
                    {
                        if (this.CheckDirection(rowIndex, columnIndex, rowIndexChange, columnIndexChange, color))
                        {
                            this.InvertDirection(rowIndex, columnIndex, rowIndexChange, columnIndexChange, color, ref invertedDiscsCount);
                        }
                    }
                }
            }     
        }
        private void InvertDirection(
            int rowIndex, int columnIndex,
            int rowIndexChange, int columnIndexChange, 
            DiscColor color, 
            ref int invertedDiscsCount)
        {
            DiscColor opositeColor = DiscColor.GetOpposite(color);
            
            rowIndex += rowIndexChange;
            columnIndex += columnIndexChange;            
            while (this[rowIndex, columnIndex] == opositeColor)
            {
                this.mFieldColors[rowIndex, columnIndex] = color;
                invertedDiscsCount++;
                
                rowIndex += rowIndexChange;
                columnIndex += columnIndexChange;                
            }
        }

        public object Clone()
        {
            return new Board(this);            
        }

        #endregion
    }
}
