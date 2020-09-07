using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1
{
    [TestClass]
    public class twoStrings_test
    {
        public enum TestCaseIndex
        {
            TestCase1,
            TestCase2
        }

        public static readonly List<List<string>> TestCase = new List<List<string>>() {
            new List<string> {"hello", "world"},
            new List<string> {"hi", "world"},
        };

        [DataRow(TestCaseIndex.TestCase1, true)]
        [DataRow(TestCaseIndex.TestCase2, false)]

        [DataTestMethod]
        public async Task ShouldReturnYesOrNo(int testCaseIndex, bool expectYes)
        {
            var testCase = TestCase[testCaseIndex];
            var actual = TwoStrings.GetTwoStrings(testCase.FirstOrDefault(), testCase.LastOrDefault());
            var expected = expectYes ? "YES" : "NO";

            Assert.AreEqual(expected, actual);
        }
    }
}