using NUnit.Framework;

namespace testInterfaces.Design_Patterns.Behavioral
{
    class VisitorTests
    {
        [Test]
        static void TestVisitors()
        {
            // Setup structure
            ObjectStructure o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            // Create visitor objects
            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            // Structure accepting visitors
            o.Accept(v1);
            o.Accept(v2);
        }
        [Test]
        static void TestVacations()
        {
            // Setup employee collection
            EmployeeVs e = new EmployeeVs();
            e.Attach(new ClerkV());
            e.Attach(new DirectorV());
            e.Attach(new PresidentV());

            // Employees are 'visited'
            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());
        }
    }
}
