namespace RecapDemo;

interface ICustomerDal
{
    void Add();
    void Update();
    void Delete();
}

class SglServerCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Sql Added!");
    }

    public void Update()
    {
        Console.WriteLine("Sql Updated!");
    }

    public void Delete()
    {
        Console.WriteLine("Sql Deleted!");
    }
}

class OracleCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Oracle Added!");
    }

    public void Update()
    {
        Console.WriteLine("Oracle Update!");
    }

    public void Delete()
    {
        Console.WriteLine("Oracle Deleted!");
    }
}

class CustomerManager
{
    public void Add(ICustomerDal customerDal)
    {
        customerDal.Add();
    }
}
