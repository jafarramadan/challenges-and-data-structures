namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BinarySearchTree b = new BinarySearchTree(10);
            b.Add(5);
            b.Add(15);
            b.Add(3);
            b.Add(7);
            b.Add(12);
            b.Add(18);



            Console.WriteLine(b.Contains(15, b.Root));

        }
    }
}
