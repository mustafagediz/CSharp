namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();
            customerManager.Add();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Console.WriteLine("Customer added!");
        }
    }

    class DatabaseLogger:ILogger   
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database!");
        }
    }

    class FileLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!");
        }
    }
    interface ILogger
    {
        void Log();
    }
}