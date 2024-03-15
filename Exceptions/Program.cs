namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
              
            }
            
            //method
            HandleException(() =>
            {
                Find();
            });


            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);

            }
        }

        private static void Find()
        {
            List<string> student = new List<string> { "Mustafa", "Ahu", "Eymen" };
            if (!student.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Mustafa", "Ahu", "Eymen" };

                students[3] = "Ahmet";

            }
            catch(IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
    
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;

            }
        }
    }
}

