
using NUnit.Framework;

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
            s.Notify();
        }
        [Test]
        public static void TestInvestors()
        {
            var ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            ibm.Attach(new Investor("Another"));
            ibm.Price = 99.99;
        }
    }
}
