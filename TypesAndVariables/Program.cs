namespace TypesAndVariables

{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello Canım!");
            int number1 = 10;
            long number2 = 1152545465156151156;
            short number3 = -32768;
            byte number4 = 255;

            bool bool1 = false;
            bool bool2 = true;

            
            
            Console.WriteLine("Number1 is {0}", number1);

            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}