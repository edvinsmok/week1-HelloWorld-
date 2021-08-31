using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wtats ur name?");

            //readline() to read the user input from the console
            string username = Console.ReadLine();
            Console.WriteLine("hello," + username);

            Console.Read();
        }
    }
}