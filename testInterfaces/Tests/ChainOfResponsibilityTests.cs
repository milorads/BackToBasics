using NUnit.Framework;

namespace testInterfaces.Design_Patterns.Behavioral
{
    class ChainOfResponsibilityTests
    {
        [Test]
        public static void TestChainOfResp()
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                var handler = h1.HandleRequest(request, true);
                if (request >= 0 && request < 10)
                {
                    Assert.AreEqual(h1, handler);
                }
                else if (request >= 10 && request < 20)
                {
                    Assert.AreEqual(h2, handler);
                }
                else
                {
                    Assert.AreEqual(h3, handler);
                }
            }
        }
        [Test]
        public static void TestApprovals()
        {
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            Purchase p = new Purchase(2034, 350.00, "Assets");
            var p1result = larry.ProcessRequest(p, true);
            Assert.AreEqual(p1result, larry);
            p = new Purchase(2035, 32590.10, "Project X");
            var p2result = larry.ProcessRequest(p, true);
            Assert.AreEqual(p2result, tammy);
            p = new Purchase(2036, 122100.00, "Project Y");
            var p3result = larry.ProcessRequest(p, true);
            Assert.AreEqual(p3result, null);
        }
    }
}
