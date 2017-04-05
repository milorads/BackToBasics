using System;
using System.Collections;
using System.Collections.Generic;

namespace testInterfaces.KeyValuePairs
{
    public class HashtableAndDictionary
    {
        public static void Dictionary()
        {
            var testObj = new Dictionary<object, object> {{1, 1}, {"", ""}, {new object(), ""}};
            var testObject = new DictionaryTester(1, "a");
            testObj.Add(testObject, 1);

            var testObj2 = new Dictionary<dynamic, dynamic> {{1, 1}, {"", ""}, {new object(), ""}, {testObject, 1}};

            foreach (var item in testObj)
            {
                Console.WriteLine(item.Key.GetType() + "::" + item.Value.GetType());
                Console.WriteLine("Key: " + item.Key.ToString() + ", Value: " + item.Value.ToString());
            }
            foreach (var item in testObj2)
            {
                Console.WriteLine(item.Key.GetType()+ "::"+ item.Value.GetType());
                Console.WriteLine("Key: " + item.Key.ToString() + ", Value: " + item.Value.ToString());
            }
        }
        public static void Hashtable()
        {
            var testHash = new Hashtable();
            testHash.Add(1, 1);
            testHash.Add("", "");
            testHash.Add(new object(), "");
            var testObject = new DictionaryTester(1, "a");
            testHash.Add(testObject, 1);
            foreach (var item in testHash.Keys)
            {
                Console.WriteLine(item.GetType());
                Console.WriteLine("Key: " + item.ToString());
            }
            foreach (var item in testHash.Values)
            {
                Console.WriteLine(item.GetType());
                Console.WriteLine("Value: " + item.ToString());
            }
        }
    }
    class DictionaryTester
    {
        private int _broj;
        private string _adddress;
        public DictionaryTester(int br, string adr)
        {
            this._broj = br;
            this._adddress = adr;
        }
        public DictionaryTester() { }
    }
}
