using System.Xml.Linq;
using TreeImplementation.BTreeToBST;
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
            int[] arr = { 5, 10, 20, 35, 40, 50, 60 };

            BTreeToBSTClass bTreeToBSTClass = new BTreeToBSTClass();
            

            BinaryTree binaryTree = new BinaryTree(1);

            binaryTree.print(bTreeToBSTClass.ArrayToBst(arr));

        }
    }
}


