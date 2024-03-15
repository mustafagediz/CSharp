namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Customer
    {
        //private yaptığımızda bu erişim bildirgeci sadece tanımlı olduğu blogda çalışır yani diğer calss larda çalışmaz.
        //ancak biz bu erişim bildirgecini protected yaptığımızda inheritance yaptığımız bir class da bu method da çalışacaktır.

        protected int Id { get; set; }
        public void Save()
        {

        }

        public void Delete()
        {

        }
    }

    class Student
    {
        public void Save2()
        {

        }
    }

    public class Course //internal default olarak bir class tanımlanmış olarak gelir. bir class ya internal olur ya da public olur. 
                            //iç içe class larda ise private olabilir

    {
        public string Name { get; set; }
    }
}

