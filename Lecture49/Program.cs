using System;

namespace Lecture49
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1

            int count = 0;
            int length = 100;
            for (int i = 1; i < length; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine(count);

            //Question 2

            int number = 0;
            int numberSum = 0;
            while (true)
            {
                Console.WriteLine("Enter a few numbers then type ok to finish:");
                string input1 = Console.ReadLine();
                int.TryParse(input1, out number);
                numberSum = numberSum + number;

                if (input1 == "ok")
                {
                    Console.WriteLine("The sum of the numbers that you have entered is: " + numberSum);
                    break;
                }
            }

            //Quesion 3

            Console.WriteLine("Enter a few numbers then type ok to finish:");
            string input = Console.ReadLine();
            int.TryParse(input, out number);
            int factorial = 1;
            int[] countArray = new int[number];

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
                countArray[i - 1] = i;
            }
            Console.WriteLine("The factorial of the number you have entered is: {0}!={1}", number, factorial);
            Console.Write("This can also be written as: ");

            foreach (int counter in countArray)
            {
                Console.Write(counter);
                if (counter < number)
                    Console.Write("x");
            }
            Console.WriteLine();

            //Question 4

            var random = new Random();


        }
    }
}
