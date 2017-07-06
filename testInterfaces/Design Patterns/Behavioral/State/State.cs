using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testInterfaces.Design_Patterns.Behavioral
{
    #region Sample Code
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    abstract class SampleState
    {
        public abstract void Handle(StateContext context);
        public abstract string Handle(StateContext context, bool test);
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    class ConcreteStateA : SampleState
    {
        public override void Handle(StateContext context)
        {
            context.State = new ConcreteStateB();
        }

        public override string Handle(StateContext context, bool test)
        {
            context.State = new ConcreteStateB();
            return typeof(ConcreteStateB).ToString();
        }
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    class ConcreteStateB : SampleState
    {
        public override void Handle(StateContext context)
        {
            context.State = new ConcreteStateA();
        }

        public override string Handle(StateContext context, bool test)
        {
            context.State = new ConcreteStateA();
            return typeof(ConcreteStateA).ToString();
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>
    class StateContext
    {
        private SampleState _state;

        // Constructor
        public StateContext(SampleState state)
        {
            this.State = state;
        }

        // Gets or sets the state
        public SampleState State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State: " +
                  _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
        public string Request(bool test)
        {
            return _state.Handle(this, test);
        }
    }
    #endregion

    #region Implementation Code
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    abstract class State
    {
        protected Account account;
        protected double balance;

        protected double interest;
        protected double lowerLimit;
        protected double upperLimit;

        // Properties
        public Account Account
        {
            get { return account; }
            set { account = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public abstract void Deposit(double amount);
        public abstract string Deposit(double amount, bool test);
        public abstract void Withdraw(double amount);
        public abstract string Withdraw(double amount, bool test);
        public abstract void PayInterest();
        public abstract string PayInterest(bool test);
    }


    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Red indicates that account is overdrawn
    /// </remarks>
    /// </summary>
    class RedState : State
    {
        private double _serviceFee;

        // Constructor
        public RedState(State state)
        {
            this.balance = state.Balance;
            this.account = state.Account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource
            interest = 0.0;
            lowerLimit = -100.0;
            upperLimit = 0.0;
            _serviceFee = 15.00;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }
        public override string Deposit(double amount, bool test)
        {
            balance += amount;
            return StateChangeCheck(true);
        }

        public override void Withdraw(double amount)
        {
            amount = amount - _serviceFee;
            Console.WriteLine("No funds available for withdrawal!");
        }

        public override string Withdraw(double amount, bool test)
        {
            if (balance - amount <= lowerLimit)
            {
                return "No funds available for withdrawal!";
            }
            else
            {
                amount = amount - _serviceFee;
                return balance.ToString();
            }
        }

        public override void PayInterest()
        {
            // No interest is paid
        }

        public override string PayInterest(bool test)
        {
            return "";
        }

        private void StateChangeCheck()
        {
            if (balance > upperLimit)
            {
                account.State = new SilverState(this);
            }
        }

        private string StateChangeCheck(bool test)
        {
            if (balance > upperLimit)
            {
                account.State = new SilverState(this);
            }
            return account.State.ToString();
        }
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Silver indicates a non-interest bearing state
    /// </remarks>
    /// </summary>
    class SilverState : State
    {
        // Overloaded constructors

        public SilverState(State state) :
          this(state.Balance, state.Account)
        {
        }

        public SilverState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource
            interest = 0.0;
            lowerLimit = 0.0;
            upperLimit = 1000.0;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override string Deposit(double amount, bool test)
        {
            balance += amount;
            return StateChangeCheck(test);
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }

        public override string Withdraw(double amount, bool test)
        {
            balance -= amount;
            return StateChangeCheck(true);
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        public override string PayInterest(bool test)
        {
            balance += interest * balance;
            return StateChangeCheck(true);
        }

        private void StateChangeCheck()
        {
            if (balance < lowerLimit)
            {
                account.State = new RedState(this);
            }
            else if (balance > upperLimit)
            {
                account.State = new GoldState(this);
            }
        }
        private string StateChangeCheck(bool test)
        {
            if (balance < lowerLimit)
            {
                account.State = new RedState(this);
            }
            else if (balance > upperLimit)
            {
                account.State = new GoldState(this);
            }
            return account.State.ToString();
        }
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Gold indicates an interest bearing state
    /// </remarks>
    /// </summary>
    class GoldState : State
    {
        // Overloaded constructors
        public GoldState(State state)
          : this(state.Balance, state.Account)
        {
        }

        public GoldState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a database
            interest = 0.05;
            lowerLimit = 1000.0;
            upperLimit = 10000000.0;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override string Deposit(double amount, bool test)
        {
            balance += amount;
            return StateChangeCheck(test);
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }

        public override string Withdraw(double amount, bool test)
        {
            balance -= amount;
            return StateChangeCheck(true);
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        public override string PayInterest(bool test)
        {
            balance += interest * balance;
            return StateChangeCheck(true);
        }

        private void StateChangeCheck()
        {
            if (balance < 0.0)
            {
                account.State = new RedState(this);
            }
            else if (balance < lowerLimit)
            {
                account.State = new SilverState(this);
            }
        }
        private string StateChangeCheck(bool test)
        {
            if (balance < 0.0)
            {
                account.State = new RedState(this);
            }
            else if (balance < lowerLimit)
            {
                account.State = new SilverState(this);
            }
            return account.State.ToString();
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>
    class Account
    {
        private State _state;
        private string _owner;

        // Constructor
        public Account(string owner)
        {
            // New accounts are 'Silver' by default
            this._owner = owner;
            this._state = new SilverState(0.0, this);
        }

        // Properties
        public double Balance
        {
            get { return _state.Balance; }
        }

        public State State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void Deposit(double amount)
        {
            _state.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}",
              this.State.GetType().Name);
            Console.WriteLine("");
        }
        public Dictionary<string,string> Deposit(double amount, bool test)
        {
            _state.Deposit(amount, test);
            return new Dictionary<string, string>(){{"deposit",amount.ToString()},{"balance", this.Balance.ToString()},{"state", this.State.GetType().Name}};

        }

        public void Withdraw(double amount)
        {
            _state.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n",
              this.State.GetType().Name);
        }

        public Dictionary<string, string> Withdraw(double amount, bool test)
        {
            _state.Withdraw(amount, test);
            return new Dictionary<string, string>() { { "withdraw", amount.ToString() }, { "balance", this.Balance.ToString() }, { "state", this.State.GetType().Name } };

        }

        public void PayInterest()
        {
            _state.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n",
              this.State.GetType().Name);
        }
        public Dictionary<string, string> PayInterest(bool test)
        {
            return new Dictionary<string, string>() { { "interest", _state.PayInterest(true) }, { "balance", this.Balance.ToString() }, { "state", this.State.GetType().Name } };

        }
    }
    #endregion
}
