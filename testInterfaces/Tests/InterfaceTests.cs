using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using testInterfaces;
using Polynomial;
using testInterfaces.Interfaces;

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

        [Test]
        public void TestDogs()
        {
            var dogs = new List<Dog>();
            dogs.Add(new Dog("Somedog"));
            var puppy = new Dog("littleOne");
            dogs.Add(puppy);
            dogs.Add(new Dog("aDog"));
            dogs.Sort();
            foreach (var dog in dogs)
            {
                var testBool = dog.Describe().Contains("Hello, I'm a dog and my name is") &&
                               dog.Describe().Contains(dog.Name);
                Assert.AreEqual(true,testBool);
            }
            puppy.Name = "newDog";
            foreach (var dog in dogs)
            {
                var testBool2 = dog.Describe().Contains("Hello, I'm a dog and my name is") &&
                                !dog.Describe().Contains("littleOne");
                Assert.AreEqual(true, testBool2);
            }
            var comparable = new Dog("newname");
            Assert.AreEqual("newname", comparable.Name);
            var comparable2 = new Dog("newname");
            Assert.AreEqual("newname", comparable2.Name);
            var a = comparable2.CompareTo(comparable);
            Assert.AreEqual(a, 1);
            var c = Dog.CompareNames(comparable, comparable2);
            Assert.AreEqual(c, true);
        }
    }
}
