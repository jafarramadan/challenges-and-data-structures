namespace Common_Elements
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1= { 4, 5, 7 };
            int[] arr2= { 7,2,5 };

            int [] result= common(arr1 , arr2);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        public static int [] common(int[] arr1, int [] arr2)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        result.Add(arr1[i]);
                    }
                }
            }  

            return result.ToArray();
        }
    }
}
