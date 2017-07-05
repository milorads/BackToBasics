﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using testInterfaces.Design_Patterns.Structural;

namespace testInterfaces.Tests
{
    class ProxyTests
    {
        [Test]
        public static void TestProxy()
        {
            var text = new Proxy().Request(true);
            StringAssert.AreEqualIgnoringCase(text, "Called RealSubject.Request()");
        }

        [Test]
        public static void TestMathProxy()
        {
            var proxyImplement = new MathProxy();

            Assert.AreEqual(6, proxyImplement.Add(4,2));
            Assert.AreEqual(2, proxyImplement.Sub(4,2));
            Assert.AreEqual(8, proxyImplement.Mul(4,2));
            Assert.AreEqual(2, proxyImplement.Div(4,2));
        }
    }
}