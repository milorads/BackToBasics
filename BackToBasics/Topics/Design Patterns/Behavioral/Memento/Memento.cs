using System;

namespace testInterfaces.Design_Patterns.Behavioral
{
    #region Sample Code
    /// <summary>
    /// The 'Originator' class
    /// </summary>
    class Originator
    {
        private string _state;

        // Property
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State = " + _state);
            }
        }

        // Creates memento
        public SampleMemento CreateMemento()
        {
            return (new SampleMemento(_state));
        }

        // Restores original state
        public void SetMemento(SampleMemento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }

    /// <summary>
    /// The 'Memento' class
    /// </summary>
    class SampleMemento
    {
        private string _state;

        // Constructor
        public SampleMemento(string state)
        {
            _state = state;
        }

        // Gets or sets state
        public string State => _state;
    }

    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    class Caretaker
    {
        private SampleMemento _memento;

        // Gets or sets memento
        public SampleMemento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
    #endregion

    #region Implementation code
    /// <summary>
    /// The 'Originator' class
    /// </summary>
    class SalesProspect
    {
        private string _name;
        private string _phone;
        private double _budget;

        // Gets or sets name
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                Console.WriteLine("Name:  " + _name);
            }
        }

        // Gets or sets phone
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                Console.WriteLine("Phone: " + _phone);
            }
        }

        // Gets or sets budget
        public double Budget
        {
            get { return _budget; }
            set
            {
                _budget = value;
                Console.WriteLine("Budget: " + _budget);
            }
        }

        // Stores memento
        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento(_name, _phone, _budget);
        }

        // Restores memento
        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            Name = memento.Name;
            Phone = memento.Phone;
            Budget = memento.Budget;
        }
    }

    /// <summary>
    /// The 'Memento' class
    /// </summary>
    class Memento
    {
        private string _name;
        private string _phone;
        private double _budget;

        // Constructor
        public Memento(string name, string phone, double budget)
        {
            _name = name;
            _phone = phone;
            _budget = budget;
        }

        // Gets or sets name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Gets or set phone
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        // Gets or sets budget
        public double Budget
        {
            get { return _budget; }
            set { _budget = value; }
        }
    }

    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    class ProspectMemory
    {
        private Memento _memento;

        // Property
        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
    #endregion
}
