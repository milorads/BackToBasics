using System;
using NUnit.Framework;

namespace testInterfaces.Design_Patterns.Behavioral
{
    class IteratorTests
    {
        [Test]
        public static void TestIterator()
        {
            var a = new ConcreteAggregate
            {
                [0] = "Item A",
                [1] = "Item B",
                [2] = "Item C",
                [3] = "Item D"
            };

            var i = a.CreateIterator();

            var item = i.First();
            StringAssert.AreEqualIgnoringCase(item.ToString(), "Item A");
            while (item != null)
            {
                Assert.True(item.Equals("Item A")||item.Equals("Item B") || item.Equals("Item C") || item.Equals("Item D"));
                item = i.Next();
            }
        }
        [Test]
        public static void TestCollectionIterator()
        {
            var collection = new Collection
            {
                [0] = new Item("Item 0"),
                [1] = new Item("Item 1"),
                [2] = new Item("Item 2"),
                [3] = new Item("Item 3"),
                [4] = new Item("Item 4"),
                [5] = new Item("Item 5"),
                [6] = new Item("Item 6"),
                [7] = new Item("Item 7"),
                [8] = new Item("Item 8")
            };

            var iterator = collection.CreateIterator();

            iterator.Step = 2;
            var i = 0;


            for (var item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                StringAssert.AreEqualIgnoringCase(item.Name,"Item "+i);
                i += 2;
            }
        }
    }
}
