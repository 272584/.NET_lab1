using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnapsackProblem;

namespace KnapsackTests
{
    [TestClass]
    public class ProblemTests
    {
        [TestMethod]
        public void TestNonEmptySolution()
        {
            Problem problem = new Problem(5, 42);
            Result result = problem.Solve(15);
            Assert.IsTrue(result.SelectedItems.Count > 0, "At least one item should be selected.");
        }

        [TestMethod]
        public void TestEmptySolution()
        {
            Problem problem = new Problem(5, 42);
            Result result = problem.Solve(0);
            Assert.AreEqual(0, result.SelectedItems.Count, "No items should be selected when capacity is zero.");
        }

        [TestMethod]
        public void TestSpecificInstance()
        {
            Problem problem = new Problem(3, 1);
            Result result = problem.Solve(10);
            Assert.IsTrue(result.TotalWeight <= 10, "Total weight should not exceed capacity.");
        }
    }
}
