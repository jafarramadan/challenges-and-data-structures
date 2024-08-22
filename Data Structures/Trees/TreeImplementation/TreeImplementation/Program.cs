using System.Xml.Linq;
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
            BinaryTree Btree = new BinaryTree(9);
            Btree.Root.Left = new TNode(8);
            Btree.Root.Right = new TNode(12);
            Btree.Root.Left.Left = new TNode(3);
            Btree.Root.Left.Right = new TNode(7);
            Btree.Root.Right.Left = new TNode(17);
            Btree.Root.Right.Right = new TNode(23);
            Btree.Root.Left.Left.Right = new TNode(4);

            Leaf_SumClass leaf_SumClass = new Leaf_SumClass();
            Console.WriteLine(leaf_SumClass.SumLeaf(Btree.Root));


            Btree.print(Btree.Root);
        }
    }
}