namespace LinkedListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);

           
            list.PrintList(); 

            
            list.Remove(10);
            list.PrintList();

            Console.WriteLine("\ndoes the list include 20? "+list.Includes(20));
        }
    }
}
