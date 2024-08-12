using TreeImplementation.TreeImplementation;

namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            BinaryTree b=new BinaryTree(10);
            b.insert(5);
            b.insert(15);
            b.insert(3);
            b.insert(7);
            b.insert(12);
            b.insert(18);

            b.print(b.Root);
        }
    }
}
