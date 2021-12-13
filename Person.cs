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

        //propfull
        //private int age;

        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}


        private string lastName;
        public string LastName //Public 
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

        private double heigth { get; set; } //private height
        private double weight { get; set; }

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
            //else if (FirstName.Length >= 10)
            //{
            //    throw new System.ArgumentException("You have entered to many (maximum 10) letters in your name");
            //}
            else
            {
                return input;
            }
        }

        //public string ValidateLastName(string value)
        //{
        //    if (LastName.Length < 2)
        //    {
        //        throw new System.ArgumentException("You have entered to few (minimum 2) letters in your name");

        //    }
        //    else if (LastName.Length >= 10)
        //    {
        //        throw new System.ArgumentException("You have entered to many (maximum 10) letters in your name");
        //    }
        //    else
        //    {
        //        return LastName;
        //    }
        //}
    }
}

