using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testInterfaces.Design_Patterns.Behavioral
{
    #region Structure Code
    /// <summary>
    /// The 'Aggregate' abstract class
    /// </summary>
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }

    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }

    /// <summary>
    /// The 'Iterator' abstract class
    /// </summary>
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;

        // Constructor
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        // Gets first iteration item
        public override object First()
        {
            return _aggregate[0];
        }

        // Gets next iteration item
        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }

            return ret;
        }

        // Gets current iteration item
        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        // Gets whether iterations are complete
        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
    }
    #endregion

    #region Implementation Code
    /// <summary>
    /// A collection item
    /// </summary>
    class Item
    {
        private string _name;

        // Constructor
        public Item(string name)
        {
            this._name = name;
        }

        // Gets name
        public string Name
        {
            get { return _name; }
        }
    }

    /// <summary>
    /// The 'Aggregate' interface
    /// </summary>
    interface IAbstractCollection
    {
        ImplementedIterator CreateIterator();
    }

    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    class Collection : IAbstractCollection
    {
        private ArrayList _items = new ArrayList();

        public ImplementedIterator CreateIterator()
        {
            return new ImplementedIterator(this);
        }

        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }

    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }

    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    class ImplementedIterator : IAbstractIterator
    {
        private readonly Collection _collection;
        private int _current = 0;

        // Constructor
        public ImplementedIterator(Collection collection)
        {
            _collection = collection;
        }

        // Gets first item
        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }

        // Gets next item
        public Item Next()
        {
            _current += Step;
            if (!IsDone)
                return _collection[_current] as Item;
            return null;
        }

        // Gets or sets stepsize
        public int Step { get; set; } = 1;

        // Gets current iterator item
        public Item CurrentItem => _collection[_current] as Item;

        // Gets whether iteration is complete
        public bool IsDone => _current >= _collection.Count;
    }
    #endregion
}
