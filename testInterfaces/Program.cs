using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polynomial;
using testInterfaces.Design_Patterns.Creational;
using testInterfaces.Design_Patterns.Structural;

namespace testInterfaces
{
    interface IParentInterface
    {
        void ParentInterfaceMethod();
    }
    interface IMyInterface : IParentInterface
    {
        void MethodToImplement();
    }

    interface IMultipleInheritance
    {
        int wow();
    }

    internal abstract class absClass
    {
        public abstract void AbsMethod();

        public int NonAbsMethod()
        {
            return 0;
        }
    }

    interface Ijedan
    {
        void IzJedinice();

        void SameName();
    }

    interface Idva
    {
        int IzJedinice();
        void SameName();
    }

    interface IAnimal
    {
        string Describe();

        string Name { get; set; }
    }

    class Dog : IAnimal, IComparable
    {
        private string name;
        public Dog(string name)
        {
            this.Name = name;
        }
        public string Describe()
        {
            return "Hello, I'm a dog and my name is " + this.Name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int CompareTo(object obj)
        {
            if (obj is IAnimal)
                return this.Name.Equals((obj as IAnimal).Name) == true ? 1 : 0;
            return 0;
        }

        public static bool CompareNames(object first, object second)
        {
            if (first is IAnimal && second is IAnimal)
            {
                if ((first as IAnimal).Name == (second as IAnimal).Name)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }

    class testVirtual
    {
        public virtual void Foo()
        {
            Console.WriteLine("i do something you might not want me to.");
        }
    }

    class Program : testVirtual, IMyInterface, IMultipleInheritance, Ijedan, Idva //absClass,IMyInterface, IMultipleInheritance,Ijedan,Idva
    {
        static void Main(string[] args)
        {
            //InterfacesTester();
            //SingletonTester();
            //FactoryTester();
            //AbstractFactoryTester();
            //PrototypeTester();
            //BuilderTester();

            Console.Read();
        }

        public override void Foo()
        {
            Console.WriteLine("now it does what you wait it to.");
            // and maybe the thing that it already did ?
            base.Foo();
        }

        public void MethodToImplement()
        {
            Console.WriteLine("MethodToImplement() called.");
        }

        public void ParentInterfaceMethod()
        {
            Console.WriteLine("ParentInterfaceMethod() called.");
        }

        public int wow()
        {
            return 1;
        }

        //public override void AbsMethod()
        //{
        //    Console.WriteLine("implemented");
        //}

        public void IzJedinice()
        {
            Console.WriteLine("one method from one interface");
        }

        void Idva.SameName()
        {
            Console.WriteLine("calling samename from idva");
        }

        void Ijedan.SameName()
        {
            Console.WriteLine("calling samename from ijedan");
        }

        int Idva.IzJedinice()
        {
            Console.WriteLine("one method from two interface");
            return 1;
        }

        static void InterfacesTester() {
            Program p = new Program();
            p.MethodToImplement();
            p.ParentInterfaceMethod();
            int br = p.wow();
            Console.WriteLine(br.ToString());
            // call second main from polynomys/driver
            Driver.MainTwo();
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
    }
}
