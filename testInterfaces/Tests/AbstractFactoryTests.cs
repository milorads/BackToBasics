using NUnit.Framework;
using testInterfaces.Design_Patterns.Creational;

namespace testInterfaces.Tests
{
    class AbstractFactoryTests
    {
        [Test]
        public static void TestAbstractFactory()
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            var client1 = new Client(factory1);

            AbstractFactory factory2 = new ConcreteFactory2();
            var client2 = new Client(factory2);

            Assert.AreNotEqual(factory1.GetType().Name, factory2.GetType().Name);
            Assert.AreSame(factory1.GetType().BaseType, factory2.GetType().BaseType);

            Assert.AreSame(client1.GetType(),client2.GetType());

            StringAssert.AreEqualIgnoringCase("ProductB1 interacts with ProductA1", client1.Run(true));
            StringAssert.AreEqualIgnoringCase("ProductB2 interacts with ProductA2", client2.Run(true));
        }

        [Test]
        public static void TestContinentFactory()
        {
            ContinentFactory africa = new AfricaFactory();
            var world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
        }
    }
}
