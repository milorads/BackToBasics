using BackToBasics.Helpers;

namespace BackToBasics.Topics.Data_Structures
{
    class BinarySearchTree
    {
        public BinaryTreeNode Insert(BinaryTreeNode root, int v)
        {
            if (root == null)
            {
                root = new BinaryTreeNode {Data = v};
            }
            else if (v < root.Data)
            {
                root.Left = Insert(root.Left, v);
            }
            else
            {
                root.Right = Insert(root.Right, v);
            }

            return root;
        }

        public void traverse(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }

            traverse(root.Left);
            traverse(root.Right);
        }
    }
}
