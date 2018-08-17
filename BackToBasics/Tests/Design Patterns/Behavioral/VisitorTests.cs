using BackToBasics.Topics.Design_Patterns.Behavioral.Visitor;
using NUnit.Framework;

namespace BackToBasics.Tests.Design_Patterns.Behavioral
{
    class VisitorTests
    {
        [Test]
        public static void TestVisitors()
        {

            var o = new ObjectStructure();
            var celA = new ConcreteElementA();
            var celB = new ConcreteElementB();
            Assert.AreSame(o.Attach(celA, true), celA);
            Assert.AreSame(o.Attach(celB, true),celB);

            var v1 = new ConcreteVisitor1();
            var v2 = new ConcreteVisitor2();

            var test1 =o.Accept(v1, true);
            StringAssert.AreEqualIgnoringCase(test1, "ConcreteElementA visited by ConcreteVisitor1\r\nConcreteElementB visited by ConcreteVisitor1\r\n");
            var test2 = o.Accept(v2, true);
            StringAssert.AreEqualIgnoringCase(test2, "ConcreteElementA visited by ConcreteVisitor2\r\nConcreteElementB visited by ConcreteVisitor2\r\n");
        }
        [Test]
        public static void TestVacations()
        {
            var e = new EmployeeVs();
            e.Attach(new ClerkV());
            e.Attach(new DirectorV());
            e.Attach(new PresidentV());

            var firstAccept = e.Accept(new IncomeVisitor(), true);
            StringAssert.AreEqualIgnoringCase("ClerkV Hank's new income: $27,500.00\r\nDirectorV Elly's new income: $38,500.00\r\nPresidentV Dick's new income: $49,500.00\r\n", firstAccept);
            var secondAccept = e.Accept(new VacationVisitor(), true);
            StringAssert.AreEqualIgnoringCase("ClerkV Hank's new vacation days: 17\r\nDirectorV Elly's new vacation days: 19\r\nPresidentV Dick's new vacation days: 24\r\n", secondAccept);
        }
    }
}
