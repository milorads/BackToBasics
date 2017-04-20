using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        [Test]
        public void TestServerLoadBalancer()
        {
            var balancer = LoadBalancer.GetLoadBalancer();
            var serverLoadCounter = new Dictionary<LoadBalancer.Servers, double>();
            foreach (LoadBalancer.Servers server in Enum.GetValues(typeof(LoadBalancer.Servers)))
            {
                serverLoadCounter.Add(server,0);
            }
            const int iterations = 10000;
            for (var i = 0; i < iterations; i++)
            {
                var server = balancer.ServerEnum;
                var counterValue = serverLoadCounter[server];
                serverLoadCounter[server] = counterValue+1;
            }
            var load = checkLoad(iterations, serverLoadCounter);
            // if the test fails that is because the logic of 30% around nominal needs to be satisfied in every moment needs to be implemented insted of the random function (Server and ServerEnum methods in LoadBalancer)
            Assert.IsTrue(load);
        }

        private static bool checkLoad(int iter, Dictionary<LoadBalancer.Servers, double> input)
        {
            int servCount = input.Count;
            bool outValue = false;
            var nominal = iter / servCount;
            var upDown = nominal * 0.3;
            foreach (var serverLoad in input)
            {
                if (serverLoad.Value < nominal+upDown && serverLoad.Value > nominal-upDown)
                {
                    outValue = true;
                }
                else
                {
                    return false;
                }
            }
            return outValue;
        }
    }
}
