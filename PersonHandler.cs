using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class PersonHandler
    {

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(int Age, string FirstName, string LastName, double Height, double Weight)
    {
            Person person = new Person(FirstName, LastName); 
            return person;
        }
    }
}
