using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace Binary_trees
{
    public class BinaryTree<T>
    {
        public BinaryTree<T>? Root { get; set; } = null!;
        public int Count { get; set; }
        public enum TraversalEnum
        {
            PREORDER, INORDER, POSTORDER
        }

        private void TraversePreOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                result.Add(node);
                TraversePreOrder(node.Left, result);
                TraversePreOrder(node.Right, result);
            }
        }

        private void TraverseInOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, result);
                result.Add(node);
                TraverseInOrder(node.Right, result);
            }
        }

        private void TraversePostOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraversePostOrder(node.Left, result);
                TraversePostOrder(node.Right, result);
                result.Add(node);
            }
        }

        public List<BinaryTreeNode<T> Traverse(TraversalEnum mode)
        {
            List<BinaryTreeNode<T>> nodes = new List<BinaryTreeNode<T>>();

            switch (mode)
            {
                case TraversalEnum.PREORDER:
                    TraversePreOrder(Root, nodes);
                    break;
                case TraversalEnum.INORDER:
                    TraversePreOrder(Root, nodes);
                    break;
                case TraversalEnum.POSTORDER:
                    TraversePreOrder(Root, nodes);
                    break;
            }
        }
    }
}