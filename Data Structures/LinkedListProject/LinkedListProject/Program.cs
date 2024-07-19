using System.Collections;

namespace LinkedListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===LinkedList implementation===");
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.PrintList();
            list.Remove(10);
            Console.WriteLine("After removing element :");
            list.PrintList();
            Console.WriteLine("\ndoes the list include 20? " + list.Includes(20)+"\n");

            //========================================================================================================
            Console.WriteLine("===Remove Duplicate===");
            LinkedList list2 = new LinkedList();
            list2.Add(5);
            list2.Add(20);
            list2.Add(20);
            list2.Add(10);
            list2.Add(5);
            list2.Add(10);
            Console.WriteLine("Original List:");
            list2.PrintList();
            Console.WriteLine("\nAfter Removing Duplicates:");
            list2.RemoveDuplicate();
            list2.PrintList();
            //=========================================================================================================

            
            


        }
    }
}
