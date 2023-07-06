using System.Security.Cryptography;
using System;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        InputString();
    }

    static string[] InputString()
    {
        int n;
        string[] strings;

        Console.Write("nhap so nguyen n (0 < n <=50): ");
        do
        {
            n = int.Parse(Console.ReadLine());
            if(n <=0 || n > 50)
            {
                Console.Write("n khong hop le, nhap lai: ");
            }
        } while (n <= 0 || n > 50);

        Console.WriteLine();

        strings = new string[n];

        for(int i = 0; i < strings.Length; i++)
        {
            Console.WriteLine("nhap chuoi thu {0} : ", (i+1));
            do
            {
                strings[i] = Console.ReadLine();
                if (strings[i].Length > 30)
                {
                    Console.Write("chuoi vua nhap khong hop le, nhap lai: ");
                }
            } while (strings[i].Length > 30);
        }


        Console.WriteLine("cac chuoi da nhap: ");
        for(int i = 0; i < strings.Length; i++)
        {
            Console.WriteLine(strings[i]);
        }

        return strings;
    }


    //ham in chuoi
    static void OutputString(string[] strings)
    {
        for (int i = 0; i < strings.Length; i++)
        {
            Console.WriteLine(strings[i]);
        }
    }
    //tim chuoi co kich thuoc nho nhat/lon nhat

    static string FindMaxArray(string[] strings)
    {
        string str = strings[0];
        for(int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length > str.Length)
            {
                str = strings[i];
            }
        }

        Console.WriteLine("chuoi co kich thuoc lon nhat la: {0}", str);
        return str;
    }

    static string FindMinArray(string[] strings)
    {
        string str2 = strings[strings.Length - 1];
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length < str2.Length)
            {
                str2 = strings[i];
            }
        }

        Console.WriteLine("chuoi co kich thuoc nho nhat la: {0}", str2);
        return str2;
    }

    //tinh kich thuoc trung binh cac chuoi
    static double CountAverageLength(string[] strings)
    {
        double count = 0;
        double sum = 0;

        for(int i = 0; i<strings.Length; i++)
        {
            sum += strings[i].Length;
            count++;
        }

        double average = (double)(sum / count);

        Console.WriteLine($"kich thuoc trung binh cua chuoi la: {average}");

        return average;
    }

    //hien thi nhung chuoi lon hon kich thuoc trung binh

    static void ArrayBiggerThanAverage(string[] strings)
    {
        int j = 1;
        double average = CountAverageLength(strings);
        Console.WriteLine("nhung chuoi co kich thuoc lon hon kich thuoc trung binh la: ");
        for(int i = 0; i<strings.Length; i++)
        {
            if (strings[i].Length > average)
            {
                Console.WriteLine(j + ": " + strings[i]);
                j++;
            }
        }
    }

    //sap xep chuoi
    static void SortArray(string[] strings)
    {
        //sap xep giam dan
        for(int i = 0; i<strings.Length; i++)
        {
            for(int j = i; j < strings.Length; j++)
            {
                string str = "";
                if (strings[j].Length > strings[i].Length)
                {
                    str = strings[i];
                    strings[i] = strings[j];
                    strings[j] = str;
                }
            }
        }
        Console.WriteLine("mang sau khi da sap xep giam dan: ");

        for(int i = 0; i<strings.Length;i++)
        {
            Console.WriteLine(strings[i]);
        }

        //sap xep tang dan
        for (int i = 0; i < strings.Length; i++)
        {
            for (int j = i; j < strings.Length; j++)
            {
                string str = "";
                if (strings[j].Length < strings[i].Length)
                {
                    str = strings[i];
                    strings[i] = strings[j];
                    strings[j] = str;
                }
            }
        }
        Console.WriteLine("mang sau khi da sap xep tang dan: ");

        for (int i = 0; i < strings.Length; i++)
        {
            Console.WriteLine(strings[i]);
        }
    }

    //tim chuoi theo ASCII
    static void FindArrayByASCII(string[] strings)
    {

        string str = strings[strings.Length - 1];
        string str2 = strings[0];

        for (int i = 0; i < strings.Length; i++)
        {
            if (string.Compare(strings[i], str, StringComparison.Ordinal) < 0)
            {
                str = strings[i];
            }
            if (string.Compare(strings[i],str2, StringComparison.Ordinal) > 0)
            {
                str2 = strings[i];
            }
        }

        Console.WriteLine($"chuoi nho nhat la {str} va lon nhat la {str2}");
    }

    //sap xep chuoi tang dan theo ASCII
    static void SortArrayIncreaseByASCII(string[] strings)
    {
        for(int i = 0; i < strings.Length - 1;i++)
        {
            for(int j = i + 1; j < strings.Length; j++)
            {
                if (string.Compare(strings[i], strings[j], StringComparison.Ordinal) > 0)
                {
                    string str = "";
                    str = strings[i];
                    strings[i] = strings[j];
                    strings[j] = str;
                }
            }
        }

        Console.WriteLine("chuoi sau khi sap xep tang dan ASCII la: ");
        for (int i = 0; i < strings.Length; i++)
        {
            Console.WriteLine(strings[i]);
        }
    }

    //sap xep chuoi giam dan theo ASCII
    static void SortArrayDecreaseByASCII(string[] strings)
    {
        for (int i = 0; i < strings.Length - 1; i++)
        {
            for (int j = i + 1; j < strings.Length; j++)
            {
                if (string.Compare(strings[i], strings[j], StringComparison.Ordinal) < 0)
                {
                 
                    string str = strings[i];
                    strings[i] = strings[j];
                    strings[j] = str;
                }
            }
        }

        Console.WriteLine("chuoi sau khi sap xep giam dan ASCII la: ");
        for (int i = 0; i < strings.Length; i++)
        {
            Console.WriteLine(strings[i]);
        }
    }

    //so sanh chuoi st va cac chuoi trong mang
    static void CompareStringToStrings(string[] strings)
    {
        Console.WriteLine("nhap vao chuoi st (0< length < 30): ");
        string st;
        do
        {
            st = Console.ReadLine();
            if (st.Length > 30)
            {
                Console.Write("chuoi st khong hop le, nhap lai");
            }
        } while (st.Length > 30);

        int num = 0;
        Console.WriteLine("cac chuoi trong mang co kich thuoc ban chuoi st: ");
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length == st.Length)
            {
                Console.WriteLine(strings[i]);
                num++;
            }
        }

        if (num == 0)
        {
            Console.WriteLine("khong co chuoi nao ");
        }

        int num2 = 0;
        Console.WriteLine("cac chuoi trong mang co chua chuoi st la: ");
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Contains(st))
            {
                Console.WriteLine(strings[i]);
                num2++;
            }
        }

        if (num2 == 0)
        {
            Console.WriteLine("khong co chuoi nao ");
        }

    }

    //tim nhung chuoi co tinh dioi xung trong mang a
    static void FindOppositeString(string[] strings)
    {
        Console.WriteLine("cac chuoi co tinh doi xung la: ");
        int num = 0;
        for (int i = 0; i < strings.Length; i++)
        {
            
            bool isOpposite = true;
            for(int j = 0; j < strings[i].Length / 2; j++)
            {
                if (strings[i][j] != strings[i][strings[i].Length - j - 1])
                {
                    isOpposite = false;
                }
            }

            if(isOpposite)
            {
                Console.WriteLine(strings[i]);
                num++;
            }
        }

        if (num == 0)
        {
            Console.WriteLine("khong co chuoi doi xung");
        }
    }

    //hien thi nhung chuoi la dia chi email chuan

    static void FindEmailString(string[] strings)
    {
        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        Console.WriteLine("nhung chuoi la dinh dang email chuan: ");
        int n = 0;

        for (int i = 0; i < strings.Length; i++)
        {
            if (Regex.IsMatch(strings[i], pattern))
            {
                Console.WriteLine(strings[i]);
                n++;
            }
        }

        if(n == 0)
        {
            Console.WriteLine("khong co chuoi nao");
        }
    }

    //tim nhung chuoi co ki tu so isDitgit
    static void FindNumberInString(string[] strings)
    {
        Console.WriteLine("nhung chuoi co ki tu so: ");
        int num = 0;

        for (int i = 0; i < strings.Length; i++)
        {
            bool isDigit = false;
            foreach(char s in strings[i])
            {
                if(char.IsDigit(s)) 
                { 
                    isDigit = true;
                    break;
                }
            }

            if (isDigit ==true)
            {
                Console.WriteLine(strings[i]);
                num++;
            }
        }

        if (num == 0)
        {
            Console.WriteLine("khong co chuoi co chua ki tu so ");
        }
    }

    //tim chuoi co ki tu in hoa
    static void FindUpperChar(string[] strings)
    {
        Console.WriteLine("nhung chuoi co ki tu in hoa: ");
        int num = 0;

        for (int i = 0; i < strings.Length; i++)
        {
            bool isUpper = false;
            foreach (char s in strings[i])
            {
                if (char.IsUpper(s))
                {
                    isUpper = true;
                    break;
                }
            }

            if (isUpper == true)
            {
                Console.WriteLine(strings[i]);
                num++;
            }
        }

        if (num == 0)
        {
            Console.WriteLine("khong co chuoi co chua ki tu in hoa ");
        }
    }

    //tim chuoi co chua ki tu c
    static void findCharInString(string[] strings)
    {
        Console.Write("nhap vao chu can kiem tra: ");
        char a = Console.ReadKey().KeyChar;
        Console.WriteLine();
        int n = 0;

        for(int i = 0; i < strings.Length;i++)
        {
            bool checkLetter = false;
            if (strings[i].Contains(a))
            {
                checkLetter = true;
                break;
            }

            if(checkLetter == true)
            {
                Console.WriteLine(strings[i]);
                n++;
            }
        }

        if (n == 0)
        {
            Console.WriteLine("khong co chuoi nao chua ki tu tren");
        }
    }

    //tim so tu moi chuoi trong mang
    static void FindNumberCharInString(string[] strings)
    {
        for( int i= 0; i<strings.Length;i++)
        {
            Console.WriteLine($"chuoi {strings[i]} co {strings[i].Length} tu");
        }
    }

    //chen ki tu c vao vi tri thu 5 cua chuoi cuoi cung
    static void InsertString(string[] strings)
    {
        string lastString = strings[strings.Length - 1];

        if (lastString.Length < 5)
        {
            Console.WriteLine("chuoi cuoi cung ko du 5 ki tu");
        } else
        {
            Console.Write("nhap vao chu can chen: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            string result = lastString.Insert(4, c.ToString());
            strings[strings.Length - 1] = result;

            Console.WriteLine("mang chuoi sau khi chen ki tu: " );
            OutputString(strings);

        }
    }

    //noi tat ca cac chuoi
    static void JoinString(string[] strings)
    {
        string result = string.Join("", strings);
        Console.WriteLine("chuoi sau khi noi la: ");
        Console.WriteLine(result);
    }

    //hien thi nhung chuoi chua chuoi dau tien
    static void FindStringContainFirstString(string[] strings)
    {
        string firstString = strings[0];
        int n = 0;

        Console.WriteLine("nhung chuoi chua chuoi dau tien trong mang la: ");
        for(int i = 1; i < strings.Length; i++)
        {
            if (strings[i].Contains(firstString))
            {
                Console.WriteLine(strings[i]);
                n++;
            }
        }

        if(n == 0)
        {
            Console.WriteLine("khong co chuoi nao!");
        }
    }

    // Kiểm tra xem chuỗi đầu tiên có bắt đầu bằng chuỗi "hello" không
    static void CheckFirstStringWithHello(string[] strings)
    { 
        string hello = "hello";

        if (strings[0].StartsWith(hello))
        {
            Console.WriteLine($"chuoi {strings[0]} co bat dau bang chuoi {hello}");
        } else
        {
            Console.WriteLine($"chuoi {strings[0]} ko bat dau bang chuoi {hello}");
        }
    }

    //tinh gtri tb the ASCII cua tung chuoi

    static void CountAverageASCIIInEachString(string[] strings)
    {
        for (int i = 0; i < strings.Length; i++)
        {
            double sum = 0;
            int count = 0;

            for (int j = 0;  j < strings[i].Length; j++)
            {
                sum += (int)strings[i][j];
                count++;
            }

            double average = sum / count;
            Console.WriteLine($"chuoi {strings[i]} co gia tri trung binh ASCII = {average}");
        }
    }

    //Hiển thị những chuỗi có độ dài lớn hơn độ dài nhỏ nhất và nhỏ hơn độ dài lớn nhất trong mảng a
    static void FindStringBiggerAndLessThanString(string[] strings)
    {
        string maxString = FindMaxArray(strings);
        string minString = FindMinArray(strings);

        Console.WriteLine("nhung chuoi co do dai nho hon do dai lon nhat trong mang la: ");
        for (int i = 0; i < strings.Length; i++)
        { 
            if (strings[i].Length < maxString.Length)
            {
                Console.WriteLine(strings[i]);
            }
        }

        Console.WriteLine("nhung chuoi co do dai lon hon do dai nho nhat trong mang la: ");
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length > minString.Length)
            {
                Console.WriteLine(strings[i]);
            }
        }
    }

    //Nhập vào một độ dài xác định và in ra những chuỗi có độ dài bằng độ dài xác định đó.

    static void FindStringEqualLength(string[] strings)
    {
        Console.Write("nhap vao length can kiem tra: ");
        int length = int.Parse(Console.ReadLine());
        int n = 0;

        Console.Write("nhung chuoi co do dai bang length la: ");
        for (int i = 0; i < strings.Length;i++)
        {
            if (strings[i].Length == length)
            {
                Console.WriteLine(strings[i]);
                n++;
            }
        }

        if(n == 0)
        {
            Console.WriteLine("khong co.");
        }
    }

    //Đếm số từ trong chuỗi thứ N-1

    static void CountCharInString(string[] strings)
    {
        string str = strings[strings.Length - 2];

        Console.WriteLine($"{str} co do dai {str.Length} ki tu");
    }

    //Chuyển chuỗi thứ hai thành chuỗi in hoa.

    static void Convert2ndStringToUpper(string[] strings)
    {
        if (strings.Length < 2)
        {
            Console.WriteLine("mang co it hon 2 chuoi");
        }
        else
        {
            string str2 = strings[1].ToUpper();
            strings[1] = str2;
            Console.WriteLine("mang chuoi sau khi chuyen doi:");
            OutputString(strings);
        }
    }

    //Cắt ký tự trắng ở cuối và đầu chuỗi cuối cùng
    static void CutSpaceInLastString(string[] strings)
    {
        strings[strings.Length - 1].Trim();
        Console.WriteLine("chuoi cuoi cung sau khi cat ki tu trang o cuoi va dau:");
        Console.WriteLine(strings[strings.Length - 1]);
    }

    //Cắt ký tự trắng thừa ở giữa chuỗi cuối cùng

    static void CutSpaceInMiddleString(string[] strings)
    {
        while(strings[strings.Length - 1].IndexOf("  ") != -1) {
            strings[strings.Length - 1] = strings[strings.Length - 1].Replace("  ", " ");
        }
        Console.WriteLine("chuoi cuoi cung sau khi cat ki tu trang o giua:");
        Console.WriteLine(strings[strings.Length - 1]);
    }
}
