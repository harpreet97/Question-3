using System;

namespace Question_3
{
    class Person
    {
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public Int16 YearOfBirth { get; set; }

        public Person(string fn, string ln)
        {

            FirstName = fn;
            LastName = ln;
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
    class Program
    {
        static void Main(string[] args)
        {
            bool newPerson = true;
            do
            {
                Console.WriteLine("Enter name of new person below...");
                Console.WriteLine("************************************");
                Console.WriteLine("Please enter your firstname here?");
                string fn = Convert.ToString(Console.ReadLine());
                Console.WriteLine("First name: " + fn);
                Console.WriteLine("");
                Console.WriteLine("Please enter your lastname here?");
                string ln = Console.ReadLine();
                Console.WriteLine("Last name: " + ln);
                Console.WriteLine("");
                Console.WriteLine("Creating new person record...");
                Console.WriteLine("");
                Person obj = new Person(fn, ln);
                
                Console.WriteLine("Please enter your year of birth here?");
                Int16 yob = Convert.ToInt16(Console.ReadLine());
                obj.YearOfBirth = yob;

                Console.WriteLine(string.Format("Person: {0} is {1} years old.", obj.GetFullName(), obj.GetAge()));
                Console.WriteLine("");
                Console.WriteLine("Do you want to add another person? (y/n)");
                char createNewPerson = Convert.ToChar(Console.ReadLine());
                if (createNewPerson == 'n')
                {
                    Console.WriteLine("press any key to exit the program");
                    Console.ReadKey();
                    newPerson = false;
                }
            } while (newPerson);

        }
    }
}
