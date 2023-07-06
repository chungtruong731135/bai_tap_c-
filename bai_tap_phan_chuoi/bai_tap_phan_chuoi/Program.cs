class Program
{
    static void Main(string[] args)
    {

    }

    //nhap mot chuoi bat ki
    static string InputString()
    {
        Console.Write("nhap vao mot chuoi (kich thuoc0 den 50): ");
        string str;
        do
        {
            str = Console.ReadLine();
            if (str.Length < 0 || str.Length > 50)
            {
                Console.WriteLine("chuoi nhap vao khong hop le, nhap lai: ");
            }

        } while (str.Length < 0 || str.Length > 50);

        Console.WriteLine($"chuoi vua nhap: {str}");
        return str;
    }

    //kiem tra xem trong chuoi co ki tu so hay khong
    static void CheckNumberInString(string str)
    {
        bool isDigits = false;
        foreach(char i in str)
        {
            if (char.IsDigit(i)) {
                isDigits = true;
            }
        }

        if (isDigits == true)
        {
            Console.WriteLine("trong chuoi vua nhap co ki tu so!");
        } else
        {
            Console.WriteLine("khong co so trong chuoi!");
        }
    }

    //kiem tra xem trong chuoi co ki tu in hoa hay khong
    static void CheckUpperInString(string str)
    {
        bool isUpper = false;
        foreach (char i in str)
        {
            if (char.IsUpper(i))
            {
                isUpper = true;
            }
        }

        if (isUpper == true)
        {
            Console.WriteLine("trong chuoi vua nhap co chu cai in hoa!");
        }
        else
        {
            Console.WriteLine("khong co chu cai in hoa trong chuoi!");
        }
    }

    //kiem tra xem trong chuoi co chua mot ki tu nao do hay khong
    static void CheckLetterInString(string str)
    {
        Console.Write("nhap vao chu can kiem tra: ");
        char a = Console.ReadKey().KeyChar;
        Console.WriteLine();

        bool checkLetter = false;

        if(str.Contains(a)) 
        { 
            checkLetter = true;
        }

        if (checkLetter == true)
        {
            Console.WriteLine($"trong chuoi {str} co ki tu {a}.");
        } else
        {
            Console.WriteLine($"trong chuoi {str} khong co ki tu {a}");
        }
    }

    //kiem tra chuoi b voi chuoi a
    static void CheckStringToString(string str)
    {
        Console.Write("nhap vao chuoi can kiem tra: ");
        string b = Console.ReadLine();


        if(str.Contains(b))
        {
            Console.WriteLine($"chuoi {b} nam trong chuoi {str} ");

        } else
        {
            Console.WriteLine($"chuoi {b} khong nam trong chuoi {str} ");
        }

        if (b.Length > str.Length)
        {
            Console.WriteLine($"chuoi {b} co do dai lon hon chuoi {str} ");
        } else
        {
            Console.WriteLine($"chuoi {b} co do dai nho hon chuoi {str} ");
        }
    }

    //kiem tra tinh doi xung cua chuoi 
    static void CheckOppositeString(string str)
    {
        bool isOpposite = true;
        for (int i = 0; i < str.Length/2; i++) 
        {
            if (str[i] != str[str.Length - i - 1])
            {
                isOpposite = false;
            }
        }

        if (isOpposite)
        {
            Console.WriteLine($"chuoi {str} la doi xung");
        } else
        {
            Console.WriteLine($"chuoi {str} khong la doi xung");
        }
    }

    //kiem tra chuoi co bao nhieu tu
    static void CheckSumLetter(string str)
    {
        Console.WriteLine($"chuoi {str} co {str.Length} tu");
    }

    //cat tat ca dau cach o dau va cuoi chuoi
    static void CutSpaceTopAndBotInLetter(string str)
    {
        Console.WriteLine($"chuoi sau khi cat khoang trang o dau va cuoi: {str.Trim()}");
    }

    //dam bao chi co mot dau cach giua hai tu bat ki
    static void CutSpaceInEachLetter(string str)
    {
        while(str.IndexOf("  ") != -1)
        {
            str = str.Replace("  ", " ");
        }
        Console.WriteLine($"chuoi sau khi cat khoang trang giua hai tu la: {str}");
    }


    //tinh gtri ASCII trung binh
    static void CalAverageASCIIValue(string str)
    {
        int sum = 0;
        int count = 0;

        foreach(char c in str)
        {
            sum += (int)c;
            count++;
        }

        double average = (double)sum / count;
        Console.WriteLine("gia tri trung binh ACSII = " +  average);
    }

    //dem so lan xuat hien cua moi ki tu
    static void CountChar(string str)
    {
        Dictionary<char, int> dics = new Dictionary<char, int>();

        foreach(char c in str)
        {
            if(dics.ContainsKey(c))
            {
                dics[c]++;
            } else
            {
                dics[c] = 1;
            }
        }

        foreach(var c in dics)
        {
            Console.WriteLine($"ki tu {c.Key} xuat hien {c.Value} lan");
        }
    }
}
