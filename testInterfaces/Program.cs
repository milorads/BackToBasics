using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polynomial;

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
        void izJedinice();
    }

    interface Idva
    {
        int izJedinice();
    }

    class Program : absClass,IMyInterface, IMultipleInheritance,Ijedan,Idva
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("Puppy a and b are same? "+b.ToString());
            var c = Dog.CompareNames(comparable, comparable2);
            Console.WriteLine("Puppy a and b are same? " + c.ToString());
            p.izJedinice();
            var a1 = ((Idva)p).izJedinice();
            Console.WriteLine(a1.ToString());
            Console.Read();
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

        public override void AbsMethod()
        {
            Console.WriteLine("implemented");
        }

        public void izJedinice()
        {
            Console.WriteLine("one method from one interface");
        }

        int Idva.izJedinice()
        {
            Console.WriteLine("one method from two interface");
            return 1;
        }
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

        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int CompareTo(object obj)
        {
            if (obj is IAnimal)
                return this.Name.Equals((obj as IAnimal).Name)==true?1:0;
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
}
