﻿using System.Collections;

namespace BackToBasics.Topics.Searching
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
        public int Data { get; set; }
    }

    public class DepthFirstSearch
    {
        private Stack _searchStack;
        private BinaryTreeNode _root;
        public DepthFirstSearch(BinaryTreeNode rootNode)
        {
            _root = rootNode;
            _searchStack = new Stack();
        }
        public bool Search(int data)
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
