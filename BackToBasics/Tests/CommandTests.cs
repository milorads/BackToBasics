
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace testInterfaces.Design_Patterns.Behavioral
{
    class CommandTests
    {
        [Test]
        public static void TestCommands()
        {
            SampleCommand command = new SampleConcreteCommand(new Receiver());
            var invoker = new Invoker();

            invoker.SetCommand(command);
            StringAssert.AreEqualIgnoringCase(invoker.ExecuteCommand(true), "Called Receiver.Action()");
        }
        [Test]
        public static void TestUserComputation()
        {
            User user = new User();
            var testValQueue = new List<int>();
            var testVal = 0;
            testValQueue.Add(testVal);
            Assert.AreEqual(user.Compute('+', 100, true), testVal += 100);
            testValQueue.Add(testVal);
            Assert.AreEqual(user.Compute('-', 50, true), testVal -= 50);
            testValQueue.Add(testVal);
            Assert.AreEqual(user.Compute('*', 10, true), testVal *= 10);
            testValQueue.Add(testVal);
            Assert.AreEqual(user.Compute('/', 2, true), testVal /+2);
            testValQueue.Add(testVal);

            var undos = user.Undo(4, true);
            if (undos.Where(s => testValQueue.Contains(s)).ToList().Count < 4)
            {
                Assert.Fail();
            }

            var redos = user.Redo(3, true);
            if (redos.Where(s => testValQueue.Contains(s)).ToList().Count < 3)
            {
                Assert.Fail();
            }
        }
    }
}
