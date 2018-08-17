using BackToBasics.Topics.Design_Patterns.Structural.Flyweight;
using NUnit.Framework;

namespace BackToBasics.Tests.Design_Patterns.Structural
{
    class FlyweightTests
    {
        [Test]
        public static void TestFlyweight()
        {
            var extrinsicstate = 22;

            var factory = new FlyweightFactory();

            var fx = factory.GetFlyweight("X");
            StringAssert.AreEqualIgnoringCase(fx.Operation(--extrinsicstate, true), "ConcreteFlyweight: "+extrinsicstate);

            var fy = factory.GetFlyweight("Y");
            StringAssert.AreEqualIgnoringCase(fy.Operation(--extrinsicstate, true), "ConcreteFlyweight: " + extrinsicstate);

            var fz = factory.GetFlyweight("Z");
            StringAssert.AreEqualIgnoringCase(fz.Operation(--extrinsicstate, true), "ConcreteFlyweight: " + extrinsicstate);

            var fu = new
                UnsharedConcreteFlyweight();

            StringAssert.AreEqualIgnoringCase(fu.Operation(--extrinsicstate, true), "UnsharedConcreteFlyweight: " + extrinsicstate);
        }
        [Test]
        public static void TestCharacterFactory()
        {
            var document = "AAZZBBZB";
            var chars = document.ToCharArray();

            var factoryImplementation = new CharacterFactory();

            var pointSize = 10;

            foreach (var c in chars)
            {
                pointSize++;
                var character = factoryImplementation.GetCharacter(c);
                StringAssert.AreEqualIgnoringCase(character.Display(pointSize, true),c.ToString()+pointSize.ToString());
            }
        }
    }
}
