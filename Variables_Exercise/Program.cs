using System;
using System.Collections.Generic;
using System.Text;

namespace Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringVal = "Hello";
            int intVal = 9;
            char charVal = 'R';
            bool boolVal = true;
            double doubleVal = 9.81;
            decimal decimalVal = 13;

            Console.WriteLine($" {stringVal}, my name is Ruben, {charVal} is the initial of my name. \n");
            Console.WriteLine($" {intVal} is my favorite number, it is contained in the value of gravity = {doubleVal}. \n");
            Console.WriteLine($" It is also {boolVal} that {decimalVal} is my second favorite number.");


        }
    }
}
