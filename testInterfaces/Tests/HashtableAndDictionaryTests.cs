using NUnit.Framework;

namespace testInterfaces.KeyValuePairs
{
    [TestFixture]
    public class HashtableAndDictionaryTests
    {
        [Test]
        public void TestDictionary()
        {
            try
            {
                testInterfaces.KeyValuePairs.HashtableAndDictionary.Dictionary();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void TestHashtable()
        {
            try
            {
                testInterfaces.KeyValuePairs.HashtableAndDictionary.Hashtable();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

    }
}
