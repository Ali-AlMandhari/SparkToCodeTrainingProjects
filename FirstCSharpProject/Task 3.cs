using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCSharpProject
{
    internal class Task_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Multiplication Table ");
            Console.Write(" Enter a number to see its multiplication table");
            int tableNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int result = tableNumber * i;
                Console.WriteLine(tableNumber + " x " + i + " = " + result);
            }
        }
    }
}