using System.Xml.Linq;
using TreeImplementation.MirrorTree;
using TreeImplementation.SecondMaxValue;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Btree = new BinaryTree(10);
            Btree.insert(5);
            Btree.insert(20);
            Btree.insert(3);
            Btree.insert(7);
            Btree.insert(15);
            Btree.insert(25);

            SecondMaxValueClass secondMaxFinder = new SecondMaxValueClass();
            
                int secondMax = secondMaxFinder.FindSecondMax(Btree.Root);
                Console.WriteLine("Second Maximum Value: " + secondMax);
            
        }
    }
}