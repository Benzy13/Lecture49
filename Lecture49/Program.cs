using System;
using System.Linq;

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

            Console.WriteLine("Enter a number to see it's factorial:");
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
            int randomNumber = random.Next(1,10);
            Console.WriteLine(randomNumber);
            int numChances = 4;
            int guess = 0;
            
            Console.WriteLine("You have {0} chances to guess the secret number", numChances);

            int k = 1;
            while (k<=numChances)
            {
                Console.WriteLine("Guess number {0}:", k);
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out guess);
                if (guess == randomNumber)
                {
                    Console.WriteLine("You have won!");
                    break;
                }
                else if (k == numChances)
                {
                    Console.WriteLine("You have lost");
                    break;
                }

                else
                    Console.WriteLine("Try again.");
                k++;
            }

            //Question 5

            int inputLength = 5;
            Console.WriteLine("Enter {0} numbers between 1 and 10 seperated by comma", inputLength);
            string numberInput = Console.ReadLine();
            char[] userArray = numberInput.ToCharArray();
            char[] resultArray = new char[inputLength*2 -1];
            int j = 0;

            foreach (var value in userArray)
            {
                if (value != ',')
                    resultArray[j] = value;
                j++;
            }
            Console.WriteLine("The maximum of the values {0} values you have entered is: {1}", inputLength, resultArray.Max());
        }
    }
}
