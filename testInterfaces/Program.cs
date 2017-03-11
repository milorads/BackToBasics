using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    class Program : IMyInterface, IMultipleInheritance
    {
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.MethodToImplement();
            //p.ParentInterfaceMethod();
            //int br = p.wow();
            //Console.WriteLine(br.ToString());
            //// call second main from polynomys/driver
            //// use animal interface
            //List<Dog> dogs = new List<Dog>();
            //dogs.Add(new Dog("Somedog"));
            //Dog puppy = new Dog("littleOne");
            //dogs.Add(puppy);
            //dogs.Add(new Dog("aDog"));
            //dogs.Sort();
            //foreach (var dog in dogs)
            //{
            //    Console.WriteLine(dog.Describe());
            //}
            //foreach (var dog in dogs)
            //{
            //    Console.WriteLine(dog.Describe());
            //}
            //Console.Read();
            Dog comparable = new Dog("newname");
            Dog comparable2 = comparable;
            var a = comparable2.CompareTo(comparable);
            var b = a == 1 ? true : false;
            Console.WriteLine("Puppy a and b are same? "+b.ToString());
            var c = Dog.CompareNames(comparable, comparable2);
            Console.WriteLine("Puppy a and b are same? " + c.ToString());
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
                Console.WriteLine(this.Name);
            Console.WriteLine((obj as IAnimal).Name);
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
