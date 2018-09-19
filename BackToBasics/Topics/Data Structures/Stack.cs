using System.Collections.Generic;
using System.Linq;

namespace BackToBasics.Topics.Data_Structures
{
    public class Stack
    {
        static readonly int MAX = 1000;
        int top;
        int[] _stack = new int[MAX];

        public bool IsEmpty()
        {
            return (top < 0);
        }
        public Stack()
        {
            top = -1;
        }
        public bool Push(int data)
        {
            if (top >= MAX)
            {
                return false;
            }

            _stack[++top] = data;
            return true;
        }

        public int Pop()
        {
            if (top < 0)
            {
                return 0;
            }
            var value = _stack[top];
            _stack[top--] = 0;
            return value;
        }

        public int Peek()
        {
            if (top < 0)
            {
                return -1;
            }

            return _stack[top];
        }

        public int[] ReturnStack()
        {
            var stack = new List<int>();
            if (top < 0)
            {
                return null;
            }

            for (int i = top; i >= 0; i--)
            {
                stack.Add(_stack[i]);
            }

            return stack.ToArray();
        }

        public void StackOperations()
        {
            Push(3);
            Push(5);
            Peek();
            var poppedValue = Pop();
            var wholeStackInArray = ReturnStack();
            Pop();
        }
    }
}
