using System;
using System.Collections.Generic;

namespace Algorithms.Easy
{
    public class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {

            var mainList = new List<int>();

            for(var x = 0; x< numRows;x++)
            {
                var pre = new List<int>();
                var newList = new List<int>();
                for (var j = 1;j < pre.Count-1;j++)
                {
                    var sum = pre[j] + pre[j + 1];
                    newList.Add(sum);
                }
            }
        }
    }
}
