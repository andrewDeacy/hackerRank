using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1
{

    [TestClass]
    public class birthdayCandles_test
    {
        public enum TestCaseIndex
        {
            TestCase1,
            TestCase2,
        }
        
        public static readonly List<int[]> TestCase = new List<int[]>() {
            new int[] { 4, 4, 1, 3 },
            new int[] { 4, 4, 4, 4, 1 },
        };
        
        [DataRow(TestCaseIndex.TestCase1, 2)]
        [DataRow(TestCaseIndex.TestCase2, 4)]
        [DataTestMethod]
        public void ShouldCountBiggestCandles(int testCaseIndex, int expectedCount)
        {
            var candles = TestCase[testCaseIndex];

            var actualCount = birthdayCandles.birthdayCakeCandles(candles.ToList());

            Assert.AreEqual(expectedCount, actualCount);
        }


    }
}