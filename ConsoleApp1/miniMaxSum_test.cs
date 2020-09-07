using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1
{
    [TestClass]
    public class miniMaxSum_test
    {
        public enum TestCaseIndex
        {
            TestCase1,
            TestCase2
        }

        public static readonly List<int[]> TestCase = new List<int[]>() {
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 7, 69, 2, 221, 8974 },
        };

        [DataRow(TestCaseIndex.TestCase1, 10, 14)]
        [DataRow(TestCaseIndex.TestCase2, 299, 9271)]

        [DataTestMethod]
        public async Task ShouldSwap(int testCaseIndex, int min, int max)
        {
            var testCase = TestCase[testCaseIndex];
            var actual = MiniMaxSum.miniMaxSum(testCase);
            var expected = new int[] { min, max };

            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }
    }
}