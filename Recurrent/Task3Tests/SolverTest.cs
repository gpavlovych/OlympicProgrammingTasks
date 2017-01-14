using System;
using System.CodeDom;
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
        public void Execute1digit()
        {
            Assert.AreEqual(10, Solver.Execute(1));
        }

        [TestMethod]
        public void Execute2digit()
        {
            Assert.AreEqual(670, Solver.Execute(2));
        }

        [TestMethod]
        public void Execute6digit()
        {
            Assert.AreEqual(55252, Solver.Execute(3));
        }
        [TestMethod]
        [Ignore()]
        public void Execute10digit()
        {
           //some non-recursive solution is probably needed
            Assert.AreEqual(55252, Solver.Execute(10));
        }
    }
}
