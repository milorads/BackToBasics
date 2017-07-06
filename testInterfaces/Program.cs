using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polynomial;
using testInterfaces.Design_Patterns.Behavioral;
using testInterfaces.Design_Patterns.Creational;
using testInterfaces.Design_Patterns.Structural;
using testInterfaces.Interfaces;
using testInterfaces.KeyValuePairs;

namespace testInterfaces
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
            //StrategyTester();//!
            //StateTester();//!
            //todo: add behavioral patterns

            Console.Read();
        }

        public static void InterfacesTester() {
            var p = new Program();
            p.MethodToImplement();
            p.ParentInterfaceMethod();
            var br = p.wow();
            Console.WriteLine(br.ToString());
            // call second main from polynomys/driver
            Driver.MainPolynoms();
            // use animal interface
            var dogs = new List<Dog>();
            dogs.Add(new Dog("Somedog"));
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
        }

        static void KeyValuePairsTester()
        {
            HashtableAndDictionary.Dictionary();
            HashtableAndDictionary.Hashtable();
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
            var director = new Director();

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
            VehicleBuilder builder;

            // Create shop with vehicle builders
            var shop = new Shop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
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
            Abstraction ab = new RefinedAbstraction();
            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
            #endregion

            #region sample 2
            var customers = new Customers("Chicago");

            // Set ConcreteImplementor
            customers.Data = new CustomersData();

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
            var document = "AAZZBBZB";
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
            var a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

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
            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");

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
            Receiver receiver = new Receiver();
            SampleCommand command = new SampleConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            // Set and execute command
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            #endregion

            #region sample 2
            // Create user and let her compute
            User user = new User();

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
            Context context;

            // Three contexts following different strategies
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
            #endregion

            #region sample 2
            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();

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
            StateContext c = new StateContext(new ConcreteStateA());

            // Issue requests, which toggles state
            c.Request();
            c.Request();
            c.Request();
            c.Request();
            #endregion

            #region sample 2
            // Open a new account
            Account account = new Account("Jim Johnson");

            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
            #endregion
        }

    }
}
