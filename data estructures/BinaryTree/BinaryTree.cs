using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_estructures.BinaryTree
{
    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> root;

        public BinaryTree()
        {
            root = null;
        }

        public virtual void Clear()
        {
            root = null;
        }

        public BinaryTreeNode<T> Root
        {
            get
            {
                return root;
            }
            set
            {
                root = value;
            }
        }

        public void PreorderTraversal()
        {
            root.PreorderTraversal(root);
            
        }

        public void InorderTraversal()
        {
            root.InorderTraversal(root);
        }

        public void PostorderTraversal()
        {
            root.PostorderTraversal(root);
        }
    }
}
