using System;
using System.Collections.Generic;
using NUnit.Framework;
using Polynomial;

namespace testInterfaces.Interfaces
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
                Assert.IsTrue(testBool);
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
            Assert.IsTrue(c);
        }

        [Test]
        public void TestInterfaceJedanDva()
        {
            var p = new Program();
            var oneInterfaceReturnsString = p.IzJedinice(true);
            StringAssert.AreEqualIgnoringCase("one method from one interface", oneInterfaceReturnsString);
            var twoInterfaceReturnsInt = ((Idva)p).IzJedinice();
            Assert.AreEqual(1,twoInterfaceReturnsInt);
            var oneInterfaceSameMethodCall = ((Ijedan)p).SameName(true);
            StringAssert.AreEqualIgnoringCase("calling samename from ijedan", oneInterfaceSameMethodCall);
            var twoInterfaceSameMethodCall = (p as Idva).SameName(true);
            StringAssert.AreEqualIgnoringCase("calling samename from idva", twoInterfaceSameMethodCall);
        }

        [Test]
        public void TestVirtuals()
        {
            var t = new testVirtual();
            var p = new Program();
            var virtualVar1 = t.Foo(true);
            StringAssert.AreEqualIgnoringCase("i do something you might not want me to.", virtualVar1);
            var virtualVar2 = p.Foo(true);
            StringAssert.AreEqualIgnoringCase("now it does what you wait it to.", virtualVar2);
            var virtualVar3 = p.Foo(false);
            StringAssert.AreEqualIgnoringCase("i do something you might not want me to.", virtualVar3);
        }
    }
}
