public class Program
{
    public static void Main(string[] args)
    {
        MedianFinder medianFinder = new MedianFinder();
        Console.WriteLine("Введите числа для нахождения медианы (после завершения ввода чисел введите 'exit' для выхода из ввода):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "exit")
            {
                break;
            }
            if (int.TryParse(input, out int num))
            {
                medianFinder.AddNum(num);
            }
        }
        Console.WriteLine($"Медиана: {medianFinder.FindMedian()}");
    }
}

public class MedianFinder
{
    private List<int> numbers;
    public MedianFinder()
    {
        numbers = new List<int>();
    }

    public void AddNum(int num)
    {
        numbers.Add(num);
    }

    public double FindMedian()
    {
        int count = numbers.Count;
        if (count % 2 != 0)
        {
            return numbers[count / 2];
        } else
        {
            return (numbers[count / 2] + numbers[count / 2 - 1]) / 2.0;
        }
    }
}