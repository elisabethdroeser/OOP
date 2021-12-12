namespace OOP
{
    public class Person
    {
        //Add constructor to class with required fields
        public Person(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }
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

        private double Heigth { get; set; }
        private double Weight { get; set; }

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
            if (FirstName.Length < 2)
            {
                throw new System.ArgumentException("You have entered to few (minimum 2) letters in your name");

            }
            else if (FirstName.Length >= 10)
            {
                throw new System.ArgumentException("You have entered to many (maximum 10) letters in your name");
            }
            else
            {
                return FirstName;
            }
        }

        public string ValidateLastName(string value)
        {
            if (LastName.Length < 2)
            {
                throw new System.ArgumentException("You have entered to few (minimum 2) letters in your name");

            }
            else if (LastName.Length >= 10)
            {
                throw new System.ArgumentException("You have entered to many (maximum 10) letters in your name");
            }
            else
            {
                return LastName;
            }
        }
    }
}

