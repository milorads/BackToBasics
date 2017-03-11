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
            Program p = new Program();
            p.MethodToImplement();
            p.ParentInterfaceMethod();
            int br = p.wow();
            Console.WriteLine(br.ToString());
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
}
