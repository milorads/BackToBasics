using System.Data;
using BackToBasics.Topics.Design_Patterns.Behavioral.TemplateMethod;
using NUnit.Framework;

namespace BackToBasics.Tests.Design_Patterns.Behavioral
{
    class TemplateMethodTests
    {
        [Test]
        public static void TestTemplateMethod()
        {
            AbstractClassTemplate aA = new ConcreteClassA();
            StringAssert.AreEqualIgnoringCase(aA.TemplateMethod(true), "ConcreteClassA.PrimitiveOperation1()ConcreteClassA.PrimitiveOperation2()");

            AbstractClassTemplate aB = new ConcreteClassB();
            StringAssert.AreEqualIgnoringCase(aB.TemplateMethod(true), "ConcreteClassB.PrimitiveOperation1()ConcreteClassB.PrimitiveOperation2()");
        }
        [Test]
        public static void TestDataObjectTemplate()
        {
            DataAccessObject daoCategories = new Categories();
            var dsCat = daoCategories.Run(true);
            DataTable catTable = dsCat.Tables["Categories"];
            int i = 1;
            foreach (DataRow row in catTable.Rows)
            {
                Assert.True(row["CategoryName"].Equals("testCat"+i++));
            }
            i = 1;
            DataAccessObject daoProducts = new Products();
            var dsProd = daoProducts.Run(true);
            DataTable prodTable = dsProd.Tables["Products"];
            foreach (DataRow row in prodTable.Rows)
            {
                Assert.True(row["ProductName"].Equals("testProd" + i++));
            }
        }
    }
}
