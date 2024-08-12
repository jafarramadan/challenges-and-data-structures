using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TreeImplementation.TreeImplementation
{
    public class BinaryTree
    {
        public TNode Root { get; set; }
        public BinaryTree(int rootValue)
        {
            Root = new TNode(rootValue);
        }

        public void insert(int value)
        {
            insertRecursion(value, Root);
        }

        private void insertRecursion(int value, TNode node)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new TNode(value);
                }
                else { insertRecursion(value, node.Left); }

            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new TNode(value);
                }
                else { insertRecursion(value, node.Right); }
            }

        }

        //root-left-right
        public void PreOrder(TNode node)
        {
            if (node == null) return;
            Console.WriteLine(node.Value);
            PreOrder(node.Left);
            PreOrder(node.Right);

        }

        //left-root-right
        public void InOrder(TNode node)
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.WriteLine(node.Value + "-");
            InOrder(node.Right);
        }

        //left-right-root
        public void PostOrder(TNode node)
        {
            if (node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.WriteLine(node.Value + "-");
        }

        public void print(TNode node)
        {
            Console.WriteLine("----------------------------->");
            print2DUtil(node, 0);
        }

        int COUNT = 7;
        private void print2DUtil(TNode root, int space)
        {
            if (root == null)
                return;
            space += COUNT;
            print2DUtil(root.Right, space);
            Console.Write("\n");
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.Write(root.Value + "\n");
            print2DUtil(root.Left, space);
        }


    }
}