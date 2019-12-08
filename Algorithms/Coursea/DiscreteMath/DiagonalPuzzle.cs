using System;
namespace Algorithms.Coursea.DiscreteMath
{
    public static class DiagonalPuzzle
    {

        public static void Extend(int[,] grid, int row, int column, int targetDiagonals)
        {

            foreach (var k in new int[] { 2, 1, 0 })
            {
                grid[row, column] = k;

                if (CanBeExtendedToSolution(grid, row, column))
                {
                    if (row == grid.GetLength(0) - 1 && column == grid.GetLength(1) - 1)
                    {
                        int numOfDiags = 0;

                        for (int i = 0; i < grid.GetLength(0); i++)
                        {
                            for (int j = 0; j < grid.GetLength(1); j++)
                            {
                                if (grid[i, j] > 0)
                                    numOfDiags += 1;
                            }
                        }

                        if (numOfDiags == targetDiagonals)
                        {
                            char[] symbols = { ' ', '\\', '/' };
                            for (int i = 0; i < grid.GetLength(0); i++)
                            {
                                for (int j = 0; j < grid.GetLength(1); j++)
                                {
                                    // Print grid
                                }
                            }

                            // Let it return naturally, will print multiple solutions
                            //System.Environment.Exit(0);
                        }
                        return;
                    }

                    int nextrow = 0, nextcolumn = 0;
                    if (column < grid.GetLength(1) - 1)
                    {
                        nextrow = row; nextcolumn = column + 1;
                    }
                    else
                    {
                        nextrow = row + 1; nextcolumn = 0;
                    }

                    Extend(grid, nextrow, nextcolumn, targetDiagonals);

                }
            }
            return;
        }

        public static bool CanBeExtendedToSolution(int[,] grid, int row, int column)
        {
            if (grid[row, column] == 1)
            {
                if (row > 0 && column > 0 && grid[row - 1, column - 1] == 1)
                    return false;

                if (row > 0 && grid[row - 1, column] == 2)
                    return false;

                if (column > 0 && grid[row, column - 1] == 2)
                    return false;
            }

            if (grid[row, column] == 2)
            {
                if (row > 0 && grid[row - 1, column] == 1)
                    return false;

                if (row > 0 && column < grid.GetLength(0) - 1 && grid[row - 1, column + 1] == 2)
                    return false;

                if (column > 0 && grid[row, column - 1] == 1)
                    return false;
            }
            return true;
        }
    }
}
