using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using testInterfaces.Design_Patterns.Structural;

namespace testInterfaces.Design_Patterns.Behavioral
{
    class BridgeTests
    {
        [Test]
        public static void TestBridgeAbstraction()
        {
            Abstraction ab = new RefinedAbstraction();

            ab.Implementor = new ConcreteImplementorA();
            StringAssert.AreEqualIgnoringCase(ab.Operation(true), "ConcreteImplementorA Operation");

            ab.Implementor = new ConcreteImplementorB();
            StringAssert.AreEqualIgnoringCase(ab.Operation(true), "ConcreteImplementorB Operation");
        }
        [Test]
        public static void TestCustomers()
        {
            var customers = new Customers("Chicago") {Data = new CustomersData()};
            StringAssert.AreEqualIgnoringCase(customers.Show(true), "Jim Jones");
            customers.Next();
            StringAssert.AreEqualIgnoringCase(customers.Show(true), "Samual Jackson");
            customers.Next();
            StringAssert.AreEqualIgnoringCase(customers.Show(true), "Allen Good");
            customers.Add("Henry Velasquez");
            Assert.True(customers.GetAll().Contains("Henry Velasquez"));
        }
    }
}
