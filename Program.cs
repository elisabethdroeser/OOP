using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test if the argumentexception works with different names with few/more letters
            //Person person = new Person("Lisa", "Droeser");

            PersonHandler personHandler = new PersonHandler();
            var Lisa = personHandler.CreatePerson(14, "A", "Bengtsson-Larsson", 166, 58);
            //var Erik = personHandler.CreatePerson(14, "Erik", "Uppenberg", 178, 88);

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
