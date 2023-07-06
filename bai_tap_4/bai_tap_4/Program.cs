class Program
{
    static void Main(string[] args)
    {
        FindMaxMin(InputMatrix());
    }

    //nhap vao ma tran vuong n x n

    static int[,] InputMatrix ()
    {
        Console.WriteLine("Nhap kich thuoc ma tran vuong:");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        Console.WriteLine("Nhap cac phan tu cua ma tran:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("matrix[{0}][{1}] = ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Ma tran da nhap:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        return matrix;
    }

    //tinh tong cac phan tu duong trong mang
    static void PositiveSum(int[,] matrix)
    {
        int sum = 0;
        for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
        {
            for (int j = 0; j < Math.Sqrt(matrix.Length); j++)
            {
                if (matrix[i, j] >= 0)
                {
                    sum += matrix[i, j];
                }
            }
        }

        Console.WriteLine("tong cac phan tu duong trong mang la: " + sum);
    }

    //Tính tổng các phần tử A[i][j] trong đó (i + j) chia hết cho 5 .

    static void Sum1(int[,] matrix)
    {
        int sum1 = 0;
        for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
        {
            for (int j = 0; j < Math.Sqrt(matrix.Length); j++)
            {
                if ((i + j) % 5 == 0)
                {
                    sum1 += matrix[i, j];
                }
            }
        }

        Console.WriteLine("tong cac phan tu A[i][j] trong do (i + j) chia het cho 5 la: " + sum1);
    }

    //In ra các số nguyên tố theo từng hàng.
    static void PrintPrimeNumber(int[,] matrix)
    {
        Console.WriteLine("cac so nguyen to la: ");
        for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
        {
            for (int j = 0; j < Math.Sqrt(matrix.Length); j++)
            {
                int s = 0;
                for (int k = 1; k <= matrix[i, j]; k++)
                {
                    
                    if (matrix[i, j] % k == 0)
                    {
                        s++;
                    }
                    
                }
                if (s == 2 || matrix[i, j] == 1)
                {
                    Console.Write(matrix[i, j] + " ");
                } else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }

    // Sắp xếp tăng dần theo hàng.
    static void SortInRow(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        Console.WriteLine("sap xep tang dan theo hang ngang: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols ; j++)
            {
                for (int k = j + 1; k < cols; k++)
                {
                    if (matrix[i, j] > matrix[i, k])
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[i, k];
                        matrix[i, k] = temp;
                    }
                }
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    //Sắp xếp giảm dần theo cột .

    static void SortInColumn(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        Console.WriteLine("sap xep giam dan theo cot: ");
        for (int j = 0; j < cols; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int k = i + 1; k < rows; k++)
                {
                    if (matrix[i, j] < matrix[k, j])
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[k, j];
                        matrix[k, j] = temp;
                    }
                }
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    //Tính tổng các phần tử trên đường chéo chính(i = j) và trên đường biên.

    static void Sums(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int sum1 = 0;
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == j)
                {
                    sum1 += matrix[i, j];
                }
            }
        }

        Console.WriteLine("tong cac phan tu tren duong cheo chinh = " + sum1);

        int sum2 = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == 0 || j == 0 || i == rows - 1 || j == cols - 1)
                {
                    sum2 += matrix[i, j];
                }
            }
        }
        Console.WriteLine("tong cac phan tu tren duong bien = " + sum2);

    }

    //Tìm phần tử max, phần tử min theo từng hàng, từng cột và toàn bộ ma trận.
    static void FindMaxMin(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int overallMin = int.MaxValue;
        int overallMax = int.MinValue;

        //min va max theo tung hang
        Console.WriteLine("Phan tu min va max theo tung hang:");

        for (int i = 0; i < rows; i++)
        {
            int rowMin = int.MaxValue;
            int rowMax = int.MinValue;

            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] < rowMin)
                    rowMin = matrix[i, j];

                if (matrix[i, j] > rowMax)
                    rowMax = matrix[i, j];
            }
            Console.WriteLine("Hang {0}: Min = {1}, Max = {2}", i, rowMin, rowMax);

            if (rowMin < overallMin)
                overallMin = rowMin;

            if (rowMax > overallMax)
                overallMax = rowMax;
        }

        //min va max theo tung cot
        Console.WriteLine("Phan tu min va max theo tung cot:");

        for (int j = 0; j < cols; j++)
        {
            int colMin = int.MaxValue;
            int colMax = int.MinValue;

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, j] < colMin)
                    colMin = matrix[i, j];

                if (matrix[i, j] > colMax)
                    colMax = matrix[i, j];
            }

            Console.WriteLine("Cot {0}: Min = {1}, Max = {2}", j, colMin, colMax);

            if (colMin < overallMin)
                overallMin = colMin;

            if (colMax > overallMax)
                overallMax = colMax;
        }


        //min va max toan bo ma tran
        Console.WriteLine("phan tu min va max toan bo ma tran:");
        Console.WriteLine("Min = {0}, Max = {1}", overallMin, overallMax);
    }
}
