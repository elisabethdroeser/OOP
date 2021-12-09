using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test if the argumentexception works with different names with few/more letters
            Person person = new Person("Lisa", "Droeser");

            //ArgumentException in Person.cs to validate letters in firstname, lastname (and age).
            try
            {

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message); 
            }

            Console.ReadLine();
        }
    }
}
