using BackToBasics.Topics.Data_Structures.KeyValuePairs;
using NUnit.Framework;

namespace BackToBasics.Tests.Data_Structures
{
    [TestFixture]
    public class HashtableAndDictionaryTests
    {
        [Test]
        public void TestDictionary()
        {
            try
            {
                HashtableAndDictionary.Dictionary();
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
                HashtableAndDictionary.Hashtable();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}
