﻿using System.Xml.Linq;
using TreeImplementation.LargestLevelValue;
using TreeImplementation.LeafSum;
using TreeImplementation.MirrorTree;
using TreeImplementation.SecondMaxValue;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Btree = new BinaryTree(5);
            Btree.Root.Left = new TNode(13);
            Btree.Root.Right = new TNode(7);
            Btree.Root.Left.Left = new TNode(3);
            Btree.Root.Left.Right = new TNode(7);
            Btree.Root.Right.Left = new TNode(12);
            Btree.Root.Right.Right = new TNode(20);
            Btree.Root.Left.Left.Left = new TNode(1);
            Btree.Root.Left.Left.Right = new TNode(4);
            Btree.Root.Right.Left.Right = new TNode(11);
            LargestLevelValueClass largestLevelValue =new LargestLevelValueClass();
            List<int> largestValues = largestLevelValue.LargestLevelValue(Btree);

            Console.WriteLine(string.Join(", ", largestValues));

            Btree.print(Btree.Root);
        }
    }
}