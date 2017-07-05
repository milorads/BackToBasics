using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testInterfaces.Design_Patterns.Structural
{
    #region Structure code
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    class Abstraction
    {
        protected Implementor implementor;

        // Property
        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }

        public virtual string Operation(bool test)
        {
            return implementor.Operation(test);
        }
    }

    /// <summary>
    /// The 'Implementor' abstract class
    /// </summary>
    abstract class Implementor
    {
        public abstract void Operation();
        public abstract string Operation(bool test);
    }

    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }

    /// <summary>
    /// The 'ConcreteImplementorA' class
    /// </summary>
    class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }

        public override string Operation(bool test)
        {
            return "ConcreteImplementorA Operation";
        }
    }

    /// <summary>
    /// The 'ConcreteImplementorB' class
    /// </summary>
    class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
        public override string Operation(bool test)
        {
            return "ConcreteImplementorB Operation";
        }
    }
    #endregion

    #region Implementation code
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    class CustomersBase
    {
        private DataObject _dataObject;
        protected string group;

        public CustomersBase(string group)
        {
            this.group = group;
        }

        // Property
        public DataObject Data
        {
            set => _dataObject = value;
            get => _dataObject;
        }

        public virtual void Next()
        {
            _dataObject.NextRecord();
        }

        public virtual void Prior()
        {
            _dataObject.PriorRecord();
        }

        public virtual void Add(string customer)
        {
            _dataObject.AddRecord(customer);
        }

        public virtual void Delete(string customer)
        {
            _dataObject.DeleteRecord(customer);
        }

        public virtual void Show()
        {
            _dataObject.ShowRecord();
        }

        public virtual string Show(bool test)
        {
            return _dataObject.ShowRecord(test);
        }

        public virtual void ShowAll()
        {
            Console.WriteLine("Customer Group: " + group);
            _dataObject.ShowAllRecords();
        }

        public virtual List<string> GetAll()
        {
            return _dataObject.GetAllRecords();
        }
    }

    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    class Customers : CustomersBase
    {
        // Constructor
        public Customers(string group)
          : base(group)
        {
        }

        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }

        public override List<string> GetAll()
        {
            return base.GetAll();
        }
    }

    /// <summary>
    /// The 'Implementor' abstract class
    /// </summary>
    abstract class DataObject
    {
        public abstract void NextRecord();
        public abstract void PriorRecord();
        public abstract void AddRecord(string name);
        public abstract void DeleteRecord(string name);
        public abstract void ShowRecord();
        public abstract string ShowRecord(bool test);
        public abstract void ShowAllRecords();
        public abstract List<string> GetAllRecords();
    }

    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    class CustomersData : DataObject
    {
        private List<string> _customers = new List<string>();
        private int _current = 0;

        public CustomersData()
        {
            // Loaded from a database
            _customers.Add("Jim Jones");
            _customers.Add("Samual Jackson");
            _customers.Add("Allen Good");
            _customers.Add("Ann Stills");
            _customers.Add("Lisa Giolani");
        }

        public override void NextRecord()
        {
            if (_current <= _customers.Count - 1)
            {
                _current++;
            }
        }

        public override void PriorRecord()
        {
            if (_current > 0)
            {
                _current--;
            }
        }

        public override void AddRecord(string customer)
        {
            _customers.Add(customer);
        }

        public override void DeleteRecord(string customer)
        {
            _customers.Remove(customer);
        }

        public override void ShowRecord()
        {
            Console.WriteLine(_customers[_current]);
        }

        public override string ShowRecord(bool test)
        {
            return _customers[_current];
        }

        public override void ShowAllRecords()
        {
            foreach (var customer in _customers)
            {
                Console.WriteLine(" " + customer);
            }
        }

        public override List<string> GetAllRecords()
        {
            return _customers;
        }
    }
    #endregion
}
