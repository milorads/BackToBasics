using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testInterfaces.Design_Patterns.Behavioral
{
    #region Structure Code
    /// <summary>
    /// The 'Command' abstract class
    /// </summary>
    abstract class SampleCommand
    {
        protected Receiver receiver;

        // Constructor
        public SampleCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
        public abstract string Execute(bool test);
    }

    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    class SampleConcreteCommand : SampleCommand
    {
        // Constructor
        public SampleConcreteCommand(Receiver receiver) :
          base(receiver)
        {
        }

        public override void Execute()
        {
            receiver.Action();
        }
        public override string Execute(bool test)
        {
            return receiver.Action(test);
        }
    }

    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }

        public string Action(bool test)
        {
            return "Called Receiver.Action()";
        }
    }

    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    class Invoker
    {
        private SampleCommand _command;

        public void SetCommand(SampleCommand command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }

        public string ExecuteCommand(bool test)
        {
            return _command.Execute(test);
        }
    }
    #endregion

    #region Implementation code
    /// <summary>
    /// The 'Command' abstract class
    /// </summary>
    abstract class Command
    {
        public abstract void Execute();
        public abstract int Execute(bool test);
        public abstract void UnExecute();
        public abstract int UnExecute(bool test);
    }

    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    class CalculatorCommand : Command
    {
        private char _operator;
        private int _operand;
        private Calculator _calculator;

        // Constructor
        public CalculatorCommand(Calculator calculator,
          char @operator, int operand)
        {
            this._calculator = calculator;
            this._operator = @operator;
            this._operand = operand;
        }

        // Gets operator
        public char Operator
        {
            set { _operator = value; }
        }

        // Get operand
        public int Operand
        {
            set { _operand = value; }
        }

        // Execute new command
        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public override int Execute(bool test)
        {
            return _calculator.Operation(_operator, _operand, test);
        }

        // Unexecute last command
        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        public override int UnExecute(bool test)
        {
           return _calculator.Operation(Undo(_operator), _operand, test);
        }

        // Returns opposite operator for given operator
        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default:
                    throw new
            ArgumentException("@operator");
            }
        }
    }

    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    class Calculator
    {
        private int _curr = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': _curr += operand; break;
                case '-': _curr -= operand; break;
                case '*': _curr *= operand; break;
                case '/': _curr /= operand; break;
            }
            Console.WriteLine(
              "Current value = {0,3} (following {1} {2})",
              _curr, @operator, operand);
        }
        public int Operation(char @operator, int operand, bool test)
        {
            switch (@operator)
            {
                case '+': _curr += operand; break;
                case '-': _curr -= operand; break;
                case '*': _curr *= operand; break;
                case '/': _curr /= operand; break;
            }
            return _curr;
        }
    }

    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    class User
    {
        // Initializers
        private Calculator _calculator = new Calculator();
        private List<Command> _commands = new List<Command>();
        private int _current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);
            // Perform redo operations
            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    Command command = _commands[_current++];
                    command.Execute();
                }
            }
        }

        public List<int> Redo(int levels, bool test)
        {
            var @out = new List<int>();
            // Perform redo operations
            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    Command command = _commands[_current++];
                    @out.Add(command.Execute(true));
                }
            }
            return @out;
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);
            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    Command command = _commands[--_current] as Command;
                    command.UnExecute();
                }
            }
        }
        public List<int> Undo(int levels, bool test)
        {
            var @out = new List<int>();
            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    Command command = _commands[--_current] as Command;
                    @out.Add(command.UnExecute(true));
                }
            }
            return @out;
        }

        public void Compute(char @operator, int operand)
        {
                // Create command operation and execute it
                Command command = new CalculatorCommand(_calculator, @operator, operand);
                command.Execute();

                // Add command to undo list
                _commands.Add(command);
                _current++;

        }
        public int Compute(char @operator, int operand, bool test)
        {
            // Create command operation and execute it
            Command command = new CalculatorCommand(_calculator, @operator, operand);
            var result =command.Execute(true);

            // Add command to undo list
            _commands.Add(command);
            _current++;
            return result;
        }
    }
    #endregion
}
