using System.Collections.Generic;
using BackToBasics.Topics.Design_Patterns.Structural.Facade;
using NUnit.Framework;

namespace BackToBasics.Tests.Design_Patterns.Structural
{
    class FacadeTests
    {
        [Test]
        public void TestFacade()
        {
            var facade = new Facade();

            var a = facade.MethodA(true);
            var testAList = new List<string>
            {
                "MethodA",
                "SubSystemOne Method",
                "SubSystemTwo Method",
                "SubSystemFour Method"
            };
            foreach (var item in testAList)
            {
                    Assert.Contains(item, a);
            }
            var b = facade.MethodB(true);
            var testBList = new List<string>
            {
                "MethodB",
                "SubSystemTwo Method",
                "SubSystemThree Method"
            };
            foreach (var item in testBList)
            {
                Assert.Contains(item, b);
            }
        }

        [Test]
        public void TestBank()
        {
            var mortgage = new Mortgage();

            var customer = new Customer("Ann McKinsey");
            var eligible = mortgage.IsEligible(customer, 125000);
            Assert.True(eligible);
        }
    }
}
