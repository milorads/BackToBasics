using System.Collections;
using BackToBasics.Helpers;

namespace BackToBasics.Topics.Searching
{
    public class DepthFirstSearch
    {
        private Stack _searchStack;
        private BinaryTreeNode _root;
        public DepthFirstSearch(BinaryTreeNode rootNode)
        {
            _root = rootNode;
            _searchStack = new Stack();
        }
        public bool DoSearch(int data)
        {
            BinaryTreeNode _current;
            _searchStack.Push(_root);
            while (_searchStack.Count != 0)
            {
                _current = _searchStack.Pop() as BinaryTreeNode;
                if (_current?.Data == data)
                {
                    return true;
                }
                else
                {
                    _searchStack.Push(_current?.Right);
                    _searchStack.Push(_current?.Left);
                }
            }
            return false;
        }
    }
}
