namespace HW_l4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int i = 1;
            while (i <= number)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("Sum of all numbers from 1 to {0} equals {1}");
            Console.WriteLine();
        }
    }
}
