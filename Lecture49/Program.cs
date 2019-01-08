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
            //string input = Console.ReadLine();
            number = Convert.ToInt32(Console.ReadLine());
            //int.TryParse(input, out number);
            int factorial = 1;
            int[] countArray = new int[number];

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
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

            var randomNumber = new Random().Next(1, 10);
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

            Console.Write("Enter comma separated numbers: ");
            var input2 = Console.ReadLine();

            var numbers = input2.Split(',');
            Console.WriteLine(numbers.Max());

            //int inputLength = 5;
            //Console.WriteLine("Enter {0} numbers between 1 and 10 seperated by comma", inputLength);
            //string numberInput = Console.ReadLine();
            //char[] userArray = numberInput.ToCharArray();
            //char[] resultArray = new char[inputLength*2 -1];
            //int j = 0;

            //foreach (var value in userArray)
            //{
            //    if (value != ',')
            //        resultArray[j] = value;
            //    j++;
            //}
            //Console.WriteLine("The maximum of the values {0} values you have entered is: {1}", inputLength, resultArray.Max());
        }
        /// <summary>
        /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        /// Display the result on the console.
        /// </summary>
        public void Exercise1()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
        }

        /// <summary>
        /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
        /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
        /// </summary>
        public void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
        }

        /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /// </summary>
        public void Exercise3()
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        /// <summary>
        /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
        /// If the user guesses the number, display “You won". Otherwise, display “You lost".
        /// </summary>
        public void Exercise4()
        {
            var number = new Random().Next(1, 10);

            Console.WriteLine("Secret is " + number);
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }

            Console.WriteLine("You lost!");
        }

        /// <summary>
        /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
        /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
        /// display 8 on the console.
        /// </summary>
        public void Exercise5()
        {
            Console.Write("Enter comma separated numbers: ");
            var input2 = Console.ReadLine();

            var numbers = input2.Split(',');
            Console.WriteLine(numbers.Max());

            //// Assume the first number is the max 
            //var max = Convert.ToInt32(numbers[0]);

            //foreach (var str in numbers)
            //{
            //    var number = Convert.ToInt32(str);
            //    if (number > max)
            //        max = number;
            //}

            //Console.WriteLine("Max is " + max);

        }
    }
}
