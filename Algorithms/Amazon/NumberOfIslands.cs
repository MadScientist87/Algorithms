using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Algorithms.Amazon
{
    public class NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            var numberOfIslands = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        numberOfIslands++;
                        CheckCellForIsland(grid, i, j);
                    }
                }
            }

            return numberOfIslands;
        }

        private void CheckCellForIsland(char[][] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i > grid.Length - 1 || j > grid[i].Length - 1 || grid[i][j] == '0')
                return;
            grid[i][j] = '0';
            CheckCellForIsland(grid, i, j + 1);
            CheckCellForIsland(grid, i, j - 1);
            CheckCellForIsland(grid, i - 1, j);
            CheckCellForIsland(grid, i + 1, j);
        }

    }
}
