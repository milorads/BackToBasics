using System;
using System.Collections.Generic;

namespace BackToBasics.Topics.Design_Patterns.Creational.Singleton
{
    /// <summary>
    /// Non thread-safe singleton
    /// </summary>
    class Singleton
    {
        private static Singleton _instance;

        protected Singleton() { }

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
    /// <summary>
    /// Thread-safe without locking everytime
    /// p.s. doesn't work in java (to be checked)
    /// </summary>
    class SingletonTS
    {
        private static SingletonTS _instance = null;
        private static readonly object padlock = new object();
        SingletonTS() { }

        public static SingletonTS Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonTS();
                        }
                    }
                }
                return _instance;
            }
        }
    }
    /// <summary>
    /// Well performing solution that also allow checking if the instance is created with the IsValueCreated property
    /// </summary>
    class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> lazy = new Lazy<SingletonLazy>(() => new SingletonLazy());

        public static SingletonLazy Instance { get { return lazy.Value; } }

        private SingletonLazy() { }
    }
    /// <summary>
    /// Implementation example (singleton TS)
    /// </summary>
    class LoadBalancer
    {
        private static LoadBalancer _instance;
        private List<string> _servers = new List<string>();
        private List<Servers> _serversEnumList = new List<Servers>();
        private Random _random = new Random();

        // Lock synchronization object
        private static object syncLock = new object();

        // Constructor (protected)
        protected LoadBalancer()
        {
            // List of available servers
            //_servers.Add(Servers.ServerI.ToString());
            //_servers.Add(Servers.ServerII.ToString());
            //_servers.Add(Servers.ServerIII.ToString());
            //_servers.Add(Servers.ServerIV.ToString());
            //_servers.Add(Servers.ServerV.ToString());
            foreach (Servers server in Enum.GetValues(typeof(Servers)))
            {
                _servers.Add(server.ToString());
                _serversEnumList.Add(server);
            }
        }

        public enum Servers
        {
            ServerI,
            ServerII,
            ServerIII,
            ServerIV,
            ServerV
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }

        // Simple, but effective random load balancer
        public string Server
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }

        public Servers ServerEnum
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _serversEnumList[r];
            }
        }
    }
}
