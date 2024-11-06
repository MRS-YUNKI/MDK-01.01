using System.Diagnostics;

Console.WriteLine("Введите значение a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение шага (h): ");
double h = Convert.ToDouble(Console.ReadLine());

double y(double x)
{
    return Math.Cos(x*x) + Math.Sin(x) * Math.Sin(x);
}

int count = (int)Math.Ceiling((b - a) / h) + 1;
double[] x_values = new double[count];
double[] y_values = new double[count];
double min_y = double.MaxValue; 
double max_y = double.MinValue;
int crossing = 0;

for (int i = 0; i < count; i++)
{
    x_values[i] = a + i * h;
    y_values[i] = y(x_values[i]);
    if (y_values[i] < min_y)
    {
        min_y = y_values[i];
    }
    if (y_values[i] > max_y)
    {
        max_y = y_values[i];
    }
}

for (int i = 1; i < count; i++)
{
    if ((y_values[i - 1] >= 0 && y_values[i] < 0) || (y_values[i - 1] <= 0 && y_values[i] > 0))
    {
        crossing++;
    }
}

Console.WriteLine("Таблица");
Console.WriteLine("x\t\ty(x)");
Console.WriteLine("————————————————————————————————————————————");

for  (int i = 0; (i < count); i++)
{
    Console.WriteLine($"{x_values[i]}\t\t{y_values[i]}");
}

Console.WriteLine($"Минимальное значение: {min_y}");
Console.WriteLine($"Минимальное значение: {max_y}");
Console.WriteLine($"Количество пересечений с осью X: {crossing}");