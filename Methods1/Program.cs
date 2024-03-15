namespace Methods
{
    class Class1
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(20, 30);
            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(number1, number2);

            //Console.Write(result);
            Console.WriteLine(Multiply(4, 2));
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6, 7));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;

            return result;

        }

        static int Add3(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}