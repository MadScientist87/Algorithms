using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Easy
{
    public class CountAndSayClass
    {
        public string CountAndSay(int n)
        {
            var answer = "";
            while (n != 0)
            {
                answer = CountAndSayGetNext(answer);
                n--;
            }
            return answer;
        }

        private string CountAndSayGetNext(string sequence)
        {
            if( string.IsNullOrEmpty(sequence)) return "1";
            char current = sequence[0];
            char stepAhead = ' ';
            string answer = "";
            int counter = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (i < sequence.Length - 1)
                    stepAhead = sequence[i + 1];
                if (sequence[i] == current)
                    counter++;

                if (stepAhead != current && stepAhead != ' ')
                {
                    answer += counter + current.ToString();
                    counter = 0;

                    current = stepAhead;
                }

                if (i == sequence.Length - 1)
                    answer += counter + current.ToString();
            }

            return answer;

        }
    }
}
