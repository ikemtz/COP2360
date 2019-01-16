using NUnit.Framework;
using System;
using System.IO;

namespace Tests
{
    [TestFixture]
    public class StatisticsMethodTest
    {
        [Test]
        public void StatisticsTest()
        {
            int[] nums = new int[10] { 89, 52, 3078, 0, 0, 0, 0, 0, 0, 0 };
            int numElements;
            double avg;
            int sum;
            int high;
            int low;
            numElements = 3;
            IntegerFacts.Statistics(nums, numElements, out high, out low, out sum, out avg);

            Assert.AreEqual(high, 3078);
            Assert.AreEqual(low, 52);
            Assert.AreEqual(sum, 3219);
            Assert.AreEqual(avg, 1073);
        }
    }

    [TestFixture]
    public class FillArrayMethodTest2
    {
        [Test]
        public void FillArrayTest()
        {
            int[] nums = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string consoleInput = "2\n67\n4\n999\n55";
            using (var inputs = new StringReader(consoleInput))
            {
                Console.SetIn(inputs);
                IntegerFacts.FillArray(nums);
                Assert.AreEqual(nums[0], 2);
                Assert.AreEqual(nums[1], 67);
                Assert.AreEqual(nums[2], 4);
                Assert.AreEqual(nums[3], 0);
            }
        }
    }

    [TestFixture]
    public class FillArrayMethodTest
    {
        [Test]
        public void FillArrayTest()
        {
            int[] nums = new int[10];
            string consoleInput = "1\n8\n55\n77\n201\n98\n44\n1054\n893\n99";
            using (var inputs = new StringReader(consoleInput))
            {
                Console.SetIn(inputs);
                IntegerFacts.FillArray(nums);
                Assert.AreEqual(nums[0], 1);
                Assert.AreEqual(nums[1], 8);
                Assert.AreEqual(nums[2], 55);
                Assert.AreEqual(nums[3], 77);
                Assert.AreEqual(nums[4], 201);
                Assert.AreEqual(nums[5], 98);
                Assert.AreEqual(nums[6], 44);
                Assert.AreEqual(nums[7], 1054);
                Assert.AreEqual(nums[8], 893);
                Assert.AreEqual(nums[9], 99);
            }
        }

       
    }
    [TestFixture]
    public class getContestantNumberMethodTest
    {
        [Test]
        public void getContestantNumber()
        {
            string consoleInput = "invalid\n9";
            using (var inputs = new StringReader(consoleInput))
            {
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetIn(inputs);
                    Console.SetOut(sw);
                    int ret;
                    ret = GreenvilleRevenue.getContestantNumber("this", 0, 30);

                    string expected = "Enter number of contestants this year";
                    string expected2 = "invalid";
                    int expReturn = 9;
                    StringAssert.Contains(expected, sw.ToString().Trim());
                    StringAssert.Contains(expected2, sw.ToString().Trim().ToLower());
                    Assert.AreEqual(expReturn, ret);
                }
            }
        }
    }
}