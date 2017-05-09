using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using testInterfaces.Design_Patterns.Creational;

namespace testInterfaces.Tests
{
    class BuilderTests
    {
        [Test]
        public void TestBuilder()
        {
            var director = new Director();
            var partsAb = new List<string> {"PartA", "PartB"};
            var partsXy = new List<string> { "PartX", "PartY" };

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            var p1 = b1.GetResult();
            var list = p1.Show(true);
            foreach (var pt in partsAb)
            {
                Assert.Contains(pt,list);
            }

            director.Construct(b2);
            var p2 = b2.GetResult();
            var list2 = p2.Show(true);
            foreach (var pt in partsXy)
            {
                Assert.Contains(pt, list2);
            }
        }

        [Test]
        public void TestCarBuilder()
        {
            var shop = new Shop();

            VehicleBuilder builder = new ScooterBuilder();
            shop.Construct(builder);
            var scooter = builder.Vehicle.Show(true);
            Assert.AreEqual(scooter["frame"], "Scooter Frame");
            Assert.AreEqual(scooter["engine"], "50 cc");
            Assert.AreEqual(scooter["wheels"], "2");
            Assert.AreEqual(scooter["doors"], "0");

            builder = new CarBuilder();
            shop.Construct(builder);
            var car = builder.Vehicle.Show(true);
            Assert.AreEqual(car["frame"], "Car Frame");
            Assert.AreEqual(car["engine"], "2500 cc");
            Assert.AreEqual(car["wheels"], "4");
            Assert.AreEqual(car["doors"], "4");

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            var motor = builder.Vehicle.Show(true);
            Assert.AreEqual(motor["frame"], "MotorCycle Frame");
            Assert.AreEqual(motor["engine"], "500 cc");
            Assert.AreEqual(motor["wheels"], "2");
            Assert.AreEqual(motor["doors"], "0");
        }
    }
}
