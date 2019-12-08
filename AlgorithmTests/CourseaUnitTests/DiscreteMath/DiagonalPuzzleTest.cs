using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Coursea.DiscreteMath;
using System.Collections.Generic;
namespace AlgorithmTests.CourseaUnitTests.DiscreteMath
{
    [TestClass]
    public class DiagonalPuzzleTest
    {
        [TestMethod]
        public void DiagonalPuzzleTestMethod()
        {
            var grid = new int[5, 5];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = -1;
                }
            }
            DiagonalPuzzle.Extend( grid,0, 0, 16);
        }
    }
}
