using NUnit.Framework;
using testInterfaces.Design_Patterns.Structural;

namespace testInterfaces.Design_Patterns.Behavioral
{
    class AdapterTests
    {
        [Test]
        public static void TestAdapter()
        {
            Target target = new Adapter();
            StringAssert.AreEqualIgnoringCase(target.Request(true), "Called Target Request()");
        }
        [Test]
        public static void TestCompunds()
        {
            var unknown = new Compound("Unknown");
            StringAssert.AreEqualIgnoringCase(unknown.Display(true), "Unknown");

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();
            var waterProperty = water.Display(true).Split('|');
            Assert.True(waterProperty[0].Equals("100") && waterProperty[1].Equals("0") && waterProperty[2].Equals("18.015") && waterProperty[3].Equals("H20"));
            Compound benzene = new RichCompound("Benzene");
            benzene.Display();
            var benzeneProperty = benzene.Display(true).Split('|');
            Assert.True(benzeneProperty[0].Equals("80.1") && benzeneProperty[1].Equals("5.5") && benzeneProperty[2].Equals("78.1134") && benzeneProperty[3].Equals("C6H6"));
            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
            var ethanolProperty = ethanol.Display(true).Split('|');
            Assert.True(ethanolProperty[0].Equals("78.3") && ethanolProperty[1].Equals("-114.1") && ethanolProperty[2].Equals("46.0688") && ethanolProperty[3].Equals("C2H5OH"));
        }
    }
}
