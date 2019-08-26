using System;
using System.Collections.Generic;

namespace Algorithms.Amazon.AmazonOnlineAssessment
{
    public class TreasureIslandClass
    {
        public  int TreasureIsland(char[][] island)
        {
            if (island == null || island.Length == 0) return 0;

            bool[,] visited = new bool[island.Length,island[0].Length];
            Coordinate coordinateInital = new Coordinate(0, 0);

            int[][] dirs = new int[][] { new int[2] { 1, 0 }, new int[2] { -1, 0 }, new int[2] { 0, 1 }, new int[2] { 0, -1 } };
            Queue<Coordinate> coordinates = new Queue<Coordinate>();
            coordinates.Enqueue(coordinateInital);
            int steps = 0;

            while(coordinates.Count > 0)
            {
                int size = coordinates.Count;
                for(var i=0;i<size;i++)
                {
                    Coordinate coordinate = coordinates.Dequeue();
                    int x = coordinate.x;
                    int y = coordinate.y;

                    if (island[x][y] == 'X') return steps;

                    foreach(var dir in dirs)
                    {
                        int newX = x + dir[0];
                        int newY = y + dir[1];

                        if (newX >= 0 && newX < island.Length && newY >= 0 && newY < island[0].Length &&
                                island[newX][newY] != 'D' && !visited[newX,newY])
                        {
                            coordinates.Enqueue(new Coordinate(newX, newY));
                            visited[newX,newY] = true;
                        }
                    }
                }
                steps++;
            }


            return 0;
        }
    }

    public class Coordinate
    {
        public int x;
        public int y;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
