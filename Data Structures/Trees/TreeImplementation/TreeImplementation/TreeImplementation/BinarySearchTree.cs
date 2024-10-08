﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation.TreeImplementation
{
    public class BinarySearchTree : BinaryTree
    {
        public TNode Root { get; set; }
        public BinarySearchTree(int rootValue) : base(rootValue)
        {
            Root = new TNode(rootValue);
        }

        public void Add(int value)
        {
            AddRecursion(value, Root);
        }

        private void AddRecursion(int value, TNode node)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new TNode(value);
                }
                else { AddRecursion(value, node.Left); }

            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new TNode(value);
                }
                else { AddRecursion(value, node.Right); }
            }

        }

        public bool Contains(int value, TNode node)
        {
            if (node == null) return false;
            if (value == node.Value) return true;

            else if (value < node.Value)
            {
                return Contains(value, node.Left);
            }
            else if (value > node.Value)
            {
                return Contains(value, node.Right);
            }
            else return false;
        }

        public TNode deleteRecursively(TNode root, int value)
        {

            if (root == null)
                return root;

            if (value < root.Value)
            {
                root.Left = deleteRecursively(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = deleteRecursively(root.Right, value);
            }
            else
            {

                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                    return root.Left;

                root.Value = inOrderSuccessor(root.Right);
                root.Right = deleteRecursively(root.Right, root.Value);
            }

            return root;

        }

        public int inOrderSuccessor(TNode root)
        {
            int minimum = root.Value;
            while (root.Left != null)
            {
                minimum = root.Left.Value;
                root = root.Left;
            }
            return minimum;
        }

    }
}
