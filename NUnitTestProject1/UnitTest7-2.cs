using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnitTestProject7
{
    [TestFixture]
    public class GetMonthMethodTest
    {
        [Test]
        public void GetMonthTest()
        {
            string consoleInput = "8";
            using (var inputs = new StringReader(consoleInput))
            {
                Console.SetIn(inputs);
                int month;
                month = MarshallsRevenue.GetMonth();
                Assert.AreEqual(month, 8);
            }

            consoleInput = "12";
            using (var inputs = new StringReader(consoleInput))
            {
                Console.SetIn(inputs);
                int month;
                month = MarshallsRevenue.GetMonth();
                Assert.AreEqual(month, 12);
            }
        }

        [TestFixture]
        public class GetNumMuralsMethodTest
        {
            [Test]
            public void GetNumMuralsTest()
            {
                string consoleInput = "30";
                using (var inputs = new StringReader(consoleInput))
                {
                    Console.SetIn(inputs);
                    int murals;
                    murals = MarshallsRevenue.GetNumMurals("interior");
                    Assert.AreEqual(30, murals);
                }

                consoleInput = "2";
                using (var inputs = new StringReader(consoleInput))
                {
                    Console.SetIn(inputs);
                    int murals;
                    murals = MarshallsRevenue.GetNumMurals("exterior");
                    Assert.AreEqual(2, murals);
                }
            }
        }

        [TestFixture]
        public class ComputeRevenueMethodTest
        {
            [Test]
            public void ComputeRevenueTest()
            {
                int expected = 3000;
                int total = MarshallsRevenue.ComputeRevenue(6, 3, 2);
                Assert.AreEqual(expected, total);
            }
        }

        [TestFixture]
        public class DataEntryMethodTest
        {
            [Test]
            public void DataEntryTest()
            {
                string consoleInput = "Joe\nS\nSara\nA";
                using (var inputs = new StringReader(consoleInput))
                {
                    Console.SetIn(inputs);

                    const int MAX_MURALS = 30;
                    string[] interiorCustomers = new string[MAX_MURALS];
                    char[] muralCodes = { 'L', 'S', 'A', 'C', 'O' };
                    string[] muralCodesStrings = {"Landscape", "Seascape",
         "Abstract", "Children's", "Other"};
                    char[] interiorCodes = new char[MAX_MURALS];
                    int[] interiorCounts = { 0, 0, 0, 0, 0 };

                    MarshallsRevenue.DataEntry("interior", 2, interiorCustomers, muralCodes, muralCodesStrings, interiorCodes, interiorCounts);
                    Assert.AreEqual(interiorCustomers[0], "Joe");
                    Assert.AreEqual(interiorCustomers[1], "Sara");
                    Assert.AreEqual('S', interiorCodes[0]);
                    Assert.AreEqual('A', interiorCodes[1]);
                    Assert.AreEqual(0, interiorCounts[0]);
                    Assert.AreEqual(1, interiorCounts[1]);
                    Assert.AreEqual(1, interiorCounts[2]);
                    Assert.AreEqual(0, interiorCounts[3]);
                    Assert.AreEqual(0, interiorCounts[4]);
                }


                consoleInput = "Steve Bob\nO";
                using (var inputs = new StringReader(consoleInput))
                {
                    Console.SetIn(inputs);

                    const int MAX_MURALS = 30;
                    string[] interiorCustomers = new string[MAX_MURALS];
                    char[] muralCodes = { 'L', 'S', 'A', 'C', 'O' };
                    string[] muralCodesStrings = {"Landscape", "Seascape",
         "Abstract", "Children's", "Other"};
                    char[] interiorCodes = new char[MAX_MURALS];
                    int[] interiorCounts = { 0, 0, 0, 0, 0 };

                    MarshallsRevenue.DataEntry("interior", 1, interiorCustomers, muralCodes, muralCodesStrings, interiorCodes, interiorCounts);
                    Assert.AreEqual(interiorCustomers[0], "Steve Bob");
                    Assert.AreEqual(interiorCodes[0], 'O');
                    Assert.AreEqual(0, interiorCounts[0]);
                    Assert.AreEqual(0, interiorCounts[1]);
                    Assert.AreEqual(0, interiorCounts[2]);
                    Assert.AreEqual(0, interiorCounts[3]);
                    Assert.AreEqual(1, interiorCounts[4]);
                }
            }
        }

        [TestFixture]
        public class GetSelectedMuralsMethodTest
        {
            [Test]
            public void GetSelectedMuralsTest()
            {
                string consoleInput = "C\nZ";
                using (var inputs = new StringReader(consoleInput))
                {
                    using (StringWriter sw = new StringWriter())
                    {
                        Console.SetIn(inputs);
                        Console.SetOut(sw);

                        const int MAX_MURALS = 30;
                        string[] interiorCustomers = new string[MAX_MURALS];
                        string[] exteriorCustomers = new string[MAX_MURALS];
                        char[] muralCodes = { 'L', 'S', 'A', 'C', 'O' };
                        string[] muralCodesStrings = {"Landscape", "Seascape",
         "Abstract", "Children's", "Other"};
                        char[] interiorCodes = new char[MAX_MURALS];
                        char[] exteriorCodes = new char[MAX_MURALS];

                        interiorCustomers[0] = "Katie";
                        interiorCodes[0] = 'C';
                        MarshallsRevenue.GetSelectedMurals(muralCodes, muralCodesStrings, 1, 0, interiorCustomers, interiorCodes, exteriorCustomers, exteriorCodes);

                        StringAssert.Contains("Katie", sw.ToString());
                        StringAssert.Contains("interior", sw.ToString().ToLower());
                        Assert.IsFalse(sw.ToString().ToLower().Contains("exterior"), "There should be no customers who ordered an exterior mural of this type");
                    }
                }


                using (var inputs = new StringReader(consoleInput))
                {
                    using (StringWriter sw = new StringWriter())
                    {
                        Console.SetIn(inputs);
                        Console.SetOut(sw);

                        const int MAX_MURALS = 30;
                        string[] interiorCustomers = new string[MAX_MURALS];
                        string[] exteriorCustomers = new string[MAX_MURALS];
                        char[] muralCodes = { 'L', 'S', 'A', 'C', 'O' };
                        string[] muralCodesStrings = {"Landscape", "Seascape",
         "Abstract", "Children's", "Other"};
                        char[] interiorCodes = new char[MAX_MURALS];
                        char[] exteriorCodes = new char[MAX_MURALS];

                        exteriorCustomers[0] = "George";
                        exteriorCodes[0] = 'C';
                        MarshallsRevenue.GetSelectedMurals(muralCodes, muralCodesStrings, 0, 1, interiorCustomers, interiorCodes, exteriorCustomers, exteriorCodes);

                        StringAssert.Contains("George", sw.ToString());
                        StringAssert.Contains("exterior", sw.ToString().ToLower());
                        Assert.IsFalse(sw.ToString().ToLower().Contains("interior"), "There should be no customers who ordered an interior mural of this type");
                    }
                }
            }
        }

    }
}
