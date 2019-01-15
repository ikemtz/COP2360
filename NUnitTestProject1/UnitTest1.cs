using NUnit.Framework;
using System;
using System.IO;

namespace Tests
{
    [TestFixture]
    public class GetContestantDataMethodTest
    {
        const int MIN_CONTESTANTS = 0;
        const int MAX_CONTESTANTS = 30;
        int numThisYear;
        int numLastYear;
        int revenue;
        string[] names = new string[MAX_CONTESTANTS];
        char[] talents = new char[MAX_CONTESTANTS];
        char[] talentCodes = { 'S', 'D', 'M', 'O' };
        string[] talentCodesStrings = { "Singing", "Dancing", "Musical instrument", "Other" };
        int[] counts = { 0, 0, 0, 0 };
        [Test]
        public void GetContestantDataTest()
        {
            string consoleInput = "Joe\nD\nSara\nS";
            using (var inputs = new StringReader(consoleInput))
            {
                Console.SetIn(inputs);
                GreenvilleRevenue.GetContestantData(2, names, talents, talentCodes, talentCodesStrings, counts);
                Assert.AreEqual(talents[0], 'D');
                Assert.AreEqual(talents[1], 'S');
                Assert.AreEqual(counts[0], 1);
                Assert.AreEqual(counts[1], 1);
                Assert.AreEqual(counts[2], 0);
                Assert.AreEqual(counts[3], 0);
                Assert.AreEqual(names[0], "Joe");
                Assert.AreEqual(names[1], "Sara");
            }
        }
    }

    [TestFixture]
    public class GetListsMethodTest
    {
        const int MIN_CONTESTANTS = 0;
        const int MAX_CONTESTANTS = 30;
        string[] names = new string[MAX_CONTESTANTS];
        char[] talents = new char[MAX_CONTESTANTS];
        char[] talentCodes = { 'S', 'D', 'M', 'O' };
        string[] talentCodesStrings = { "Singing", "Dancing", "Musical instrument", "Other" };
        int[] counts = { 0, 0, 0, 0 };
        [Test]
        public void GetListsTest()
        {
            string consoleInput = "S\nZ";
            using (var inputs = new StringReader(consoleInput))
            {
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetIn(inputs);
                    Console.SetOut(sw);
                    names[0] = "Joe";
                    names[1] = "Ann";
                    talents[0] = 'S';
                    talents[1] = 'M';
                    GreenvilleRevenue.GetLists(5, talentCodes, talentCodesStrings, names, talents, counts);
                    StringAssert.Contains("Joe", sw.ToString());
                    Assert.IsFalse(sw.ToString().Contains("Ann"), "Ann should not be listed in output for singers");
                }
            }

            consoleInput = "M\nZ";
            using (var inputs = new StringReader(consoleInput))
            {
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetIn(inputs);
                    Console.SetOut(sw);
                    names[0] = "Joe";
                    names[1] = "Ann";
                    talents[0] = 'S';
                    talents[1] = 'M';
                    GreenvilleRevenue.GetLists(5, talentCodes, talentCodesStrings, names, talents, counts);
                    StringAssert.Contains("Ann", sw.ToString());
                    Assert.IsFalse(sw.ToString().Contains("Joe"), "Joe should not be listed in output for musicians");
                }
            }
        }
    }

    [TestFixture]
    public class GetContestantNumberMethodTest
    {
        const int MIN_CONTESTANTS = 0;
        const int MAX_CONTESTANTS = 30;
        [Test]
        public void GetContestantNumberTest()
        {
            string consoleInput = "5";
            using (var inputs = new StringReader(consoleInput))
            {
                int returnValue;
                Console.SetIn(inputs);
                returnValue = GreenvilleRevenue.GetContestantNumber("last", MIN_CONTESTANTS, MAX_CONTESTANTS);
                Assert.AreEqual(returnValue, 5);
            }
            consoleInput = "7";
            using (var inputs = new StringReader(consoleInput))
            {
                int returnValue;
                Console.SetIn(inputs);
                returnValue = GreenvilleRevenue.GetContestantNumber("last", MIN_CONTESTANTS, MAX_CONTESTANTS);
                Assert.AreEqual(returnValue, 7);
            }
        }
    }
}