using System;
using System.Collections.Generic;

namespace BackToBasics.Topics.Design_Patterns.Behavioral.Mediator
{
    #region Sample code
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    abstract class Mediator
    {
        public abstract void Send(string message,
            Colleague colleague);

        public abstract Colleague Send(Colleague col);
    }

    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 _colleague1;
        private ConcreteColleague2 _colleague2;

        public ConcreteColleague1 Colleague1
        {
            set { _colleague1 = value; }
        }

        public ConcreteColleague2 Colleague2
        {
            set { _colleague2 = value; }
        }

        public override void Send(string message,
            Colleague colleague)
        {
            if (colleague == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else
            {
                _colleague1.Notify(message);
            }
        }

        public override Colleague Send(Colleague colleague)
        {
            if (colleague == _colleague1)
            {
                return _colleague2;
            }
            else
            {
                return _colleague1;
            }
        }
    }

    /// <summary>
    /// The 'Colleague' abstract class
    /// </summary>
    abstract class Colleague
    {
        protected Mediator mediator;

        // Constructor
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public Colleague Send(Colleague col)
        {
            return mediator.Send(col);
        }
    }

    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    class ConcreteColleague1 : Colleague
    {
        // Constructor
        public ConcreteColleague1(Mediator mediator)
            : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 gets message: "
                              + message);
        }
    }

    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    class ConcreteColleague2 : Colleague
    {
        // Constructor
        public ConcreteColleague2(Mediator mediator)
            : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague2 gets message: "
                              + message);
        }
    }
    #endregion

    #region Implementation code
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    abstract class AbstractChatroom
    {
        public abstract void Register(Participant participant);
        public abstract void Send(
            string from, string to, string message);
        public abstract Dictionary<string,string> Send(
            string from, string to, string message, bool test, string fromPart);
    }

    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    class Chatroom : AbstractChatroom
    {
        private Dictionary<string, Participant> _participants =
            new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }

        public Dictionary<string, Participant> GetParticipants()
        {
            return _participants;
        }

        public override void Send(
            string from, string to, string message)
        {
            Participant participant = _participants[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }

        public override Dictionary<string, string> Send(
            string from, string to, string message, bool test, string fromPart)
        {
            var dict = new Dictionary<string,string>();
            Participant participant = _participants[to];
            dict.Add("from", fromPart);
            var fromDict = new Dictionary<string, string>();
            if (participant != null)
            {
                fromDict = participant.Receive(from, message, true);
            }
            foreach (var val in fromDict)
            {
                dict.Add(val.Key,val.Value);
            }
            return dict;
        }
    }

    /// <summary>
    /// The 'AbstractColleague' class
    /// </summary>
    class Participant
    {
        private Chatroom _chatroom;
        private string _name;

        // Constructor
        public Participant(string name)
        {
            this._name = name;
        }

        // Gets participant name
        public string Name
        {
            get { return _name; }
        }

        // Gets chatroom
        public Chatroom Chatroom
        {
            set { _chatroom = value; }
            get { return _chatroom; }
        }

        // Sends message to given participant
        public void Send(string to, string message)
        {
            _chatroom.Send(_name, to, message);
        }

        public Dictionary<string,string> Send(string to, string message, bool test)
        {
            var from = this.Name;
            return _chatroom.Send(_name, to, message, test, from);
        }

        // Receives message from given participant
        public virtual void Receive(
            string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",
                from, Name, message);
        }

        public virtual Dictionary<string,string> Receive(
            string from, string message, bool test)
        {
            return new Dictionary<string, string>(){{"to", Name},{"msg", message} };
        }
    }

    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    class Beatle : Participant
    {
        // Constructor
        public Beatle(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }

    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    class NonBeatle : Participant
    {
        // Constructor
        public NonBeatle(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
    #endregion
}
