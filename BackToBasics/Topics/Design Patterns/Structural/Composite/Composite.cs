﻿using System;
using System.Collections.Generic;

namespace BackToBasics.Topics.Design_Patterns.Structural.Composite
{
    #region Structure code
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    abstract class Component
    {
        protected string name;

        // Constructor
        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);

        public abstract Tuple<string, List<Component>> Display(int depth, bool test);
        public abstract string GetName();
    }

    /// <summary>
    /// The 'Composite' class
    /// </summary>
    class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        // Constructor
        public Composite(string name)
          : base(name)
        {
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            // Recursively display child nodes
            foreach (var component in _children)
            {
                component.Display(depth + 2);
            }
        }

        public override Tuple<string, List<Component>> Display(int depth, bool test)
        {
            return new Tuple<string, List<Component>>(name,_children);
        }

        public override string GetName()
        {
            return name;
        }
    }

    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    class Leaf : Component
    {
        // Constructor
        public Leaf(string name)
          : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

        public override Tuple<string, List<Component>> Display(int depth, bool test)
        {
            return new Tuple<string, List<Component>>(name, null);
        }

        public override string GetName()
        {
            return name;
        }
    }
    #endregion

    #region Implementation code
    /// <summary>
    /// The 'Component' Treenode
    /// </summary>
    abstract class DrawingElement
    {
        protected string _name;

        // Constructor
        public DrawingElement(string name)
        {
            this._name = name;
        }

        public abstract void Add(DrawingElement d);
        public abstract string Add(DrawingElement d, bool test);
        public abstract void Remove(DrawingElement d);
        public abstract string Remove(DrawingElement d, bool test);
        public abstract void Display(int indent);

        public abstract Tuple<string, List<DrawingElement>> Display(int indent, bool test);
    }

    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    class PrimitiveElement : DrawingElement
    {
        // Constructor
        public PrimitiveElement(string name)
          : base(name)
        {
        }

        public override void Add(DrawingElement c)
        {
            Console.WriteLine(
              "Cannot add to a PrimitiveElement");
        }

        public override string Add(DrawingElement d, bool test)
        {
            return "Cannot add to a PrimitiveElement";
        }


        public override void Remove(DrawingElement c)
        {
            Console.WriteLine(
              "Cannot remove from a PrimitiveElement");
        }

        public override string Remove(DrawingElement d, bool test)
        {
            return "Cannot remove from a PrimitiveElement";
        }

        public override void Display(int indent)
        {
            Console.WriteLine(
              new String('-', indent) + " " + _name);
        }

        public override Tuple<string, List<DrawingElement>> Display(int indent, bool test)
        {
            return new Tuple<string, List<DrawingElement>>(_name, null);
        }
    }

    /// <summary>
    /// The 'Composite' class
    /// </summary>
    class CompositeElement : DrawingElement
    {
        private List<DrawingElement> elements =
          new List<DrawingElement>();

        // Constructor
        public CompositeElement(string name)
          : base(name)
        {
        }

        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }

        public override string Add(DrawingElement d, bool test)
        {
            Add(d);
            return "";
        }

        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }

        public override string Remove(DrawingElement d, bool test)
        {
            Remove(d);
            return "";
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) +
              "+ " + _name);

            // Display each child element on this node
            foreach (var d in elements)
            {
                d.Display(indent + 2);
            }
        }

        public override Tuple<string, List<DrawingElement>> Display(int indent, bool test)
        {
           return new Tuple<string, List<DrawingElement>>(_name,elements);
        }
    }
    #endregion
}
