using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using testInterfaces.Design_Patterns.Structural;

namespace testInterfaces.Design_Patterns.Behavioral
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
            Assert.True(root.Display(1,true).Item2.Contains(root.Display(1, true).Item2.FirstOrDefault(t => t.GetName() == "Leaf C")));

            var leaf = new Leaf("Leaf D");
            root.Add(leaf);
            Assert.True(root.Display(1, true).Item2.Contains(leaf));
            root.Remove(leaf);
            Assert.False(root.Display(1, true).Item2.Contains(leaf));
        }

        [Test]
        public static void TestCompositeElement()
        {
            var rootImpl = new CompositeElement("Picture");
            var redLine = new PrimitiveElement("Red Line");
            rootImpl.Add(redLine);
            var blueCircle = new PrimitiveElement("Blue Circle");
            rootImpl.Add(blueCircle);
            var greenBox = new PrimitiveElement("Green Box");
            rootImpl.Add(greenBox);

            var compImpl = new CompositeElement("Two Circles");
            var blackCircle = new PrimitiveElement("Black Circle");
            compImpl.Add(blackCircle);
            var whiteCircle = new PrimitiveElement("White Circle");
            compImpl.Add(whiteCircle);
            rootImpl.Add(compImpl);
            var a = rootImpl;
            var b = "";
            foreach (var element in rootImpl.Display(1,true).Item2)
            {
                if (element.GetType() == typeof(PrimitiveElement))
                {
                    Assert.True(element.Equals(redLine) || element.Equals(blueCircle) || element.Equals(greenBox));
                }
                else if (element.GetType() == typeof(CompositeElement))
                {
                    foreach (var el2 in element.Display(1,true).Item2)
                    {
                        Assert.True(el2.Equals(blackCircle) || el2.Equals(whiteCircle));
                    }

                }
            }
            var pe = new PrimitiveElement("Yellow Line");
            StringAssert.AreEqualIgnoringCase(rootImpl.Add(pe, true),"");
            StringAssert.AreEqualIgnoringCase(rootImpl.Remove(pe, true),"");
        }
    }
}
