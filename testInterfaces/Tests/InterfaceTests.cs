using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using testInterfaces;

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
    }
}
