using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCSharpProject
{
    internal class Task_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Password Retry ");
            string correctPassword = "Spark2026";
            Console.Write("Enter the password: ");
            String userGuess = Console.ReadLine();
            while (userGuess != correctPassword)
            {
                Console.WriteLine("Incorrect password. Please try again.");
                Console.Write("Enter the password: ");
                userGuess = Console.ReadLine();
            }
            Console.WriteLine("Password correct. Access granted.");
        }
    }
}