using System.Collections;

namespace LinkedListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(20);
            list.Add(20);
            list.Add(10);
            list.Add(5);
            list.Add(10);

            Console.WriteLine("Original List:");
            list.PrintList();

            Console.WriteLine("\nAfter Removing Duplicates:");
            list.RemoveDuplicate();
            list.PrintList();

            
            


        }
    }
}
