namespace Quete1LesConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxormin = 0;
            Console.WriteLine("Please enter a minimum value :");
            int limit1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a maximum value :");
            int limit2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number :");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < limit1)
                maxormin = 1;
            else if (num > limit2)
                maxormin = 2;

            if (maxormin == 1)
            {
                Console.WriteLine("You have entered the integer " + num + " which is lower than " + limit1 + " which is the minimum");
                Console.WriteLine("Resulting integer is " + limit1);
            }
            else if (maxormin == 2)
            {
                Console.WriteLine("You have entered the integer " + num + " which is greater than " + limit2 + " which is the maximum");
                Console.WriteLine("Resulting integer is " + limit2);
            }
        }
    }
}
