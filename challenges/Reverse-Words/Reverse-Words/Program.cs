namespace Reverse_Words
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "jafar mohammad ramadan";
            Console.WriteLine(ReverseWords(str)); 
        }

        public static string  ReverseWords(string word)
        {
            string[] result = word.Split(" ");
            string[] arr = new string[result.Length];
            int count = 0;  
            for (int i = result.Length-1; i >=0; i--) { 

                arr[count++] = result[i];
               
            }
                        
            string reversed= string.Join(" ",arr);
            return reversed;

        }
    }
}
