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
            #region sample 2
            VehicleBuilder builder;

            var shop = new Shop();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            #endregion
        }
    }
}
