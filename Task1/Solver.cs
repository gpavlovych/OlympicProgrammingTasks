using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Solver for Task1: given by k, evaluate 1/1!+1/2!+..+1/k!
    /// </summary>
    public class Solver
    {
        public static double Execute(int k)
        {
            double s = 0.0;
            double p = 1.0;

            for (var i = 1; i <= k; i++)
            {
                p *= i;
                s += 1.0/p;
            }

            return s;
        }
    }
}
