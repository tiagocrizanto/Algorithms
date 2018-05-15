using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinaria
{

    //This algorithm represents de following binary tree
    //          1
    //         / \
    //        2   3
    //       / \
    //      4   5
    class Program
    {
        static void Main(string[] args)
        {
            /* instace of a tree */
            var tree = new BinaryTree();

            //Root node
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            //Count total itens
            Console.WriteLine("The size of binary tree is : "
                                + tree.size());

            Console.ReadKey();
        }
    }
}
