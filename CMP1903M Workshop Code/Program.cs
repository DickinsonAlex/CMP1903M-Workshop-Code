using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        private int GCD(int a, int b)
        {
            if (a == 0)
                return b;
            return GCD(b % a, a);
        }

        private int SumOfFirstTenNaturalNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            return sum;
        }
        
        static void Main(string[] args)
        {
            //Problem 1
            //(-4, -5) and (-1, -1) describe two points. What is the distance between them?
            int x1 = -4;
            int y1 = -4;

            int x2 = -1;
            int y2 = -1;

            double answer1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            //Problem 2
            //What is the denominator of the slope between these points?

            double answer2 = y2 - y1 / x2 - x1;

            //Problem 3
            //What is the greatest common divisor (GCD) of 1124 and 136?

            var mc = new Program();      
            int answer3 = mc.GCD(1124, 136);

            //Problem 4
            //What is the remainder, when you divide the square of the sum of the first ten natural numbers by ten?
            
            int answer4 = mc.SumOfFirstTenNaturalNumbers() % 10;

            //Write answers
            Console.WriteLine("The distance between the two points is " + answer1);
            Console.WriteLine("The denominator of the slope between the two points is " + answer2);
            Console.WriteLine("The greatest common divisor of 1124 and 136 is " + answer3);
            Console.WriteLine("The remainder of the square of the sum of the first ten natural numbers divided by ten is " + answer4);
        }
    }
}
