using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IADP.Design_Patterns.Behavioral;
using IADP.Design_Patterns.Creational;
using IADP.Design_Patterns.Structural;
using IADP.Interfaces;
using IADP.KeyValuePairs;
using Polynomial;

namespace IADP
{
    class Program : ProgramExtender
    {
        static void Main(string[] args)
        {
            //KeyValuePairsTester();
            //InterfacesTester();

            //-Design patterns
            //--Creational
            //SingletonTester();
            //FactoryTester();
            //AbstractFactoryTester();
            //PrototypeTester();
            //BuilderTester();
            //--Structural
            //FacadeTester();
            //ProxyTester();
            //CompositeTester();
            //AdapterTester();
            //BridgeTester();
            //DecoratorTester();
            //FlyweightTester();
            //--Behavioral
            //IteratorTester();
            //ObserverTester();

            Console.Read();
        }

        static void InterfacesTester() {
            Program p = new Program();
            p.MethodToImplement();
            p.ParentInterfaceMethod();
            int br = p.wow();
            Console.WriteLine(br.ToString());
            // call second main from polynomys/driver
            Driver.MainPolynoms();
            // use animal interface
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Somedog"));
            Dog puppy = new Dog("littleOne");
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
            Dog comparable = new Dog("newname");
            Dog comparable2 = new Dog("newname");
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

            testVirtual t = new testVirtual();
            t.Foo();
            p.Foo();
        }

        static void SingletonTester()
        {

            #region sample 1
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            #endregion

            #region sample 2
            // use of singleton creational pattern
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Load balance 15 server requests
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }
            #endregion
        }

        static void FactoryTester()
        {

            #region sample 1
            // use of factory creational pattern
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
            #endregion

            #region sample 2
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
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
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
            #endregion


            #region sample 2
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
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

            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("II");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);
            #endregion

            #region sample 2
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors
            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors
            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;
            Color color3 = colormanager["flame"].Clone() as Color;
            #endregion
        }

        static void BuilderTester()
        {
            #region sample 1
            Director director = new Director();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            // Construct two products
            director.Construct(b1);
            BuilderProduct p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            BuilderProduct p2 = b2.GetResult();
            p2.Show();
            #endregion

            #region sample 2
            VehicleBuilder builder;

            // Create shop with vehicle builders
            Shop shop = new Shop();

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
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();
            #endregion

            #region sample 2
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));
            #endregion
        }

        static void ProxyTester()
        {
            #region sample 1
            Proxy proxy = new Proxy();
            proxy.Request();
            #endregion

            #region sample 2
            MathProxy proxyImplement = new MathProxy();

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
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree
            root.Display(1);
            #endregion

            #region sample 2
            // Create a tree structure
            CompositeElement rootImplementation =
              new CompositeElement("Picture");
            rootImplementation.Add(new PrimitiveElement("Red Line"));
            rootImplementation.Add(new PrimitiveElement("Blue Circle"));
            rootImplementation.Add(new PrimitiveElement("Green Box"));

            // Create a branch
            CompositeElement compImplementation =
              new CompositeElement("Two Circles");
            compImplementation.Add(new PrimitiveElement("Black Circle"));
            compImplementation.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement
            PrimitiveElement pe =
              new PrimitiveElement("Yellow Line");
            rootImplementation.Add(pe);
            rootImplementation.Remove(pe);

            // Recursively display nodes
            root.Display(1);
            #endregion
        }

        static void AdapterTester()
        {
            #region sample 1
            Target target = new Adapter();
            target.Request();
            #endregion

            #region sample 2
            Compound unknown = new Compound("Unknown");
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
            Customers customers = new Customers("Chicago");

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
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            // Wait for user
            Console.ReadKey();
            #endregion


            #region sample 2
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();
            #endregion
        }

        static void FlyweightTester()
        {
            #region sample 1
            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            // Work with different flyweight instances
            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new
              UnsharedConcreteFlyweight();

            fu.Operation(--extrinsicstate);
            #endregion

            #region sample2
            // Build a document with text
            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory factoryImplementation = new CharacterFactory();

            // extrinsic state
            int pointSize = 10;

            // For each character use a flyweight object
            foreach (char c in chars)
            {
                pointSize++;
                Character character = factoryImplementation.GetCharacter(c);
                character.Display(pointSize);
            }
            #endregion
        }

        static void KeyValuePairsTester()
        {
            HashtableAndDictionary.Dictionary();
            HashtableAndDictionary.Hashtable();
        }

        static void IteratorTester()
        {
            #region sample 1
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            // Create Iterator and provide aggregate
            Iterator i = a.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
            #endregion

            #region sample 2
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
            ImplementedIterator iterator = collection.CreateIterator();

            // Skip every other item
            iterator.Step = 2;

            Console.WriteLine("Iterating over collection:");

            for (Item implementedItem = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(implementedItem.Name);
            }
            #endregion
        }

        static void ObserverTester()
        {
            #region sample 1
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
            #endregion

            #region sample 2
            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
            #endregion
        }

    }
}
