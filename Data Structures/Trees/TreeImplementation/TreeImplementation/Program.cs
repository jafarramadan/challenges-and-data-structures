using System.Xml.Linq;
using TreeImplementation.LargestLevelValue;
using TreeImplementation.LeafSum;
using TreeImplementation.MaxLEvelNodes;
using TreeImplementation.MinimumDepth;
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
            Btree.Root = new TNode(2);
            Btree.Root.Left = new TNode(3);
            Btree.Root.Right = new TNode(4);
            Btree.Root.Left.Left = new TNode(5);
            MinimumDepthClass minimumDepthClass = new MinimumDepthClass();
            int minDepth = minimumDepthClass.FindMinimumDepth(Btree.Root);
            Console.WriteLine(minDepth);
        }
    }
}


