using System;

namespace Task2
{
    /// <summary>
    /// Counting a number of 6-digit happy tickets (sum of the first 3 digits is equal to the sum of last 3 digits).
    /// Refer to http://algolist.manual.ru/olimp/rec_sol.php#a2 for more details.
    /// </summary>
    public static class Solver
    {
        /// <summary>
        /// Obvious and less optimal solution with 10^6 complexity.
        /// </summary>
        /// <returns></returns>
        public static int ExecuteObvious10To6()
        {
            var result = 0;
            for (var i1 = 0; i1 <= 9; i1++)
            {
                for (var i2 = 0; i2 <= 9; i2++)
                {
                    for (var i3 = 0; i3 <= 9; i3++)
                    {
                        for (var i4 = 0; i4 <= 9; i4++)
                        {
                            for (var i5 = 0; i5 <= 9; i5++)
                            {
                                for (var i6 = 0; i6 <= 9; i6++)
                                {
                                    if (i1 + i2 + i3 == i4 + i5 + i6)
                                    {
                                        result++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// More optimal solution with 10^5 complexity.
        /// </summary>
        /// <returns></returns>
        public static int Execute10To5()
        {
            var result = 0;
            for (var i1 = 0; i1 <= 9; i1++)
            {
                for (var i2 = 0; i2 <= 9; i2++)
                {
                    for (var i3 = 0; i3 <= 9; i3++)
                    {
                        for (var i4 = 0; i4 <= 9; i4++)
                        {
                            for (var i5 = 0; i5 <= 9; i5++)
                            {
                                var i6 = (i1 + i2 + i3) - (i4 + i5);
                                if ((0 <= i6) && (i6 <= 9))
                                {
                                    result++;
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Solution with 10^3 complexity.
        /// </summary>
        /// <returns></returns>
        public static int Execute10To3()
        {
            int[] c = new int[14];

            for (var t = 0; t < c.Length; t++)
            {
                c[t] = 0;
            }

            for (var i1 = 0; i1 <= 9; i1++)
            {
                for (var i2 = 0; i2 <= 9; i2++)
                {
                    for (var i3 = 0; i3 <= 9; i3++)
                    {
                        var t = i1 + i2 + i3;
                        if (t < c.Length)
                        {
                            c[t]++;
                        }
                    }
                }
            }

            int result = 0;
            foreach (int ct in c)
            {
                result += ct*ct;
            }

            result *= 2;
            return result;
        }

        /// <summary>
        /// Solution with 140 complexity.
        /// </summary>
        /// <returns></returns>
        public static int Execute140()
        {
            var result = 0;
            for (var t = 0; t <= 13; t++)
            {
                var ct = 0;
                for (var a1 = Math.Max(0, t - 18); a1 <= Math.Min(9, t); a1++)
                    {
                        ct = ct + Math.Min(9, t - a1) - Math.Max(0, t - a1 - 9) + 1;
                    }

                result = result + ct*ct;
            }

            result = result * 2;
            return result;
        }
    }
}