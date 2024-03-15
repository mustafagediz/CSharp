namespace Arrays

{
    class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Mıstafa";
            //string student2 = "Afu";
            //string student3 = "Emo";

            string[] students = new string[3];
            students[0] = "Mıstafa";
            students[1] = "Afu";
            students[2] = "Emo";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }


            string[,] regions = new string[5, 3]
            {
                { "İstanbul", "İzmit", "Balıkesir" },
                { "Ankara", "Konya", "Kırıkkale" },
                { "Antalya", "Adana", "Mersin" },
                { "Rize", "Trabzon", "Samsun" },
                { "İzmir", "Muğla", "Manisa" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**********");
            }


            Console.WriteLine();
            Console.ReadLine();
        }
    }

}