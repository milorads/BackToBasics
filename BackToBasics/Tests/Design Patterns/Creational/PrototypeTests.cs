using System.Diagnostics;
using BackToBasics.Topics.Design_Patterns.Creational.Prototype;
using NUnit.Framework;

namespace BackToBasics.Tests.Design_Patterns.Creational
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

            var r = ((Color)colormanager["flame"]).Red;
            var g = ((Color)colormanager["flame"]).Green;
            var b = ((Color)colormanager["flame"]).Blue;

            Debug.Assert(color3 != null, "color3 != null");
            Assert.AreEqual(color3.Red, r);
            Assert.AreEqual(color3.Green, g);
            Assert.AreEqual(color3.Blue, b);
        }
    }
}
