using System.Collections.Generic;
using BackToBasics.Topics.Design_Patterns.Behavioral.State;
using NUnit.Framework;

namespace BackToBasics.Tests.Design_Patterns.Behavioral
{
    class StateTests
    {
        [Test]
        public static void TestState()
        {
            var c = new StateContext(new ConcreteStateA());
            var dict = new Dictionary<bool, string>(){{true, "testInterfaces.Design_Patterns.Behavioral.ConcreteStateA"},{false, "testInterfaces.Design_Patterns.Behavioral.ConcreteStateB" } };
            var i = 0;
            var switcher = false;
            while (i<50)
            {
                StringAssert.AreEqualIgnoringCase(c.Request(true),dict[switcher]);
                switcher = !switcher;
                i++;
            }
        }
        [Test]
        public static void TestBankAccount()
        {
            var account = new Account("Jim Johnson");

            var firstSstate = account.Deposit(500.0, true);
            Assert.AreEqual(firstSstate["deposit"], "500");
            Assert.AreEqual(firstSstate["balance"], "500");
            Assert.AreEqual(firstSstate["state"], "SilverState");
            var secondState = account.Deposit(300.0, true);
            Assert.AreEqual(secondState["deposit"], "300");
            Assert.AreEqual(secondState["balance"], "800");
            Assert.AreEqual(secondState["state"], "SilverState");
            var thirdState = account.Deposit(550.0, true);
            Assert.AreEqual(thirdState["deposit"], "550");
            Assert.AreEqual(thirdState["balance"], "1350");
            Assert.AreEqual(thirdState["state"], "GoldState");
            var fourthState = account.PayInterest(true);
            Assert.AreEqual(fourthState["interest"], "testInterfaces.Design_Patterns.Behavioral.GoldState");
            Assert.AreEqual(fourthState["balance"], "1417.5");
            Assert.AreEqual(fourthState["state"], "GoldState");
            var fifthState = account.Withdraw(2000.00, true);
            Assert.AreEqual(fifthState["withdraw"], "2000");
            Assert.AreEqual(fifthState["balance"], "-582.5");
            Assert.AreEqual(fifthState["state"], "RedState");
            var sixtState = account.Withdraw(1100.00, true);
            Assert.AreEqual(sixtState["withdraw"], "1100");
            Assert.AreEqual(sixtState["balance"], "-582.5");
            Assert.AreEqual(sixtState["state"], "RedState");
        }
    }
}
