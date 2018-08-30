using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Loops
{
    public class Loops
    {
        public static void DivisibleBy3()
        {
            var numDivisibleBy3 = 0;
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3) == 0)
                    numDivisibleBy3++;
            }

            Console.WriteLine("There are {0} numbers divisble by 3 between 1 and 100.", numDivisibleBy3);
        }

        public static void Sum()
        {
            try { 
            var sum = 0;
                while (true)
                {
                    Console.WriteLine("Please enter a number or 'ok' to exit.");
                    var input = Console.ReadLine();
                    if (input == "ok")
                    {
                        Console.WriteLine("The total for all values enters is {0}", sum);
                        break;
                    }
                    else
                    {
                        sum += Convert.ToInt32(input);
                    }
                }
               
            }
            catch
            {
                Console.WriteLine("Invalid Entry.");
            }
        }

        public static void Factorials()
        {
            try
            {
                Console.WriteLine("Please enter a number to calculate the factorial.");
                var input = Console.ReadLine();
                var factorial = Convert.ToInt64(input);

                for (long i = factorial - 1; i > 0; i--)
                {
                    factorial *= i;
                }
                //NOTE*** This method does not prevent overflow; possibly BigInteger can be used:  https://stackoverflow.com/questions/24874495/largest-data-type-to-store-numbers
                //only calculates up to 25! w/o overflow
                Console.WriteLine("{0}! = {1}", input, factorial);
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a valid entry.");
            }

        }

        public static void GuessNumber()
        {
            Random rnd = new Random();
            var randomNumber = rnd.Next(1,10);
            Console.WriteLine("Please guess the number between 1 through 10.");
            
            for (int i = 4; i > 0; i--)
            {
                var guess = Convert.ToInt32(Console.ReadLine());
                while (guess < 1 && guess > 10)
                {
                    Console.WriteLine("Please input a guess between 1 and 10");
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                if (guess == randomNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else
                {
                    //the loop incrementation is placed here to accurately show the user the amount of guesses left
                    Console.WriteLine("Please guess again. Guesses left: {0}", i - 1);
                    if (i - 1 == 0)
                    {
                        Console.WriteLine("All guesses used. The correct number is: {0}", randomNumber);
                    }
                }


            }
        }

        public static void FindMax()
        {
            Console.WriteLine("Please enter a series of numbers seperated by commas. (E.g. '5, 3, 8, 6'");
            var stringEntry = Console.ReadLine();

            //parse method
            int[] nums = Array.ConvertAll(stringEntry.Split(','), int.Parse);

            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                //Console.WriteLine(num);
                if (nums[i] >= max)
                    max = nums[i];
                //Console.WriteLine(max);
            }

            Console.WriteLine("The maximum of these numbers is {0}", max);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Loops.DivisibleBy3();
            Loops.Sum();
            Loops.Factorials();
            Loops.GuessNumber();
            Loops.FindMax();
        }
    }
}
