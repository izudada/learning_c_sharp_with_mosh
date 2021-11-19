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
            // Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            // Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //  Constants (You are not allowed to change value of constants nor do a reassignment)
            const float Pi = 3.14f;

            // Type Conversions
            // - Implicit type conversion
            // - Explicit type conversion (casting)
            // - Conversion between non-compatoble types


            // - Implicit type conversion

            /*
                Implicit - Indirect

                A byte contains 1 byte of memory, but an int takes 4bytes. 
                By copying the byte into an int below, we make an
                implicit converion.

                Note: There is no possibility of data loss in implicit conversion,
                        because there is an increase in the size of the new data type (int)
            */
            byte b = 1;
            int i = b; 


            // - Explicit type conversion (casting)

            /* The below conversion will only be possible using casting "(byte)"
                The compiler knows there will be data loss, so a directive need
                be given to tell it to go ahead with the conversion.
            */

            int firstVar = 1;
            byte secondVar = (byte)firstVar;
            // Console.WriteLine(secondVar);


            //  Non Compatible Types/Conversion

            /*
                Explicit conversion won't work for non compatible 
                conversions. Thus we can use the convert class
                or the Parse method.
            */
            string thirdNumber = "10";
            int castNumber = Convert.ToInt32(thirdNumber);
            // or
            int castNumber2 = int.Parse(thirdNumber); 


            /*
                Using try and catch for overflows
                 in noncompatible conversions
            */

            try
            {
                var n = "1234";
                byte secondNum = Convert.ToByte(n);
                // Console.WriteLine(secondNum);
            }
            catch (System.Exception)
            {
                
                // Console.WriteLine("This convertion did not happen. Probably an overflow happened.");
            }


            /*
                Converting strings to boolean with non compatibility conversion
            */

            try
            {
                 string data = "false";
                 bool data2 = Convert.ToBoolean(data);
                 Console.WriteLine(data2);
            
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("This convertion did not happen.");
            }

        }
    }
}