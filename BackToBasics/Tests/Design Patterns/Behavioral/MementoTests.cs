using BackToBasics.Topics.Design_Patterns.Behavioral.Memento;
using NUnit.Framework;

namespace BackToBasics.Tests.Design_Patterns.Behavioral
{
    [TestFixture]
    class MementoTests
    {
        [Test]
        public void SampleMementoTest()
        {
            Originator o = new Originator { State = "On" };
            StringAssert.AreEqualIgnoringCase(o.State, "On");
            Caretaker c = new Caretaker { Memento = o.CreateMemento() };
            o.State = "Off";
            StringAssert.AreEqualIgnoringCase(o.State, "Off");
            o.SetMemento(c.Memento);
            StringAssert.AreEqualIgnoringCase(o.State, "On");
        }
        [Test]
        public void SaveProspectStateTest()
        {
            SalesProspect s = new SalesProspect
            {
                Name = "Noel van Halen",
                Phone = "(412) 256-0990",
                Budget = 25000.0
            };
            StringAssert.AreEqualIgnoringCase(s.Name, "Noel van Halen");
            StringAssert.AreEqualIgnoringCase(s.Phone, "(412) 256-0990");
            Assert.AreEqual(s.Budget, 25000.0);

            ProspectMemory m = new ProspectMemory { Memento = s.SaveMemento() };
            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;
            StringAssert.AreEqualIgnoringCase(s.Name, "Leo Welch");
            StringAssert.AreEqualIgnoringCase(s.Phone, "(310) 209-7111");
            Assert.AreEqual(s.Budget, 1000000.0);

            s.RestoreMemento(m.Memento);

            StringAssert.AreEqualIgnoringCase(s.Name, "Noel van Halen");
            StringAssert.AreEqualIgnoringCase(s.Phone, "(412) 256-0990");
            Assert.AreEqual(s.Budget, 25000.0);
        }
    }
}
