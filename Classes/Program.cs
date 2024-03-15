namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager=new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer2 = new Customer()
            {
                Id = 2, City = "İstanbul", FirstName = "Mustafa", LastName = "Gediz"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();


        }
    }


}

