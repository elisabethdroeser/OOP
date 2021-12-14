using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing the error functionality
            NumbericInputError numerror = new NumbericInputError();
            TextInputError texterror = new TextInputError();

            //Get list of errors
            List<UserError> errors = new List<UserError>()
            {
                numerror, texterror
            };
           
            //Write the list of errors to the console
            foreach (UserError uer in errors)
            {
                Console.WriteLine($"Error: {uer.UEMessage()}");
            }

            /*
            //Test if the argumentexception works with different names with few/more letters
            //Person person = new Person("Lisa", "Droeser");

            PersonHandler personHandler = new PersonHandler();
            //var Lisa = personHandler.CreatePerson(14, "A", "Bengtsson-Larsson", 166, 58);
            var Erik = personHandler.CreatePerson(14, "Erik", "Uppenberg", 178, 88);

            //List of Animals
            var lily = new Dog("Lily", 2, 5, 45);
            var betsson = new Horse("Betsson", 7, 155, "Black");
            var bosse = new Flamingo("Bosse", 18, 11, 64, 2, "Pink");
            var owl = new Wolf("Owl", 37, 152, "Blue");
            var smilla = new Dog("Smilla", 3, 87, 89);

            List<Animal> animal = new List<Animal>()
            {
                lily,
                betsson,
                bosse,
                owl,
                smilla
            };

            List<Dog> dog = new List<Dog>()
            {
                lily,
                smilla
            };

    
            // lägg in dem i en List<Animal>()
            var a = new List<Animal>();
            foreach (var anim in a)
            {

                if (anim is Dog)
                {
                    var dog = (Dog)anim;
                    dog.DoTrick();
                }

                if (animal is IPerson)
                {
                    var animalManHybrid = (IPerson)animal;
                    animalManHybrid.Talk();
                }

            }
            
            //ArgumentException in Person.cs to validate letters in firstname, lastname (and age).
            try
            {

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message); 
            }
            */
            Console.ReadLine();
        }
    }
}
