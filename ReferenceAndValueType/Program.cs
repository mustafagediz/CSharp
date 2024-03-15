using System.Data;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;

            number1 = 30;
            Console.WriteLine(number2);

            string[] cities1 = { "Ankara", "Konya", "Eskişehir" };
            string[] cities2 = { "İzmir", "Balıkesir", "Aydın" };
            cities2 = cities1;
            cities1[0] = "İstanbul";

            // DataTable dt = new DataTable(); bu yanlış bir klullanım olacaktır çünkü new lemek performans ve bellek için büyük yük oluştracaktır.
            DataTable dt;
            DataTable dt2 = new DataTable();
            dt=dt2;




            Console.WriteLine(cities2[0]);

            Console.ReadLine();

        }
    }
}

