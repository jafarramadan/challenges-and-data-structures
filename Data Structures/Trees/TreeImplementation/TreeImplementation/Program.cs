using System.Xml.Linq;
using TreeImplementation.MirrorTree;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Btree = new BinaryTree(4);
            Btree.Root.Left = new TNode(8);
            Btree.Root.Right = new TNode(7);
            Btree.Root.Left.Left = new TNode(12);
            Btree.Root.Left.Right = new TNode(9);

            MirrorTreeClass mirrorTreeClass = new MirrorTreeClass();

            Console.WriteLine("Before");
            List<int> l2 = mirrorTreeClass.InorderTraversal(Btree.Root);
            foreach (int i in l2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("After");
            List<int> l1 = mirrorTreeClass.Merror(l2);
            foreach (int i in l1)
            {
                Console.WriteLine(i);
            }
        }
    }
}