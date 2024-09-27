using System.Xml.Linq;
using TreeImplementation.LargestLevelValue;
using TreeImplementation.LeafSum;
using TreeImplementation.MirrorTree;
using TreeImplementation.RightViewPrint;
using TreeImplementation.SecondMaxValue;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Btree = new BinaryTree(2);
            Btree.Root.Left = new TNode(3);
            Btree.Root.Right = new TNode(5);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Right.Right = new TNode(6);
            Btree.Root.Left.Left.Right = new TNode(7);

           

          // Btree.print(Btree.Root);
            PrintRightViewClass PRVC = new PrintRightViewClass();
          List<int> lsit= PRVC.PrintRightView(Btree.Root);
            foreach (int i in lsit) 
            {
                Console.WriteLine(i);
            }
        }
    }
}