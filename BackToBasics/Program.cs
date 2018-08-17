using System;
using System.Collections;
using System.Collections.Generic;
using BackToBasics.Topics.Data_Structures.KeyValuePairs;
using BackToBasics.Topics.Design_Patterns.Behavioral.ChainOfResponsibility;
using BackToBasics.Topics.Design_Patterns.Behavioral.Command;
using BackToBasics.Topics.Design_Patterns.Behavioral.Interpreter;
using BackToBasics.Topics.Design_Patterns.Behavioral.Iterator;
using BackToBasics.Topics.Design_Patterns.Behavioral.Mediator;
using BackToBasics.Topics.Design_Patterns.Behavioral.Memento;
using BackToBasics.Topics.Design_Patterns.Behavioral.Observer;
using BackToBasics.Topics.Design_Patterns.Behavioral.State;
using BackToBasics.Topics.Design_Patterns.Behavioral.Strategy;
using BackToBasics.Topics.Design_Patterns.Behavioral.TemplateMethod;
using BackToBasics.Topics.Design_Patterns.Behavioral.Visitor;
using BackToBasics.Topics.Design_Patterns.Creational.AbstractFactory;
using BackToBasics.Topics.Design_Patterns.Creational.Builder;
using BackToBasics.Topics.Design_Patterns.Creational.Factory;
using BackToBasics.Topics.Design_Patterns.Creational.Prototype;
using BackToBasics.Topics.Design_Patterns.Creational.Singleton;
using BackToBasics.Topics.Design_Patterns.Structural.Adapter;
using BackToBasics.Topics.Design_Patterns.Structural.Bridge;
using BackToBasics.Topics.Design_Patterns.Structural.Composite;
using BackToBasics.Topics.Design_Patterns.Structural.Decorator;
using BackToBasics.Topics.Design_Patterns.Structural.Facade;
using BackToBasics.Topics.Design_Patterns.Structural.Flyweight;
using BackToBasics.Topics.Design_Patterns.Structural.Proxy;
using BackToBasics.Topics.Paradigms.Interfaces.InterfaceTry;
using BackToBasics.Topics.Paradigms.Interfaces.Polynoms;
using BackToBasics.Topics.Sorting;
using Director = BackToBasics.Topics.Design_Patterns.Behavioral.ChainOfResponsibility.Director;
using SortedList = BackToBasics.Topics.Design_Patterns.Behavioral.Strategy.SortedList;

namespace BackToBasics
{
    internal class Program : ProgramExtender
    {
        private static void Main(string[] args)
        {
            //KeyValuePairsTester();//+

            //InterfacesTester();//+

            //-Design patterns
            //--Creational
            //SingletonTester();//+
            //FactoryTester();//+
            //AbstractFactoryTester();//+
            //PrototypeTester();//+
            //BuilderTester();//+
            //--Structural
            //FacadeTester();//+
            //ProxyTester();//+
            //CompositeTester();//+
            //AdapterTester();//+
            //BridgeTester();//+
            //DecoratorTester();//+
            //FlyweightTester();//+
            //--Behavioral
            //IteratorTester();//+
            //ObserverTester();//+
            //CommandTester();//+
            //StrategyTester();//+
            //StateTester();//+
            //TemplateMethodTester();//+
            //MediatorTester();// +
            //ChainOfResponsibilityTester();// +
            //VisitorTester();// +
            //InterpreterTester();// +
            //MementoTester();// -

            BubbleSort.DoSort(new[] { 6, 5, 3, 1, 8, 7, 2, 4 });
            SelectionSort.DoSort(new[] { 6, 5, 3, 1, 8, 7, 2, 4 });
            Console.Read();
        }

        public static void InterfacesTester()
        {
            #region sample
            var p = new Program();
            p.MethodToImplement();
            p.ParentInterfaceMethod();
            var br = p.wow();
            Console.WriteLine(br.ToString());
            // call second main from polynomys/driver
            Driver.MainPolynoms();
            // use animal interface
            var dogs = new List<Dog> {new Dog("Somedog")};
            var puppy = new Dog("littleOne");
            dogs.Add(puppy);
            dogs.Add(new Dog("aDog"));
            dogs.Sort();
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Describe());
            }
            puppy.Name = "newDog";
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Describe());
            }
            var comparable = new Dog("newname");
            var comparable2 = new Dog("newname");
            var a = comparable2.CompareTo(comparable);
            var b = a == 1 ? true : false;
            Console.WriteLine("Puppy a and b are same? " + b.ToString());
            var c = Dog.CompareNames(comparable, comparable2);
            Console.WriteLine("Puppy a and b are same? " + c.ToString());
            p.IzJedinice();
            var a1 = ((Idva)p).IzJedinice();
            Console.WriteLine(a1.ToString());
            ((Ijedan)p).SameName();
            (p as Idva).SameName();

            var t = new testVirtual();
            t.Foo();
            p.Foo();
            #endregion
        }

        static void KeyValuePairsTester()
        {
            #region sample
            HashtableAndDictionary.Dictionary();
            HashtableAndDictionary.Hashtable();
            #endregion
        }

        static void SingletonTester()
        {

            #region sample 1
            var s1 = Singleton.Instance();
            var s2 = Singleton.Instance();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            #endregion

            #region sample 2
            // use of singleton creational pattern
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Load balance 15 server requests
            var balancer = LoadBalancer.GetLoadBalancer();
            for (var i = 0; i < 15; i++)
            {
                var server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }
            #endregion
        }

        static void FactoryTester()
        {

            #region sample 1
            // use of factory creational pattern
            var creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products
            foreach (var creator in creators)
            {
                var product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
            #endregion

            #region sample 2
            // Note: constructors call Factory Method
            var documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (var document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (var page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
            #endregion
        }

        static void AbstractFactoryTester()
        {

            #region sample 1
            // Abstract factory #1
            AbstractFactory factory1 = new ConcreteFactory1();
            var client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            var client2 = new Client(factory2);
            client2.Run();
            #endregion


            #region sample 2
            ContinentFactory africa = new AfricaFactory();
            var world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
            #endregion
        }

        static void PrototypeTester() {

            #region sample 1
            // Create two instances and clone each

            var p1 = new ConcretePrototype1("I");
            var c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            var p2 = new ConcretePrototype2("II");
            var c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);
            #endregion

            #region sample 2
            var colormanager = new ColorManager();

            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors
            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors
            var color1 = colormanager["red"].Clone() as Color;
            var color2 = colormanager["peace"].Clone() as Color;
            var color3 = colormanager["flame"].Clone() as Color;
            #endregion
        }

        static void BuilderTester()
        {
            #region sample 1
            var director = new Topics.Design_Patterns.Creational.Builder.Director();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            // Construct two products
            director.Construct(b1);
            var p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            var p2 = b2.GetResult();
            p2.Show();
            #endregion

            #region sample 2

            // Create shop with vehicle builders
            var shop = new Shop();

            // Construct and display vehicles
            VehicleBuilder builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            #endregion
        }

        static void FacadeTester()
        {
            #region sample 1
            var facade = new Facade();

            facade.MethodA();
            facade.MethodB();
            #endregion

            #region sample 2
            // Facade
            var mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            var customer = new Customer("Ann McKinsey");
            var eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));
            #endregion
        }

        static void ProxyTester()
        {
            #region sample 1
            var proxy = new Proxy();
            proxy.Request();
            #endregion

            #region sample 2
            var proxyImplement = new MathProxy();

            // Do the math
            Console.WriteLine("4 + 2 = " + proxyImplement.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxyImplement.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxyImplement.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxyImplement.Div(4, 2));
            #endregion
        }

        static void CompositeTester()
        {
            #region sample 1
            var root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            var comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            var leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree
            root.Display(1);
            #endregion

            #region sample 2
            // Create a tree structure
            var rootImpl = new CompositeElement("Picture");
            rootImpl.Add(new PrimitiveElement("Red Line"));
            rootImpl.Add(new PrimitiveElement("Blue Circle"));
            rootImpl.Add(new PrimitiveElement("Green Box"));

            // Create a branch
            var compImpl = new CompositeElement("Two Circles");
            compImpl.Add(new PrimitiveElement("Black Circle"));
            compImpl.Add(new PrimitiveElement("White Circle"));
            rootImpl.Add(compImpl);

            // Add and remove a PrimitiveElement
            var pe = new PrimitiveElement("Yellow Line");
            rootImpl.Add(pe);
            rootImpl.Remove(pe);

            // Recursively display nodes
            rootImpl.Display(1);
            #endregion
        }

        static void AdapterTester()
        {
            #region sample 1
            Target target = new Adapter();
            target.Request();
            #endregion

            #region sample 2
            var unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
            #endregion
        }

        static void BridgeTester()
        {
            #region sample 1

            var ab = new RefinedAbstraction {Implementor = new ConcreteImplementorA()};
            // Set implementation and call
            ab.Operation();

            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
            #endregion

            #region sample 2

            var customers = new Customers("Chicago") {Data = new CustomersData()};

            // Set ConcreteImplementor

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();
            #endregion
        }

        static void DecoratorTester()
        {
            #region sample 1
            var c = new ConcreteComponent();
            var d1 = new ConcreteDecoratorA();
            var d2 = new ConcreteDecoratorB();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            // Wait for user
            Console.ReadKey();
            #endregion


            #region sample 2
            var book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video
            var video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");

            var borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();
            #endregion
        }

        static void FlyweightTester()
        {
            #region sample 1
            var extrinsicstate = 22;

            var factory = new FlyweightFactory();

            // Work with different flyweight instances
            var fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            var fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            var fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            var fu = new
              UnsharedConcreteFlyweight();

            fu.Operation(--extrinsicstate);
            #endregion

            #region sample 2
            // Build a document with text
            const string document = "AAZZBBZB";
            var chars = document.ToCharArray();

            var factoryImplementation = new CharacterFactory();

            // extrinsic state
            var pointSize = 10;

            // For each character use a flyweight object
            foreach (var c in chars)
            {
                pointSize++;
                var character = factoryImplementation.GetCharacter(c);
                character.Display(pointSize);
            }
            #endregion
        }

        static void IteratorTester()
        {
            #region sample 1

            var a = new ConcreteAggregate
            {
                [0] = "Item A",
                [1] = "Item B",
                [2] = "Item C",
                [3] = "Item D"
            };

            // Create Iterator and provide aggregate
            var i = a.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            var item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
            #endregion

            #region sample 2
            // Build a collection
            var collection = new Collection
            {
                [0] = new Item("Item 0"),
                [1] = new Item("Item 1"),
                [2] = new Item("Item 2"),
                [3] = new Item("Item 3"),
                [4] = new Item("Item 4"),
                [5] = new Item("Item 5"),
                [6] = new Item("Item 6"),
                [7] = new Item("Item 7"),
                [8] = new Item("Item 8")
            };

            // Create iterator
            var iterator = collection.CreateIterator();

            // Skip every other item
            iterator.Step = 2;

            Console.WriteLine("Iterating over collection:");

            for (Item item2 = iterator.First();
                !iterator.IsDone; item2 = iterator.Next())
            {
                Console.WriteLine(item2.Name);
            }

            // Wait for user
            Console.ReadKey();
            #endregion
        }

        static void ObserverTester()
        {
            #region sample 1
            // Configure Observer pattern
            var s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
            #endregion

            #region sample 2
            // Create IBM stock and attach investors
            var ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
            #endregion
        }

        static void CommandTester()
        {
            #region sample 1
            // Create receiver, command, and invoker
            var receiver = new Receiver();
            var command = new SampleConcreteCommand(receiver);
            var invoker = new Invoker();

            // Set and execute command
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            #endregion

            #region sample 2
            // Create user and let her compute
            var user = new User();

            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);
            #endregion
        }

        static void StrategyTester()
        {
            #region sample 1

            // Three contexts following different strategies
            var context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
            #endregion

            #region sample 2
            // Two contexts following different strategies
            var studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
            #endregion
        }

        static void StateTester()
        {
            #region sample 1
            // Setup context in a state
            var c = new StateContext(new ConcreteStateA());

            // Issue requests, which toggles state
            c.Request();
            c.Request();
            c.Request();
            c.Request();
            #endregion

            #region sample 2
            // Open a new account
            var account = new Account("Jim Johnson");

            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
            #endregion
        }

        static void TemplateMethodTester()
        {
            #region sample 1
            AbstractClassTemplate aA = new ConcreteClassA();
            aA.TemplateMethod();

            AbstractClassTemplate aB = new ConcreteClassB();
            aB.TemplateMethod();

            #endregion

            #region sample 2
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();
            #endregion
        }

        static void MediatorTester()
        {
            #region sample 1
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("How are you?");
            c2.Send("Fine, thanks");
            #endregion

            #region sample 2
            // Create chatroom
            Chatroom chatroom = new Chatroom();

            // Create participants and register them
            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting participants
            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");
            #endregion
        }

        static void ChainOfResponsibilityTester()
        {
            #region sample 1
            // Setup Chain of Responsibility
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            // Generate and process request
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }
            #endregion

            #region sample 2
            // Setup Chain of Responsibility
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests
            Purchase p = new Purchase(2034, 350.00, "Assets");
            larry.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);
            #endregion
        }

        static void VisitorTester()
        {
            #region sample 1
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
            #endregion

            #region sample 2
            // Setup employee collection
            EmployeeVs e = new EmployeeVs();
            e.Attach(new ClerkV());
            e.Attach(new DirectorV());
            e.Attach(new PresidentV());

            // Employees are 'visited'
            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());
            #endregion
        }

        static void InterpreterTester()
        {
            #region sample 1
            InterpreterContext context = new InterpreterContext();

            ArrayList list = new ArrayList
            {
                new TerminalExpression(),
                new NonterminalExpression(),
                new TerminalExpression(),
                new TerminalExpression()
            };

            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
            #endregion

            #region sample 2
            string roman = "MCMXXVIII";
            InterpreterApplicationContext contextImplementation = new InterpreterApplicationContext(roman);

            List<Expression> tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            foreach (Expression exp in tree)
            {
                exp.Interpret(contextImplementation);
            }

            Console.WriteLine("{0} = {1}",
                roman, contextImplementation.Output);
            #endregion
        }

        private static void MementoTester()
        {
            #region sample 1
            Originator o = new Originator {State = "On"};
            Caretaker c = new Caretaker {Memento = o.CreateMemento()};
            o.State = "Off";
            o.SetMemento(c.Memento);
            #endregion

            #region sample 2
            SalesProspect s = new SalesProspect
            {
                Name = "Noel van Halen",
                Phone = "(412) 256-0990",
                Budget = 25000.0
            };
            ProspectMemory m = new ProspectMemory {Memento = s.SaveMemento()};
            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;
            s.RestoreMemento(m.Memento);
            #endregion
        }
    }
}
