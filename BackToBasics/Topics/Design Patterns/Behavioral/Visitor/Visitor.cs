using System;
using System.Collections.Generic;
using System.Linq;

namespace BackToBasics.Topics.Design_Patterns.Behavioral.Visitor
{
    #region Sample code
    /// <summary>
    /// The 'Visitor' abstract class
    /// </summary>
    abstract class Visitor
    {
        public abstract void VisitConcreteElementA(
            ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(
            ConcreteElementB concreteElementB);
        public virtual string VisitConcreteElementA(ConcreteElementA concreteElementA, bool test)
        {
            return $"{concreteElementA.GetType().Name} visited by {this.GetType().Name}";
        }
        public virtual string VisitConcreteElementB(ConcreteElementB concreteElementB, bool test)
        {
            return $"{concreteElementB.GetType().Name} visited by {this.GetType().Name}";
        }
    }

    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(
            ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visited by {1}",
                concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(
            ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visited by {1}",
                concreteElementB.GetType().Name, this.GetType().Name);
        }
    }

    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(
            ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visited by {1}",
                concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(
            ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visited by {1}",
                concreteElementB.GetType().Name, this.GetType().Name);
        }
    }

    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
        public abstract string Accept(Visitor visitor, bool test);
    }

    /// <summary>
    /// A 'ConcreteElement' class
    /// </summary>
    class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public override string Accept(Visitor visitor, bool test)
        {
            return visitor.VisitConcreteElementA(this, test);
        }

        public void OperationA()
        {
        }
    }

    /// <summary>
    /// A 'ConcreteElement' class
    /// </summary>
    class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB()
        {
        }
        public override string Accept(Visitor visitor, bool test)
        {
            return visitor.VisitConcreteElementB(this, test);
        }
    }

    /// <summary>
    /// The 'ObjectStructure' class
    /// </summary>
    class ObjectStructure
    {
        private List<Element> _elements = new List<Element>();

        public void Attach(Element element)
        {
            _elements.Add(element);
        }
        public Element Attach(Element element, bool test)
        {
            _elements.Add(element);
            return element;
        }

        public void Detach(Element element)
        {
            _elements.Remove(element);
        }
        public Element Detach(Element element, bool test)
        {
            _elements.Remove(element);
            return element;
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element element in _elements)
            {
                element.Accept(visitor);
            }
        }
        public string Accept(Visitor visitor, bool test)
        {
            return _elements.Aggregate("", (current, element) => current + (element.Accept(visitor, test) + "\r\n"));
        }
    }
    #endregion

    #region Implementation code
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    interface IVisitor
    {
        void Visit(ElementV element);
        string Visit(ElementV element, bool test);
    }

    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    class IncomeVisitor : IVisitor
    {
        public void Visit(ElementV element)
        {
            EmployeeV employee = element as EmployeeV;

            // Provide 10% pay raise
            employee.Income *= 1.10;
            Console.WriteLine("{0} {1}'s new income: {2:C}",
                employee.GetType().Name, employee.Name,
                employee.Income);
        }

        public string Visit(ElementV element, bool test)
        {
            EmployeeV employee = element as EmployeeV;

            // Provide 10% pay raise
            employee.Income *= 1.10;
            return ($"{employee.GetType().Name} {employee.Name}'s new income: {employee.Income:C}");
        }
    }

    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    class VacationVisitor : IVisitor
    {
        public void Visit(ElementV element)
        {
            EmployeeV employee = element as EmployeeV;

            // Provide 3 extra vacation days
            employee.VacationDays += 3;
            Console.WriteLine("{0} {1}'s new vacation days: {2}",
                employee.GetType().Name, employee.Name,
                employee.VacationDays);
        }
        public string Visit(ElementV element, bool test)
        {
            EmployeeV employee = element as EmployeeV;

            // Provide 3 extra vacation days
            employee.VacationDays += 3;
            return $"{employee.GetType().Name} {employee.Name}'s new vacation days: {employee.VacationDays}";
        }
    }

    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    abstract class ElementV
    {
        public abstract void Accept(IVisitor visitor);
        public abstract string Accept(IVisitor visitor, bool test);
    }

    /// <summary>
    /// The 'ConcreteElement' class
    /// </summary>
    class EmployeeV : ElementV
    {
        private string _name;
        private double _income;
        private int _vacationDays;

        // Constructor
        public EmployeeV(string name, double income,
            int vacationDays)
        {
            this._name = name;
            this._income = income;
            this._vacationDays = vacationDays;
        }

        // Gets or sets the name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Gets or sets income
        public double Income
        {
            get { return _income; }
            set { _income = value; }
        }

        // Gets or sets number of vacation days
        public int VacationDays
        {
            get { return _vacationDays; }
            set { _vacationDays = value; }
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string Accept(IVisitor visitor, bool test)
        {
            return visitor.Visit(this, test);
        }
    }

    /// <summary>
    /// The 'ObjectStructure' class
    /// </summary>
    class EmployeeVs
    {
        private List<EmployeeV> _employees = new List<EmployeeV>();

        public void Attach(EmployeeV employee)
        {
            _employees.Add(employee);
        }

        public void Detach(EmployeeV employee)
        {
            _employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (EmployeeV e in _employees)
            {
                e.Accept(visitor);
            }
            Console.WriteLine();
        }

        public string Accept(IVisitor visitor, bool test)
        {
            var outString = "";
            foreach (EmployeeV e in _employees)
            {
                outString += e.Accept(visitor, true) + "\r\n";
            }
            return outString;
        }
    }

    // Three employee types

    class ClerkV : EmployeeV
    {
        // Constructor
        public ClerkV()
            : base("Hank", 25000.0, 14)
        {
        }
    }

    class DirectorV : EmployeeV
    {
        // Constructor
        public DirectorV()
            : base("Elly", 35000.0, 16)
        {
        }
    }

    class PresidentV : EmployeeV
    {
        // Constructor
        public PresidentV()
            : base("Dick", 45000.0, 21)
        {
        }
    }
    #endregion
}
