using System;

namespace Task3
{
    /// <summary>
    /// Given by any natural N number, count a number of happy tickets having number of 2*N digits http://algolist.manual.ru/olimp/rec_prb.php#z3
    /// </summary>
    public static class Solver
    {
        public static int Execute(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "N cannot be 0 or negative");
            }

            var p = 0;
            for (var i = 0; i <= 9*n; i++)
            {
                var s = Solver.S(n, i);
                s *= s;
                p += s;
            }
            return p;
        }

        /// <summary>
        /// Number of k-digit numbers having sum i.
        /// </summary>
        /// <param name="k">The k.</param>
        /// <param name="i">The i.</param>
        /// <returns>The number.</returns>
        private static int S(int k, int i)
        {
            if (k <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(k), "k should be positive");
            }

            if (i < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(i), "i should be non-negative");
            }

            if (k == 1)
            {
                if (i <= 9)
                {
                    return 1;
                }

                return 0;
            }

            var sum = 0;
            for (var j = 0; j <= Math.Min(9, i); j++)
            {
                sum += Solver.S(k - 1, i - j);
            }

            return sum;
        }
    }
}
