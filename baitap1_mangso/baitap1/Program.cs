using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args) {
        Console.WriteLine("nhap sp phan tu: ");
        int n = int.Parse(Console.ReadLine());

        int[] ints = RandomArray(n);

        Console.WriteLine("mang truoc khi sap xep: ");

        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write("\t" + ints[i]);
        }
        Console.WriteLine();


        SortArray(ints);
        Console.WriteLine("mang sau khi sap xep: ");

        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write("\t" + ints[i]);
        }
        Console.WriteLine();

        Console.WriteLine("mang sau khi loai bo phan tu trung lap: ");
        var ints2 = ints.Distinct(); //loai bo phan tu trung lap

        foreach (int i in ints2)
        {
            Console.Write("\t" + i);
        }

    }

    //Ham tao mang ngau nhien
    static int[] RandomArray(int s)
    {
        int[] array = new int[s];
        Random random = new Random();

        for(int i = 0; i < array.Length;i++)
        {
            array[i] = random.Next(10);
        }
        return array;
    }


    //ham sap xep cac phan tu trong
    static int[] SortArray(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            for(int j = i; j < array.Length; j++)
            {
                if(array[j] < array[i])
                {
                    int x = 0;
                    x = array[i];
                    array[i] = array[j];
                    array[j] = x;
                }
            }
        }
        return array;
    }
}
