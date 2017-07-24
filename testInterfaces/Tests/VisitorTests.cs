using NUnit.Framework;

namespace testInterfaces.Design_Patterns.Behavioral
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

            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());
        }
    }
}
