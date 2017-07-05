using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using testInterfaces.Design_Patterns.Structural;

namespace testInterfaces.Tests
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
            Assert.True(benzeneProperty[0].Equals("100") && benzeneProperty[1].Equals("0") && benzeneProperty[2].Equals("18.01") && benzeneProperty[3].Equals("H2O"));
            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
            var ethanolProperty = ethanol.Display(true).Split('|');
            Assert.True(ethanolProperty[0].Equals("100") && ethanolProperty[1].Equals("0") && ethanolProperty[2].Equals("18.01") && ethanolProperty[3].Equals("H2O"));

            var d = "";
        }
    }
}
