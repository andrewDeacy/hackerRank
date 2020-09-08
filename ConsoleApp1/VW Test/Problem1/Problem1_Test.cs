using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.VW_Test.Problem1
{
    [TestClass]
    public class Problem1_Test
    {
        public enum TestCaseIndex
        {
            TestCase1,
            TestCase2,
            TestCase3,
            TestCase4,
        }

        public static readonly List<int[]> TestCase = new List<int[]>() {
            new int[] { 4, 3, 1, 2 },
            new int[] { 2, 3, 4, 1, 5 },
            new int[] { 1, 3, 5, 2, 4, 6, 7 },
            new int[] { 1, 4, 3, 2}
        };

        [DataRow(TestCaseIndex.TestCase1, 3)]
        [DataRow(TestCaseIndex.TestCase2, 3)]
        [DataRow(TestCaseIndex.TestCase3, 3)]
        [DataRow(TestCaseIndex.TestCase4, 1)]

        [DataTestMethod]
        public async Task Problem1ShouldWork(int testCaseIndex, int expected)
        {
            var testCase = TestCase[testCaseIndex];
            
            var actual = Problem1.GetProblem1Answer(testCase);

            Assert.AreEqual(expected, actual);
        }
    }
}