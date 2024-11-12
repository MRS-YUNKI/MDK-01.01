using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите сложное арифметическое выражение (например, 12*2+6):");
        string input = Console.ReadLine();

        double result = Solution(input);
        Console.WriteLine($"Результат вычислений: {result}.");
    }

    static double Solution(string input)
    {
        string[] parts = input.Split(new char[] { '+', '-', '*', '/' });
        List<double> numbers = new List<double>();
        foreach (var part in parts)
        {
            numbers.Add(double.Parse(part));
        }

        List<char> operators = new List<char>();
        foreach (var op in input)
        {
            if (op == '+' || op == '-' || op == '*' || op == '/')
            {
                operators.Add(op);
            }
        }
        for (int i = 0; i < operators.Count; i++)
        {
            if (operators[i] == '*')
            {
                double left = numbers[i];
                double right = numbers[i + 1];
                double result = operators[i] == '*' ? left * right : left / right;

                numbers[i] = result;
                numbers.RemoveAt(i + 1);
                operators.RemoveAt(i);
                i--;
            }
        }
        double final_result = numbers[0];
        for (int i = 0; i < operators.Count; i++)
        {
            if (operators[i] == '+')
            {
                final_result += numbers[i + 1];
            } else if (operators[i] == '-')
            {
                final_result -= numbers[i + 1];
            }
        }
        return final_result;
    }
}