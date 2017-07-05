using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using testInterfaces.Design_Patterns.Structural;

namespace testInterfaces.Tests
{
    class CompositeTests
    {
        [Test]
        public static void TestComposite()
        {
            var root = new Composite("root");
            var leafA = new Leaf("Leaf A");
            root.Add(leafA);
            var leafB = new Leaf("Leaf B");
            root.Add(leafB);
            Assert.True(root.Display(1, true).Item2.Contains(leafA));
            Assert.True(root.Display(1, true).Item2.Contains(leafB));

            var comp = new Composite("Composite X");
            var leafXa = new Leaf("Leaf XA");
            comp.Add(leafXa);
            var leafXb = new Leaf("Leaf XB");
            comp.Add(leafXb);
            Assert.False(root.Display(1, true).Item2.Contains(leafXa));
            Assert.False(root.Display(1, true).Item2.Contains(leafXb));

            root.Add(comp);
            Assert.False(root.Display(1, true).Item2.Contains(leafXa));
            Assert.False(root.Display(1, true).Item2.Contains(leafXb));
            Assert.True(root.Display(1, true).Item2.Contains(comp));
            root.Add(new Leaf("Leaf C"));
            Assert.False(root.Display(1, true).Item2.Contains(new Leaf("Leaf C")));
            var test2 = root.Display(1, true).Item2.FirstOrDefault(t => t.GetName() == "Leaf C");
            Assert.True(root.Display(1,true).Item2.Contains(root.Display(1, true).Item2.FirstOrDefault(t => t.GetName() == "Leaf C")));
            // Add and remove a leaf
            var leaf = new Leaf("Leaf D");
            root.Add(leaf);
            Assert.True(root.Display(1, true).Item2.Contains(leaf));
            root.Remove(leaf);
            Assert.False(root.Display(1, true).Item2.Contains(leaf));
        }

        [Test]
        public static void TestCompositeElement()
        {
            var root = new Composite("root");
            var comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));
            // Create a tree structure
            var rootImplementation =
                new CompositeElement("Picture");
            rootImplementation.Add(new PrimitiveElement("Red Line"));
            rootImplementation.Add(new PrimitiveElement("Blue Circle"));
            rootImplementation.Add(new PrimitiveElement("Green Box"));

            // Create a branch
            var compImplementation =
                new CompositeElement("Two Circles");
            compImplementation.Add(new PrimitiveElement("Black Circle"));
            compImplementation.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement
            var pe =
                new PrimitiveElement("Yellow Line");
            rootImplementation.Add(pe);
            rootImplementation.Remove(pe);

            // Recursively display nodes
            root.Display(1);
        }
    }
}
