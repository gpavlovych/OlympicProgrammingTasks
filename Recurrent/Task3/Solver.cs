using System;

namespace Task3
{
    /// <summary>
    /// Given by any natural N number, count a number of happy tickets having number of 2*N digits http://algolist.manual.ru/olimp/rec_prb.php#z3
    /// </summary>
    public static class Solver
    {
        public static double Execute(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "N cannot be 0 or negative");
            }

            var s = new double[n + 1][];
            for (var k = 0; k <= n; k++)
            {
                s[k] = new double[10*k];
                for (var i = 0; i < s[k].Length; i++)
                {
                    if (k <= 1)
                    {
                        s[k][i] = 1;
                    }
                    else
                    {
                        s[k][i] = 0;

                        for (var j = Math.Max(0, i - s[k - 1].Length + 1); j <= Math.Min(9, i); j++)
                        {
                            s[k][i] += s[k - 1][i - j];
                        }
                    }
                }
            }

            double result = 0;

            for (var i = 0; i <= 9*n; i++)
            {
                result += s[n][i] * s[n][i];
            }

            return result;
        }
    }
}
