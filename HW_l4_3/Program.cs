namespace HW_l4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1;i <= number ; i++) 
            {
            sum += i;
            }
            Console.WriteLine("Sum of all numbers from 1 to {0} equals {1}");
        }
    }
}
