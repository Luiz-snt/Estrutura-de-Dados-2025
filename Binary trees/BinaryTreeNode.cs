using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Binary_trees
{
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        /* public BinaryTreeNode() => Children = new List<TreeNode<T>>() { null, null }; */

        public BinaryTreeNode()
        {
            Children = new List<TreeNode<T>> ();
            Children.Add(null!);
            Children.Add(null!);
        }
        public BinaryTreeNode<T> Left
        {
            get { return (BinaryTreeNode<T>)Children[0]; }
            set { Children[0] = value; }
        }

        public BinaryTreeNode<T> Right
        {
            get { return (BinaryTreeNode<T>)Children[1]; }
            set { Children[1] = value; }
        }
    }
}