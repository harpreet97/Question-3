using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool newPerson = true;
            do
            {
                Console.WriteLine("Enter name of new person below...");
                Console.WriteLine("************************************");
                Console.Write("First name: ");
                string firstName = Convert.ToString(Console.ReadLine());
                
                Console.WriteLine("");
                Console.Write("Last name: ");
                string lastName = Console.ReadLine();
                
                Console.WriteLine("");
                Console.WriteLine("Creating new person record...");
                Console.WriteLine("");
                Person obj = new Person(firstName, lastName);
                
                Console.Write("Enter year of birth: ");
                Int16 yob = Convert.ToInt16(Console.ReadLine());
                obj.YearOfBirth = yob;

                Console.WriteLine(string.Format("Person: {0} is {1} years old.", obj.GetFullName(), obj.GetAge()));
                Console.WriteLine("");
                Console.Write("Do you want to add another person? <y/n> :");
                char createNewPerson = Convert.ToChar(Console.ReadLine());
                if (createNewPerson == 'n')
                {
                    Console.WriteLine("Press any key to exit the program?");
                    Console.ReadKey();
                    newPerson = false;
                }
            } while (newPerson);

        }
    }
}
