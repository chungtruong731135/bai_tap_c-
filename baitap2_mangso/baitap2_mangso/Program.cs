using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Nhap mot so nguyen (0 < n < 50)" + "\n" +
                          "2. Nhap mot mang N so thuc" + "\n" +
                          "3. Tim so lon nhat trong mang" + "\n" +
                          "4. Tim so nho nhat trong mang" + "\n" +
                          "5. Tim so duong chan lon nhat trong mang" + "\n" +
                          "6. Tim so am le nho nhat trong mang" + "\n" +
                          "7. Tim cac so chinh phuong trong mang" + "\n" +
                          "8. Tinh tong mang" + "\n" +
                          "9. Tinh trung binh cong cac phan tu mang" + "\n" +
                          "10. Tim nhung phan tu lon hon trung binh cong" + "\n" +
                          "11. Sap xep mang tang dan" + "\n" +
                          "12. Sap xep mang giam dan" + "\n"   );


        Console.Write("chon mot cong viec: ");
        int w;
        do
        {
            w = int.Parse(Console.ReadLine());
            if (w < 0 || w > 12)
            {
                Console.Write("so khong hop le, nhap lai: ");
            }
        } while (w < 0 || w > 12);
        //Console.WriteLine(w);

        if (w == 1)
        {
            Input();
        } else if (w == 2)
        {
            IntArray();
        } else if (w == 3)
        {
            MaxValueInArray(IntArray());
        } else if (w == 4)
        {
            MinValueInArray(IntArray());
        } else if (w == 5)
        {
            MaxValueEvenInArray(IntArray());
        } else if (w == 6)
        {
            MinValueOddInArray(IntArray());
        } else if ( w == 7) 
        {
            FindSquareNumber(IntArray());
        } else if (w == 8)
        {
            SumArray(IntArray());
        } else if (w == 9)
        {
            AverageArray(IntArray());
        } else if (w == 10)
        {
            FindElementBiggerThanAverage(IntArray());
        } else if (w == 11)
        {
            SortIncrease(IntArray());
        } else if (w == 12)
        {
            SortDecrease(IntArray());
        }


    }

    //ham nhap vao mot so (0 < n < 50)
    static int Input()
    {
        int n;
        //bool isValid = false;
        Console.Write("nhap mot so: ");
        do
        {
            n = int.Parse(Console.ReadLine());
            if (n < 0 || n > 50)
            {
                Console.Write("so khong hop le, nhap lai: ");
            }
        } while (n < 0 || n > 50);

        Console.Write("ok! ");
        return n;
    }

    //ham nhap vao mot array
    static int[] IntArray()
    {
        Console.Write("nhap so phan tu trong mang: ");
        int n = int.Parse(Console.ReadLine());

        int[] result = new int[n];
        for(int i = 0; i < result.Length; i++)
        {
            Console.Write("phan tu thu" + (i + 1) + ": ");
            result[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("cac phan tu trong mang: ");
        for(int i = 0;i < result.Length; i++)
        {
            Console.Write("\t" + result[i]);
        }
        Console.WriteLine();
        return result;
    } 

    //tim so lon nhat trong mang
    static int MaxValueInArray(int[] array)
    {
        int x = int.MinValue;
        for(int i =0; i < array.Length; i++)
        {
            if (array[i] > x)
            {
                x = array[i];   
            }
        }
        Console.WriteLine("phan tu lon nhat trong mang la: " + x);
        return x;
    }

    //tim so nho nhat trong mang 
    static int MinValueInArray(int[] array)
    {
        int x = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < x)
            {
                x = array[i];
            }
        }
        Console.WriteLine("phan tu nho nhat trong mang la: " + x);
        return x;
    }

    //tim so duong chan lon nhat trong mang
    static int MaxValueEvenInArray(int[] array)
    {
        int x = int.MinValue;
        foreach (int i in array)
        {
            if (i > x && i > 0 && i % 2 == 0)
            {
                x = i;
            }
        }

        if (x != int.MinValue)
        {
            Console.WriteLine("so duong chan lon nhat trong mang la: " + x);
        } else
        {
            Console.WriteLine("khong tim thay so duong chan lon nhat trong mang!");
        }
        return x;
    }

    //tim so am le nho nhat trong mang
    static int MinValueOddInArray(int[] array)
    {
        int x = int.MaxValue;
        foreach(int i in array)
        {
            if (i < x && i < 0 && i % 2 !=0)
            {
                x = i;
            }
        }

        if (x != int.MaxValue)
        {
            Console.WriteLine("so am le nho nhat trong mang la: " + x);
        }
        else
        {
            Console.WriteLine("khong tim thay so am le nho nhat trong mang!");
        }
        return x;
    }

    //tim cac so chinh phuong trong mang
    static void FindSquareNumber(int[] array)
    {
        Console.Write("cac so chinh phuong trong mang la:");
        foreach(int i in array)
        {
            int sqr = (int)Math.Sqrt(i);
            if (i > 0 && sqr * sqr == i)
            {
                Console.Write("\t" + i);
            }
        }
    }

    //tinh tong mang
    static void SumArray(int[] array) 
    {

        Console.WriteLine("tong cac phan tu trong mang = " + array.Sum()); 
    }

    //tinh trung binh cong cac phan tu

    static void AverageArray(int[] array)
    {
        double sum = (double)array.Sum();
        double a = sum / array.Length;
        Console.WriteLine("trung binh cong cac phan tu trong mang = " + a);
    }

    //tim cac phan tu lon hon tbc
    static void FindElementBiggerThanAverage(int[] array)
    {
        double average = (double)array.Average();
        Console.WriteLine($"Average: {average}");

        Console.Write("cac phan tu lon hon tbc la: ");
        foreach(int i in array)
        {
            if(i > average)
            {
                Console.Write("\t" + i);
            }
        }
    }

    //sap xep mang tang dan 
    static void SortIncrease(int[] array)
    {
        Array.Sort(array);
        Console.Write("Mang sap xep tang dan: ");
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write("\t" + array[i]);
        }
    }

    //sap xep giam dan
    static void SortDecrease(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
        Console.Write("Mang sap xep giam dan: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("\t" + array[i]);
        }
        
    }
}