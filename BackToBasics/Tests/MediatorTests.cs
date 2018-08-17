using NUnit.Framework;

namespace testInterfaces.Design_Patterns.Behavioral
{
    class MediatorTests
    {
        [Test]
        public static void TestMediator()
        {
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;
            var a = c1.Send(c2);
            Assert.AreEqual(c1.Send(c2), c1);
            Assert.AreEqual(c2.Send(c1), c2);
        }
        [Test]
        public static void TestChatroom()
        {
            Chatroom chatroom = new Chatroom();

            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);
            var participantsByName = chatroom.GetParticipants();
            Assert.True(participantsByName.ContainsKey("George") && participantsByName.ContainsKey("Paul") &&
                participantsByName.ContainsKey("Ringo") && participantsByName.ContainsKey("John") && participantsByName.ContainsKey("Yoko"));

            var ytj = Yoko.Send("John", "Hi John!", true);
            StringAssert.AreEqualIgnoringCase(ytj["from"], "Yoko");
            StringAssert.AreEqualIgnoringCase(ytj["to"], "John");
            StringAssert.AreEqualIgnoringCase(ytj["msg"], "Hi John!");
            var ptr = Paul.Send("Ringo", "All you need is love", true);
            StringAssert.AreEqualIgnoringCase(ptr["from"], "Paul");
            StringAssert.AreEqualIgnoringCase(ptr["to"], "Ringo");
            StringAssert.AreEqualIgnoringCase(ptr["msg"], "All you need is love");
            var rtg = Ringo.Send("George", "My sweet Lord", true);
            StringAssert.AreEqualIgnoringCase(rtg["from"], "Ringo");
            StringAssert.AreEqualIgnoringCase(rtg["to"], "George");
            StringAssert.AreEqualIgnoringCase(rtg["msg"], "My sweet Lord");
            var ptj = Paul.Send("John", "Can't buy me love", true);
            StringAssert.AreEqualIgnoringCase(ptj["from"], "Paul");
            StringAssert.AreEqualIgnoringCase(ptj["to"], "John");
            StringAssert.AreEqualIgnoringCase(ptj["msg"], "Can't buy me love");
            var jty = John.Send("Yoko", "My sweet love", true);
            StringAssert.AreEqualIgnoringCase(jty["from"], "John");
            StringAssert.AreEqualIgnoringCase(jty["to"], "Yoko");
            StringAssert.AreEqualIgnoringCase(jty["msg"], "My sweet love");
        }
    }
}
