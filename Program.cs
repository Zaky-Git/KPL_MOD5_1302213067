class penjumlahan
{ 
    public static T JumlahTigaAngka<T>(T input1,T input2, T input3)
    {
        dynamic a = input1;
        dynamic b = input2;
        dynamic c = input3;
        return a + b + c;
    }

}

class main
{
    public static void Main(String[] args)
    {
        Console.WriteLine(penjumlahan.JumlahTigaAngka<int>(13, 02, 21));
    }
}