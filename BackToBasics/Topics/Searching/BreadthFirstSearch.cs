using System.Collections;
using BackToBasics.Helpers;

namespace BackToBasics.Topics.Searching
{
    public class BreadthFirstSearch
    {
        private Queue _searchQueue;
        private BinaryTreeNode _root;
        public BreadthFirstSearch(BinaryTreeNode rootNode)
        {
            _searchQueue = new Queue();
            _root = rootNode;
        }
        public bool DoSearch(int data)
        {
            BinaryTreeNode _current;
            _searchQueue.Enqueue(_root);
            while (_searchQueue.Count != 0)
            {
                _current = _searchQueue.Dequeue() as BinaryTreeNode;
                if (_current?.Data == data)
                {
                    return true;
                }
                else
                {
                    _searchQueue.Enqueue(_current?.Left);
                    _searchQueue.Enqueue(_current?.Right);
                }
            }
            return false;
        }
    }
}
