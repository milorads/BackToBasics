using BackToBasics.Helpers;
using System;

namespace BackToBasics.Topics.Data_Structures
{

    public class Queue
    {
        private QueueNode _head;
        private QueueNode _tail;
        private int _count = 0;
        public Queue() { }
        public void Enqueue(int data)
        {
            QueueNode _newNode = new QueueNode(data);
            if (_head == null)
            {
                _head = _newNode;
                _tail = _head;
            }
            else
            {
                _tail.Next = _newNode;
                _tail = _tail.Next;
            }
            _count++;
        }
        public int Dequeue()
        {
            if (_head == null)
            {
                throw new Exception("Queue is Empty");
            }
            int _result = _head.Data;
            _head = _head.Next;
            _count--;
            return _result;
        }
        public int Count => this._count;

        public void QueueOperations()
        {
            Enqueue(3);
            Enqueue(5);
            var count = Count;
            Dequeue();
            count = Count;
            Dequeue();
            try
            {
                Dequeue();
            }
            catch (Exception e)
            {
                var msg = e.Message;
            }
        }
    }
}
