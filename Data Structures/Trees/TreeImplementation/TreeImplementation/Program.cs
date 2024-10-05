using System.Xml.Linq;
using TreeImplementation.LargestLevelValue;
using TreeImplementation.LeafSum;
using TreeImplementation.MaxLEvelNodes;
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
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);
            Btree.Root.Right.Right = new TNode(6);
            Btree.Root.Left.Left.Left = new TNode(7);

            MaxLevelNodesClass x = new MaxLevelNodesClass();
            int maxLevel = x.FindMaxLevelNodes(Btree.Root);
            Console.WriteLine("Level with maximum nodes: " + maxLevel); 

        }
    }
}


