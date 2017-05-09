using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using testInterfaces.Design_Patterns.Creational;

namespace testInterfaces.Tests
{
    class PrototypeTests
    {
        [Test] public void TestClone()
        {
            var p1 = new ConcretePrototype1("I");
            var c1 = (ConcretePrototype1)p1.Clone();
            Assert.AreEqual(p1.Id,c1.Id);
            var p2 = new ConcretePrototype2("II");
            var c2 = (ConcretePrototype2)p2.Clone();
            Assert.AreEqual(p2.Id, c2.Id);
        }
        [Test]
        public void TestColorClone()
        {
            var colormanager = new ColorManager();

            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            foreach (var color in colormanager.getKeys())
            {
                Assert.AreEqual(typeof(Color), colormanager[color].GetType());
            }

            var color1 = colormanager["red"].Clone() as Color;
            Assert.AreEqual(typeof(Color), colormanager["red"].GetType());
            var color2 = colormanager["peace"].Clone() as Color;
            Assert.AreEqual(typeof(Color), colormanager["peace"].GetType());
            var color3 = colormanager["flame"].Clone() as Color;
            Assert.AreEqual(typeof(Color), colormanager["flame"].GetType());

            var r = ((Color)colormanager["flame"])._red;
            var g = ((Color)colormanager["flame"])._green;
            var b = ((Color)colormanager["flame"])._blue;

            Assert.AreEqual(color3._red, r);
            Assert.AreEqual(color3._green, g);
            Assert.AreEqual(color3._blue, b);
        }
    }
}
