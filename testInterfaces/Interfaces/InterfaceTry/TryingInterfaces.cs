using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testInterfaces.Interfaces
{

    class ProgramExtender : testVirtual, IMyInterface, IMultipleInheritance, Ijedan, Idva //absClass,IMyInterface, IMultipleInheritance,Ijedan,Idva
    {
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
        public string MethodToImplement(bool test)
        {
            return "MethodToImplement() called.";
        }

        public void ParentInterfaceMethod()
        {
            Console.WriteLine("ParentInterfaceMethod() called.");
        }

        public string ParentInterfaceMethod(bool test)
        {
            return "ParentInterfaceMethod() called.";
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
        public string IzJedinice(bool test)
        {
            return "one method from one interface";
        }

        void Idva.SameName()
        {
            Console.WriteLine("calling samename from idva");
        }

        string Idva.SameName(bool test)
        {
            return "calling samename from idva";
        }

        void Ijedan.SameName()
        {
            Console.WriteLine("calling samename from ijedan");
        }


        string Ijedan.SameName(bool test)
        {
            return "calling samename from ijedan";
        }

        int Idva.IzJedinice()
        {
            Console.WriteLine("one method from two interface");
            return 1;
        }
    }
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

        string SameName(bool test);
    }

    interface Idva
    {
        int IzJedinice();
        void SameName();
        string SameName(bool test);
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
}
