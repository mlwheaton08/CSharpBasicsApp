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

            string name = "";
            while (String.IsNullOrWhiteSpace(name))
            {
                Console.Clear();
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            string favDay = "";
            while (String.IsNullOrWhiteSpace(favDay))
            {
                Console.Clear();
                Console.Write("What is your favorite day of the week? ");
                favDay = Console.ReadLine();
            }

            string badSubject = "";
            while (String.IsNullOrWhiteSpace(badSubject))
            {
                Console.Clear();
                Console.Write("What is your least favorite school subject? ");
                badSubject = Console.ReadLine();
            }

            Console.Clear();
            string displayText = @$"Name: {name}
Favorite day of the week: {favDay}
Least favorite school subject: {badSubject}";
            Console.WriteLine(displayText);

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
