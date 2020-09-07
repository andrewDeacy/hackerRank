using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1
{
    [TestClass]
    public class matchingStrings_test
    {

        public enum TestCaseIndex
        {
            TestCase1,
            TestCase2,
            TestCase3,
            TestCase4,
        }

            public static readonly List<Tuple<string[],string[], int[]>> TestCase = new List<Tuple<string[],string[], int[]>> {
                Tuple.Create(new [] { "aba", "baba", "aba", "xzxb" }, new [] { "aba", "xzxb", "ab" }, new [] { 2, 1, 0 }),
                Tuple.Create(new [] { "def", "de", "fgh" }, new [] { "de", "lmn", "fgh" }, new [] { 1, 0, 1 }),
                Tuple.Create(new [] { "abcde", "sdaklfj", "asdjf", "na", "basdn", "sdaklfj", "asdjf", "na", "asdjf", "na", "basdn", "sdaklfj", "asdjf" },
                    new [] { "abcde", "sdaklfj", "asdjf", "na", "basdn", }, new [] { 1, 3, 4, 3, 2 })
            };

            [DataRow(TestCaseIndex.TestCase1)]
            [DataRow(TestCaseIndex.TestCase2)]
            [DataRow(TestCaseIndex.TestCase3)]
            [DataTestMethod]
            public async Task ShouldSwap(int testCaseIndex)
            {
                var strings = TestCase[testCaseIndex].Item1;
                var queries = TestCase[testCaseIndex].Item2;
                var expectedMatches = TestCase[testCaseIndex].Item3;

                var actualMatches = MatchingStrings.getMatchingStrings(strings, queries);

                Assert.AreEqual(expectedMatches[0], actualMatches[0]);
                Assert.AreEqual(expectedMatches[1], actualMatches[1]);
                Assert.AreEqual(expectedMatches[2], actualMatches[2]);
            }
        }
}
