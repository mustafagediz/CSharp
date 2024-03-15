using System.Security.Cryptography.X509Certificates;

namespace Inheritace
{
    class program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer { FirstName = "Mustafa" }, new Student { FirstName = "Ahu" },
                new Person { FirstName = "Eymen" }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string City { get; set; }
    }

    class Student :Person
    {
        public string City { get; set; }

    }
}

