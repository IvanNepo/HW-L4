namespace HW_l4_5
{
    internal class Program
    {
        static void Main()
        {
            int[] array1 = { 1, 2, 3, 4, 5, };
            int[] array2 = { 6, 7, 8, 9, 10 };
            Console.WriteLine("First massive: ");
            foreach (int num in array1)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Second massive: ");
            foreach (int num in array2)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine();

            int sumArray1 = 0;
            int sumArray2 = 0;
            int count1 = 0, count2 = 0;
            foreach (int num in array1)
            {
                sumArray1 += num;
                count1++;
            }
            foreach (int num in array2)
            {
                sumArray2 += num;
                count2++;
            }
            Console.WriteLine();
        }
    }
}

