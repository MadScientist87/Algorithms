using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Easy
{
    public class Pascaltriangle2
    {
        public IList<int> GetRow(int rowIndex)
        {
            List<int> list = new List<int>(rowIndex + 1);
            list.Add(1);
            for (int r = 1; r < rowIndex + 1; r++)
            {
                long prev = ((long)list[r - 1]);
                int val = (int)((prev * (rowIndex - r + 1)) / (r));
                list.Add(val);
            }
            return list;
        }

    }
}
