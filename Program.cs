﻿using System;

namespace EFS
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = System.Environment.MachineName;
            // Console.WriteLine("Hello World! " + name);

            /* 
                Using var for variable declaration in place of 
                primitive data types
            */

            // will save variable as integer ( alternatively use "int")
            var number = 3; 
            // will save variable as integer ( alternatively use "byte" if that's the intention)
            var count = 27;
            // will save variable as float (with the "f" prefix it becomes a "double")
            var totalPrice = 34.9f;
            // will save variable as a char (double quotes turns it to "string")
            var character = 's';

            var firstName = "Anthony";
            var debug = false;

            // Console.WriteLine(number);
            // Console.WriteLine(count);
            // Console.WriteLine(totalPrice);
            // Console.WriteLine(character);
            // Console.WriteLine(firstName);
            // Console.WriteLine(debug);

            // String formatting while checking limits of some data types
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}