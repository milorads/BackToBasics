using System;
using System.Linq;
using NUnit.Framework;
using testInterfaces.Tests;
using static System.String;

namespace testInterfaces.Design_Patterns.Behavioral
{
    class ObserverTests
    {
        [Test]
        public static void TestObservers()
        {
            var s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            s.SubjectState = "ABC";
            var dict = s.Notify(true);
            foreach (var dictVal in dict)
            {
                StringAssert.AreEqualIgnoringCase(dictVal.Value, "ABC");
            }
        }
        [Test]
        public static void TestInvestors()
        {
            var ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));
            using (var consoleOutput = new TestHelper.ConsoleOutput())
            {
                ibm.Price = 120.10;
                ibm.Price = 121.00;
                ibm.Price = 120.50;
                ibm.Price = 120.75;
                var consoleLogLines = consoleOutput.GetOuput().Split(Environment.NewLine.ToCharArray()).ToList();
                consoleLogLines.RemoveAll(IsNullOrEmpty);
                foreach (var line in consoleLogLines)
                {
                    Assert.True(line.Contains("IBM") && (line.Contains("Sorros") || line.Contains("Berkshire")) &&
                                (line.Contains("120.10") || line.Contains("121.00") || line.Contains("120.50") || line.Contains("120.75")));
                }
                consoleOutput.Dispose();
            }


            ibm.Attach(new Investor("Another"));
            using (var consoleOutput = new TestHelper.ConsoleOutput())
            {
                ibm.Price = 99.99;
                var consoleLogLines = consoleOutput.GetOuput().Split(Environment.NewLine.ToCharArray()).ToList();
                consoleLogLines.RemoveAll(IsNullOrEmpty);
                var lastLine = consoleLogLines.LastOrDefault();
                if (lastLine == null) Assert.Fail();
                Assert.True(lastLine.Contains("IBM") && lastLine.Contains("99.99") && lastLine.Contains("Another"));
            }
        }
    }
}
