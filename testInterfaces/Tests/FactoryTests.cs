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
        public void TestConcreteCreator()
        {
            var creators = new Creator[2];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();
            Assert.AreNotEqual(creators[0].FactoryMethod().GetType().Name, creators[1].FactoryMethod().GetType().Name);
            Assert.AreSame(creators[0].FactoryMethod().GetType().BaseType, creators[1].FactoryMethod().GetType().BaseType);
        }

        [Test]
        public void TestDocumentFactory()
        {
            var documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            Assert.AreNotEqual(documents[0].GetType().Name, documents[1].GetType().Name);
            Assert.AreSame(documents[0].GetType().BaseType, documents[1].GetType().BaseType);

            Assert.AreEqual(documents[0].Pages.Count, 3);
            Assert.AreEqual(documents[1].Pages.Count, 5);
        }
    }
}
