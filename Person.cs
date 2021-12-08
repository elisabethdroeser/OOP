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
                FirstName = value;
            }
        }
        private string LastName { get; set; }
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
    }
}
