using System.Collections;
using System.Xml.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("table","tablo");
            dictionary.Add("computer","bilgisayar");

            //Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Konya");

            //Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers= new List<Customer>();
            //customers.Add(new Customer{Id = 1, Name = "Mustafa"});
            //customers.Add(new Customer{Id=2, Name = "Ahu"});


            List<Customer> customers = new List<Customer>()
            {
                new Customer { Id = 1, Name = "Mustafa" },
                new Customer { Id = 2, Name = "Ahu" }
            };


            var customer2 = new Customer
            {
                Id = 3,
                Name = "Eymen"
            };

            customers.Add(customer2);

            customers.AddRange(new Customer[2]
            {
                new Customer { Id = 4, Name = "Ali" },
                new Customer { Id = 5, Name = "Ayşe" }
            });

            // customers.Clear(); listeyi temizler

            //Console.WriteLine(customers.Contains(customer2));
            var index = customers.IndexOf(customer2);//listedeki elemanın kaçıncı sıarada olduğunu verir.baştan başlar. yani o. sıradan

            Console.WriteLine("Index : {0}", index);

            customers.Add(customer2);

            var index2 = customers.LastIndexOf(customer2);//listedeki elemanın kaçıncı sıarada olduğunu verir.sondan başlar. 
            Console.WriteLine("Index : {0}", index2);
           
            customers.Insert(0,customer2);//listeye istediğimiz sıradan eklemek için çalıştıracağımız metod

            customers.Remove(customer2);// listede ilk bulduğu customer2 yi siler. başka varsa onlar kalır
            customers.RemoveAll(c => c.Name == "Eymen");



            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }

            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();

            cities.Add("Ankara");
            cities.Add("Adana");

            cities.Add("Konya");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('M');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}

