using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using testInterfaces;
using Polynomial;

namespace testInterfaces.Tests
{
    [TestFixture]
    class InterfaceTests
    {
        [Test]
        public void TestInterfaceface()
        {
            try
            {
                Program.InterfacesTester();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void TestImplementations()
        {
            var p = new Program();
            StringAssert.AreEqualIgnoringCase(p.MethodToImplement(true), "MethodToImplement() called.");
            StringAssert.AreEqualIgnoringCase(p.ParentInterfaceMethod(true), "ParentInterfaceMethod() called.");
        }

        [Test]
        public void TestNumber()
        {
            var p = new Program();
            Assert.AreEqual(p.wow(), 1);

            var a = Driver.Eval(new Double[] { 5.5 }, true);

            //asserts

            var coeff =
            new double[] { 5.5, 7.0, 15, 30, 500, 100, 1 };

            var b = Driver.Eval(coeff, true);

            var keys = (List<string>)b["keys"];
            foreach (var VARIABLE in keys)
            {
                var test = b[VARIABLE];
                var typeOf = test.GetType();
                switch (typeOf.Name)
                {
                    case "Int32":
                        //assert
                        Assert.AreEqual(test, 7);
                        break;
                    case "Double":
                        //assert
                        Assert.AreEqual(test.GetType(), 24525142.801820118.GetType());
                        break;
                    case "PolySimple":
                        //assert
                        Assert.AreEqual(test.GetType(), new PolySimple().GetType());
                        break;
                }
            }
            var coeff2 = new double[50];
            for (var index = 0; index < 50; index++)
            {
                coeff2[index] = index;
            }
            var testVar = Driver.Eval(coeff2, true);
            var bbb = 0;
            var keys2 = (List<string>)testVar["keys"];
            foreach (var VARIABLE in keys2)
            {
                var test = b[VARIABLE];
                var typeOf = test.GetType();
                switch (typeOf.Name)
                {
                    case "Int32":
                        //assert
                        Assert.AreEqual(test, 7);
                        break;
                    case "Double":
                        //assert
                        Assert.AreEqual(test.GetType(), 24525142.801820118.GetType());
                        break;
                    case "PolySimple":
                        //assert
                        Assert.AreEqual(test.GetType(), new PolySimple().GetType());
                        break;
                }
            }
        }
    }
}
