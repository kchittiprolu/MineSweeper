using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperLib
{
    public class Minesweeper
    {
        internal const int SIZE = 10;
        internal bool[,] mineGrid = new bool[SIZE, SIZE];
        internal enum cellstate { UNSEALED, SEALED, EXPOSED };
        internal cellstate[,] gridCellState = new cellstate[SIZE, SIZE];
        private bool gamelost;

        public void Start()
        {
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                {
                    mineGrid[i, j] = false;
                    gridCellState[i, j] = cellstate.UNSEALED;
                }
        }

        public bool ExposeCell(int row, int column)
        {
            if (gridCellState[row, column] == cellstate.SEALED || gridCellState[row, column] == cellstate.EXPOSED)
                return false;
            if (mineGrid[row, column])
            {
                gridCellState[row, column] = cellstate.EXPOSED;
                gamelost = true;
                IsGameOver();
            }
            gridCellState[row, column] = cellstate.EXPOSED;
            return true;
        }

        public bool SealACell(int row, int column)
        {
            if (gridCellState[row, column] == cellstate.EXPOSED || gridCellState[row, column] == cellstate.SEALED)
                return false;

            gridCellState[row, column] = cellstate.SEALED;
            return true;
        }

        public bool UnsealACell(int row, int column)
        {
            if (gridCellState[row, column] == cellstate.UNSEALED)
                return false;

            gridCellState[row, column] = cellstate.UNSEALED;
            return true;
        }

        public bool IsGameOver()
        {
            if (gamelost)
                return true;

            return false;
        }

        internal void SetMine(int row, int column)
        {
            mineGrid[row, column] = true;
        }

        public int GetAdjacentCellCount(int row, int column)
        {
            int count = 0;
            for (int i = row - 1; i <= row + 1; i++)
                for (int j = column - 1; j <= column + 1; j++)
                {
                    if (i >= 0 && i < SIZE && j >= 0 && j < SIZE)
                    {
                        if (mineGrid[i, j])
                            count++;
                    }
                }
            return count;
        }

        public bool ExposeNeighboringCells(int row, int column)
        {
            if (GetAdjacentCellCount(row, column) != 0)
                return false;
            for (int i = row - 1; i <= row + 1; i++)
                for (int j = column - 1; j <= column + 1; j++)
                {
                    if (i == row && j == column)
                        continue;
                    if (i >= 0 && i < SIZE && j >= 0 && j < SIZE && gridCellState[i, j] != cellstate.EXPOSED)
                    {
                        gridCellState[i, j] = cellstate.EXPOSED;
                        ExposeNeighboringCells(i, j);
                    }
                }
            return true;
        }

        public char DisplayOnCell(int row, int column)
        {
            if (gridCellState[row, column] == cellstate.EXPOSED && GetAdjacentCellCount(row, column) != 0 && !mineGrid[row, column])
                return char.Parse(GetAdjacentCellCount(row, column).ToString());

            if (mineGrid[row, column] == true && gridCellState[row, column] == cellstate.EXPOSED)
                return 'M';

            if (gridCellState[row, column] == cellstate.SEALED)
                return 'S';
            if (GetAdjacentCellCount(row, column) == 0 && gridCellState[row, column] == cellstate.EXPOSED)
                return ' ';

            return 'U';
        }

        internal void PlaceMines()
        {
            Random RandomNumber = new Random();

            for (int i = 0; i < 10; )
            {
                int rownumber = RandomNumber.Next(0, 10);
                int colnumber = RandomNumber.Next(0, 10);
                if (!mineGrid[rownumber, colnumber])
                    i++;
                SetMine(rownumber, colnumber);
            }
        }

        public bool CheckGameWin()
        {
            int sealedmines = 0;
            int exposednonminecells = 0;

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (mineGrid[i, j] && DisplayOnCell(i, j) == 'S')
                    {
                        sealedmines++;
                    }
                    if (!mineGrid[i, j] && gridCellState[i, j] == cellstate.EXPOSED)
                    {
                        exposednonminecells++;
                    }
                }
            if (sealedmines == 10 && exposednonminecells == 90)
                return true;

            return false;
        }
    }
}
