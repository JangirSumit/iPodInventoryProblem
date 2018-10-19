using System;

namespace iPodInventoryProblem
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(new CalculateOptimisedPrice().GetOptimisedPrice(Console.ReadLine()));

            Console.ReadLine();
        }
    }
}
