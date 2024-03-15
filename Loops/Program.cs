using System.Runtime.CompilerServices;

namespace Loops

{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //Whileloop();
 

            //DoWhileLoop();

            //ForEachLoop();

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("İs Prime Number");
            }
            else
            {
                Console.WriteLine("İs not Prime Number");
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;

            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number;
                }
            }

            return result;
        }

        //private static bool IsPrimeNumber(int number)
        //{
        //    if (number <= 1)
        //    {
        //        // 1 ve daha küçük sayılar asal değildir
        //        return false;
        //    }

        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            // Sayı başka bir sayıya tam bölündüğünde asal değildir
        //            return false;
        //        }
        //    }

        //    // Eğer yukarıdaki koşullar sağlanmıyorsa, sayı asaldır
        //    return true;
        //}


        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Mıstafa", "Afu", "Emo" };

            foreach (var studet in students)
            {
                
                Console.WriteLine(studet);
            }
        }

        private static void DoWhileLoop(int number)
        {
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number>=11);
        }

        private static void Whileloop()
        {
            int number = 100;
            while (number>=0)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finito");
        }
    }

}