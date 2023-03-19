internal class Program
{
    private static void Main(string[] args)
    {
        HelloGeneric helloGeneric = new HelloGeneric;
        helloGeneric.SapaUser("Farhan Mulya Argaynto");
    }
}

internal class HelloGeneric
{
    public void SapaUser(string username)
    {
        Console.WriteLine("Hallo User "+ username);
    }
}