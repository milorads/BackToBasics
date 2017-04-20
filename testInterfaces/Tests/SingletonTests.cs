using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using testInterfaces.Design_Patterns.Creational;

namespace testInterfaces.Tests
{
    class SingletonTests
    {
        [Test]
        public void TestSingletonInstances()
        {
            var s1 = Singleton.Instance();
            var s2 = Singleton.Instance();
            Assert.AreSame(s1,s2);
        }

        [Test]
        public void TestLoadBalancer()
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();
            var list = new List<LoadBalancer> {b1, b2, b3, b4};
            var i = 0;
            foreach (var v1 in list)
            {
                foreach (var v2 in list)
                {
                    Assert.AreSame(v1,v2);
                    i++;
                }
            }
            Assert.AreEqual(i,16);
        }
    }
}
