internal class Program
{
    private static void Main(string[] args)
    {
        DataGeneric dataGeneric = new DataGeneric("1302213073");
        dataGeneric.printData();
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
        Console.WriteLine("Data yang tersimpan adalah :"+v);
    }
}