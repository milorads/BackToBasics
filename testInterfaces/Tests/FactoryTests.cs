using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using testInterfaces.Design_Patterns.Creational;

namespace testInterfaces.Tests
{
    class FactoryTests
    {
        [Test]
        public void Test()
        {
            //1st sample to be rewritten
            var creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products
            foreach (var creator in creators)
            {
                var product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
            //2nd sample to be rewritten
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
        }
    }
}
