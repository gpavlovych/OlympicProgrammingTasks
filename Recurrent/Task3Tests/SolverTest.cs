using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace Task3Tests
{
    [TestClass]
    public class SolverTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Execute0()
        {
            Assert.AreEqual(0, Solver.Execute(0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExecuteNegative()
        {
            Assert.AreEqual(0, Solver.Execute(-10));
        }

        [TestMethod]
        public void Execute2digit()
        {
            Assert.AreEqual(10, Solver.Execute(1));
        }

        [TestMethod]
        public void Execute4digit()
        {
            Assert.AreEqual(670, Solver.Execute(2));
        }

        [TestMethod]
        public void Execute6digit()
        {
            Assert.AreEqual(55252, Solver.Execute(3));
        }

        [TestMethod]
        public void Execute8digit()
        {
            Assert.AreEqual(4816030, Solver.Execute(4));
        }

        [TestMethod]
        public void Execute10digit()
        {
            Assert.AreEqual(432457640, Solver.Execute(5));
        }

        [TestMethod]
        public void Execute20digit()
        {
            Assert.AreEqual(3.0819189237419E+18, Solver.Execute(10), 0.0000000000001E+18);
        }

        [TestMethod]
        public void Execute200digit()
        {
            Assert.AreEqual(9.81376265729964E+197, Solver.Execute(100), 0.00000000000001E+197);
        }
    }
}
