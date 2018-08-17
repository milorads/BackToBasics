using System;
using System.Collections.Generic;

namespace BackToBasics.Topics.Design_Patterns.Structural.Decorator
{
    #region Structure code
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    abstract class DecoratorComponent
    {
        public abstract void Operation();
        public abstract string Operation(bool test);
    }

    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    class ConcreteComponent : DecoratorComponent
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }

        public override string Operation(bool test)
        {
            return "ConcreteComponent.Operation()";
        }
    }

    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    abstract class Decorator : DecoratorComponent
    {
        protected DecoratorComponent component;

        public void SetComponent(DecoratorComponent component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }

        public override string Operation(bool test)
        {
            return component?.Operation(test);
        }
    }

    /// <summary>
    /// The 'ConcreteDecoratorA' class
    /// </summary>
    class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
        public override string Operation(bool test)
        {
            return "ConcreteDecoratorA.Operation()" + base.Operation(test);
        }
    }

    /// <summary>
    /// The 'ConcreteDecoratorB' class
    /// </summary>
    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        public override string Operation(bool test)
        {
            AddedBehavior();
            return "ConcreteDecoratorB.Operation()"+ base.Operation(test);
        }

        void AddedBehavior()
        {
        }
    }
    #endregion

    #region Implementation code
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    abstract class LibraryItem
    {
        private int _numCopies;

        // Property
        public int NumCopies
        {
            get { return _numCopies; }
            set { _numCopies = value; }
        }

        public abstract void Display();
        public abstract List<string> Display(bool test);
    }

    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    class Book : LibraryItem
    {
        private string _author;
        private string _title;

        // Constructor
        public Book(string author, string title, int numCopies)
        {
            this._author = author;
            this._title = title;
            this.NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", _author);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
        public override List<string> Display(bool test)
        {
            return new List<string>(){_author,_title,NumCopies.ToString()};
        }
    }

    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    class Video : LibraryItem
    {
        private string _director;
        private string _title;
        private int _playTime;

        // Constructor
        public Video(string director, string title,
          int numCopies, int playTime)
        {
            this._director = director;
            this._title = title;
            this.NumCopies = numCopies;
            this._playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", _director);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" Playtime: {0}\n", _playTime);
        }

        public override List<string> Display(bool test)
        {
            return new List<string>(){_director,_title,NumCopies.ToString(),_playTime.ToString()};
        }
    }

    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    abstract class DecoratorImplementation : LibraryItem
    {
        protected LibraryItem libraryItem;

        // Constructor
        public DecoratorImplementation(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }

    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    class Borrowable : DecoratorImplementation
    {
        protected List<string> borrowers = new List<string>();

        // Constructor
        public Borrowable(LibraryItem libraryItem)
          : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }

        public override List<string> Display(bool test)
        {
            return borrowers;
        }
    }
    #endregion
}
