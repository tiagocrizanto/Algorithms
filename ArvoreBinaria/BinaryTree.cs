using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    public class BinaryTree
    {
        public Node root;

        /* Given a binary tree. Print its nodes in level order
           using array for implementing queue */
        public int size()
        {
            return size(root);
        }

        /* computes number of nodes in tree */
        int size(Node node)
        {
            if (node == null)
                return 0;
            else
                return (size(node.left) + 1 + size(node.right));
        }
    }
}
