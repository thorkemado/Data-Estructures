using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_estructures.Common;

namespace data_estructures.BinaryTree
{
    public class BinaryTreeNode<T> : Node<T>
    {
        public BinaryTreeNode() : base() { }
        public BinaryTreeNode(T data) : base(data, null) { }
        public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            base.Value = data;
            NodeList<T> children = new NodeList<T>(2);
            children[0] = left;
            children[1] = right;

            base.Neighbors = children;
        }

        public BinaryTreeNode<T> Left
        {
            get
            {
                if (base.Neighbors == null)
                    return null;
                else
                    return (BinaryTreeNode<T>)base.Neighbors[0];
            }
            set
            {
                if (base.Neighbors == null)
                    base.Neighbors = new NodeList<T>(2);

                base.Neighbors[0] = value;
            }
        }

        public BinaryTreeNode<T> Right
        {
            get
            {
                if (base.Neighbors == null)
                    return null;
                else
                    return (BinaryTreeNode<T>)base.Neighbors[1];
            }
            set
            {
                if (base.Neighbors == null)
                    base.Neighbors = new NodeList<T>(2);

                base.Neighbors[1] = value;
            }
        }

       public void PreorderTraversal(BinaryTreeNode<T> current)
        {
            if (current != null)
            {
                // Output the value of the current node
                Console.Write(current.Value);

                // Recursively print the left and right children
                PreorderTraversal(current.Left);
                PreorderTraversal(current.Right);
            }
        }
        public void InorderTraversal(BinaryTreeNode<T> current)
        {
            if (current != null)
            {
                // Visit the left child...
                InorderTraversal(current.Left);

                // Output the value of the current node
                Console.Write(current.Value);

                // Visit the right child...
                InorderTraversal(current.Right);
            }
        }

        public void PostorderTraversal(BinaryTreeNode<T> current)
        {
            if (current != null)
            {
                // Visit the left child...
                PostorderTraversal(current.Left);

                // Visit the right child...
                PostorderTraversal(current.Right);

                // Output the value of the current node
                Console.Write(current.Value);
            }
        }
    }
}
