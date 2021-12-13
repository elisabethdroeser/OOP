namespace OOP
{
    public class Person
    {
        private double heigth { get; set; } 
        private double weight { get; set; }

        private int age;
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

        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = ValidateString(value);
            }
        }

        private string lastName;
        public string LastName 
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = ValidateString(value);
            }
        }

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

        public string ValidateString(string input)
        {
            if (input.Length < 2 || input.Length >= 10)
            {
                throw new System.ArgumentException("You have entered to few (minimum 2) or to many (maximum 10 " +
                    "letters) in your name");

            }
            else
            {
                return input;
            }
        }
    }
}

