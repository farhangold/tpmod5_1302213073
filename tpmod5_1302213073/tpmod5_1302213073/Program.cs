internal class Program
{
    private static void Main(string[] args)
    {
        HelloGeneric helloGeneric = new HelloGeneric();
        helloGeneric.SapaUser("Farhan Mulya Argaynto");

        DataGeneric dataGeneric = new DataGeneric("1302213073");
        dataGeneric.printData();
    }
}

internal class HelloGeneric
{
    public void SapaUser(string username)
    {
        Console.WriteLine("Hallo User "+ username);
    }
}

internal class DataGeneric
{
    private string v;

    public DataGeneric(string v)
    {
        this.v = v;
    }

    internal void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah :" + v);
    }
}