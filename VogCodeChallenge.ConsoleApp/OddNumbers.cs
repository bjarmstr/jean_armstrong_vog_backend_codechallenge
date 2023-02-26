using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogCodeChallenge.ConsoleApp
{
    public static class OddNumbers
    {

        public static long SumOddNumbers()
        {
            var sum = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

    }
}

