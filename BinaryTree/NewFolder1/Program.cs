﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinaria.MS
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> btree = new BinaryTree<int>();
            btree.Root = new BinaryTreeNode<int>(1);
            btree.Root.Left = new BinaryTreeNode<int>(2);
            btree.Root.Right = new BinaryTreeNode<int>(3);

            btree.Root.Left.Left = new BinaryTreeNode<int>(4);
            btree.Root.Right.Right = new BinaryTreeNode<int>(5);

            btree.Root.Left.Left.Right = new BinaryTreeNode<int>(6);
            btree.Root.Right.Right.Right = new BinaryTreeNode<int>(7);

            btree.Root.Right.Right.Right.Right = new BinaryTreeNode<int>(8);

            Console.ReadKey();
        }
    }
}
