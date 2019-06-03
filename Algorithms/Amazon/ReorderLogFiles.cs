using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Amazon
{
    public class ReorderLogFilesClass
    {

        // Compareto reference
        //https://docs.microsoft.com/en-us/dotnet/api/system.string.compareto?view=netframework-4.8

        public string[] ReorderLogFiles(string[] logs)
        {
            var alphaList = new List<string>();
            var numericList = new List<string>();
            for (var x=0; x< logs.Length; x++)
            {
                var IdAnfFirstElement = logs[x].Split(" ", 2);
                bool isDigit = Char.IsDigit(IdAnfFirstElement[1][0]);
                if (!isDigit)
                    alphaList.Add(logs[x]);
                else
                    numericList.Add(logs[x]);
            }

            var alphaListArray = alphaList.ToArray();
            Array.Sort(alphaListArray, (a, b) =>
            {
               
                var IdAnfFirstElement1 = a.Split(" ", 2);
                var IdAnfFirstElement2 = b.Split(" ", 2);

                bool isDigit1 = Char.IsDigit(IdAnfFirstElement1[1][0]);
                bool isDigit2 = Char.IsDigit(IdAnfFirstElement2[1][0]);

                if (!isDigit1 && !isDigit2)
                {
                    int cmp = IdAnfFirstElement1[1].CompareTo(IdAnfFirstElement2[1]);
                    if (cmp != 0) return cmp;
                    return IdAnfFirstElement1[0].CompareTo(IdAnfFirstElement2[0]);
                }
                return isDigit1 ? (isDigit2 ? 0 : 1) : -1;
            });

            var z = new string[alphaListArray.Length + numericList.Count];
            alphaListArray.CopyTo(z, 0);
            numericList.CopyTo(z, alphaListArray.Length);

            return z;
        }

    }
}
