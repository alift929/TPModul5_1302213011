// See https://aka.ms/new-console-template for more information

public class HaloGeneric
{
    public static void SapaUser<T>(ref T user)
    {
        Console.WriteLine("Halo user {0}", user);
    }
}


public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah {0}", this.data);
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Input nama: ");
        String user = Console.ReadLine();
        HaloGeneric.SapaUser<string>(ref user);
        DataGeneric<int> dataGeneric = new DataGeneric<int>(1302213011);
        dataGeneric.printData();
    }
}
