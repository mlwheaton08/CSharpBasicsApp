using System;

namespace CSharpBasicsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Name: Mason Wheaton
             * Favorite day of the week: Saturday
             * Least favorite school subject: Reading
             */

            UserInput taco = new UserInput();

            
            while (String.IsNullOrWhiteSpace(taco.Name))
            {
                Console.Clear();
                Console.Write("Enter your name: ");
                taco.Name = Console.ReadLine();
            }

            
            while (String.IsNullOrWhiteSpace(taco.FavoriteDayOfWeek))
            {
                Console.Clear();
                Console.Write("What is your favorite day of the week? ");
                taco.FavoriteDayOfWeek = Console.ReadLine();
            }

            
            while (String.IsNullOrWhiteSpace(taco.LeastFavoriteSubject))
            {
                Console.Clear();
                Console.Write("What is your least favorite school subject? ");
                taco.LeastFavoriteSubject = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine(taco);

            Console.ReadLine();









            //string input = ""; 

            //while (input == "")
            //{
            //    //Console.WriteLine("You need to enter a real name.");
            //    Console.WriteLine("Enter your name: ");
            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"Hello, {input}");
        }
    }
}
