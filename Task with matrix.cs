class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размерность квадратной таблицы: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите минимальное значение: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите максимальное значение: ");
        int max = Convert.ToInt32(Console.ReadLine());

        int[,] A = GenerateMatrix(N, max, min);
        int[,] B = GenerateMatrix(N, max, min);

        Console.WriteLine("Матрица A:");
        PrintMatrix(A);
        Console.WriteLine("Матрица B:");
        PrintMatrix(B);

        while (true)
        {
            Console.WriteLine("Выберите операцию: ");
            Console.WriteLine("1. Сложение матриц;");
            Console.WriteLine("2. Вычитание матриц;");
            Console.WriteLine("3. Выход");
            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": 
                    int[,] sum = SumMatrix(A, B, N);
                    Console.WriteLine("Результат сложения матриц:");
                    PrintMatrix(sum);
                 break;
                    case "2": 
                    int[,] difference = DiffMatrix(A, B, N);
                    Console.WriteLine("Результат разности матриц:");
                    PrintMatrix(difference);
                 break;
                    case "3":
                    Console.WriteLine("Выполняется выход из программы:");
                    return;
                default:
                    Console.WriteLine("Неверный ввод.");
                    break;
            }
        }

    }
    static int[,] GenerateMatrix(int N, int max, int min)
    {
        Random rand = new Random();
        int[,] matrix = new int[N, N];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = rand.Next(min, max + 1);
            }
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0);
        for (int i = 0;i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static int[,] SumMatrix(int[,] A, int[,] B, int N)
    {
        int[,] sum = new int[N, N];
        for (int i = 0; i < N; i++)
        {
            for(int j = 0;j < N; j++)
            {
                sum[i,j] = A[i, j] + B[i,j];
            }
        }
        return sum;
    }

    static int[,] DiffMatrix(int[,] A, int[,] B, int N)
    {
        int[,] difference = new int[N, N];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                difference[i, j] = A[i, j] - B[i, j];
            }
        }
        return difference;
    }
}
