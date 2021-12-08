using System;

namespace OOP
{
    public class Person
    {
        public int Age
        {
            get
            {
                return Age;
            }
            set
            {
                Age = ValidateAge(value);
            }
        }
        //public string FirstName { get; set; }
        private string FirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = ValidateFirstName(value);
            }
        }
        private string LastName
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = ValidateLastName(value); 
            }
        }

        private int Heigth { get; set; }
        private int Weight { get; set; }

        //Add constructor to class with required fields
        public Person(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public int ValidateAge(int Age)
        {
            if (Age > 0)
            {
                return Age;
            }
            else
            {
                throw new System.ArgumentException("The age is high enough");
            }
        }

        public string ValidateFirstName(string FirstName)
        {
            if (FirstName.Length <= 2 && FirstName.Length >= 10) ;
            {
                return FirstName;
            }
            else
            {
                throw new System.ArgumentException("You have entered to few or to many letters in your firstname");
            }
        }


        private string ValidateLastName(string value)
        {
            throw new NotImplementedException();
        }
    }
}
