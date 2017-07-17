using NUnit.Framework;

namespace testInterfaces.Design_Patterns.Behavioral
{
    class MediatorTests
    {
        [Test]
        public static void TestMediator()
        {
            #region sample 1
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;
            var a = c1.Send(c2);
            Assert.AreEqual(c1.Send(c2), c1);
            Assert.AreEqual(c2.Send(c1), c2);
            #endregion


        }
        [Test]
        public static void TestChatroom()
        {
            #region sample 2
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

            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");
            #endregion
        }
    }
}
