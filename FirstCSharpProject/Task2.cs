using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCSharpProject
{
    internal class Task2
    {
        public void CalculateSum()
        {
            Console.WriteLine(" Sum of numbers 1 to N ");
            Console.Write("Enter a positive whole number N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of numbers from 1 to {0} is {1}", n, sum);
        }
    }
}
