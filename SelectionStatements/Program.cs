using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is a tough subject!");
                    break;

                case "science":
                    Console.WriteLine("science is a tough subject!");
                    break;

                case "english":
                    Console.WriteLine("English is a interesting subject");
                    break;
                default:
                    Console.WriteLine($"oh wow! I haven't take this subject before. {subject} sounds fun !");
                    break;



            }

            /*Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess the correct number!");
            Console.WriteLine("What is the upper limit for the range of the number?");

            var userResponse = Console.ReadLine();
            var upperLimit = int.Parse(userResponse);

            var random = new Random();

            var number = random.Next(1, upperLimit);

            int guess;
            

            do
            {
                Console.WriteLine("Input the guess:");
                guess = int.Parse(Console.ReadLine());
                if (guess > number)
                {
                    Console.WriteLine("Your guess is too HIGHT! Try again!");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Your guess is too low! Try again!");
                }
                else
                {
                    Console.WriteLine("Correct!");
                }
            } while (guess != number);*/
            

        }
    }

}
