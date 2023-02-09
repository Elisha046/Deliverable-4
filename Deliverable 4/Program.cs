﻿/*
Author: Elisha Doan
Date 2/8/23
Comments: This C# Console application code demonstrates the use of arrays after getting input from users

*/

using System;


namespace Deliverable_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 5 and 20: ");

            int input = int.Parse(Console.ReadLine());

            if ( input >=5 && input <= 20)
            {
                int[] even = new int[input];
                int[] odd = new int[input];
                int[] fibonacci = new int[input];

                // Initialize fibonacci series
                fibonacci[0] = 0;
                fibonacci[1] = 1;

                for (int i = 0; i < input; i++)
                {
                    even[i] = 2*i;
                    odd[i] = 2*i+1;

                    if (i >= 2)
                    {
                        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                    }
                   
               
                }

                foreach (int number in even)
                {
                    Console.WriteLine(number);
                }


                Console.WriteLine("");
                Console.WriteLine("Fibonacci");
                foreach (int number in even)
                {
                    Console.WriteLine(number);
                }
            }    
        }
    }
}