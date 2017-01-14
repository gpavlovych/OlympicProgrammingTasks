using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task2Tests
{
    [TestClass]
    public class SolverTest
    {
        private const int CorrectAnswer = 55252;

        [TestMethod]
        public void ExecuteObvious10To6()
        {
            Assert.AreEqual(SolverTest.CorrectAnswer, Task2.Solver.ExecuteObvious10To6());
        }

        [TestMethod]
        public void Execute10To5()
        {
            Assert.AreEqual(SolverTest.CorrectAnswer, Task2.Solver.Execute10To5());
        }

        [TestMethod]
        public void Execute10To3()
        {
            Assert.AreEqual(SolverTest.CorrectAnswer, Task2.Solver.Execute10To3());
        }

        [TestMethod]
        public void Execute140()
        {
            Assert.AreEqual(SolverTest.CorrectAnswer, Task2.Solver.Execute140());
        }
    }
}