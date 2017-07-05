using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using testInterfaces.Design_Patterns.Structural;

namespace testInterfaces.Design_Patterns.Behavioral
{
    class FlyweightTests
    {
        [Test]
        public static void TestFlyweight()
        {
            var extrinsicstate = 22;

            var factory = new FlyweightFactory();

            // Work with different flyweight instances
            var fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            var fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            var fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            var fu = new
                UnsharedConcreteFlyweight();

            fu.Operation(--extrinsicstate);
        }
        [Test]
        public static void TestCharacterFactory()
        {
            // Build a document with text
            var document = "AAZZBBZB";
            var chars = document.ToCharArray();

            var factoryImplementation = new CharacterFactory();

            // extrinsic state
            var pointSize = 10;

            // For each character use a flyweight object
            foreach (var c in chars)
            {
                pointSize++;
                var character = factoryImplementation.GetCharacter(c);
                character.Display(pointSize);
            }
        }
    }
}
