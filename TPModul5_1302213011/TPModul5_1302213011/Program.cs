// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    public static void SapaUser<T> (ref T user)
    {
        Console.WriteLine("Halo user {0}", user);
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Input nama: ");
        String user = Console.ReadLine();
        HaloGeneric.SapaUser<string>(ref user);
    }
}
