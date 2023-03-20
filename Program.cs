class penjumlahan
{
    public static T JumlahTigaAngka<T>(T input1, T input2, T input3)
    {
        dynamic a = input1;
        dynamic b = input2;
        dynamic c = input3;
        return a + b + c;
    }

}

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] + ", yang tersimpan pada waktu UTC: " + inputDates[i]);
        }
    }

}


    class main
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(penjumlahan.JumlahTigaAngka<int>(13, 02, 21));

            SimpleDataBase<string> SDB = new SimpleDataBase<string>();
            SDB.AddNewData("13");
            SDB.AddNewData("02");
            SDB.AddNewData("21");
            SDB.PrintAllData();

        }
    }