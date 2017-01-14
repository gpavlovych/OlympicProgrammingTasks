using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace Task1Tests
{
    [TestClass]
    public class SolverTest
    {
        [TestMethod]
        public void ExecuteNegative()
        {
            Assert.AreEqual(0, Solver.Execute(-1));
        }

        [TestMethod]
        public void ExecuteZero()
        {
            Assert.AreEqual(0, Solver.Execute(0));
        }

        [TestMethod]
        public void ExecuteOne()
        {
            Assert.AreEqual(1, Solver.Execute(1));
        }

        [TestMethod]
        public void ExecuteTwo()
        {
            Assert.AreEqual(1.5, Solver.Execute(2));
        }

        [TestMethod]
        public void ExecuteTwoThousands()
        {
            Assert.AreEqual(1.71828182845905, Solver.Execute(2000), 0.00000000000001);
        }
    }
}
