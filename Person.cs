using System;

namespace Question_3
{
    class Person
    {
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public Int16 YearOfBirth { get; set; }

        public Person(string firstName, string lastName)
        {

            FirstName = firstName;
            LastName = lastName;
        }
        public int GetAge()
        {
            var age = DateTime.Now.Year - YearOfBirth;
            return age;
        }
        public string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

    }
}