using System.Diagnostics.CodeAnalysis;

Console.Write("Введите значение нижнего предела (a): ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение верхнего предела (b): ");
double b = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите количество разбиений интеграла на прямоугольники: ");
int n = Convert.ToInt32(Console.ReadLine());

double f(double x)
{
    return 2 * Math.Pow(x, 2) + 3 * x;
}

double h = (b - a) / n;
double sum = 0; //Суммма промежуточных результатов (т.е. подынтервалов)

for  (int i = 0; i < n; i++)
{
    double middle_point = a + (i + 0.5) * h; //Вычисление средней точки
    sum += f(middle_point); //Вычисление значения подынтыгральной функции в средней точке прямоугольника и добавление к интегральной сумме
}
double result = h * sum;
Console.WriteLine($"Приближенное значение определенного интеграла в пределе от {a} до {b} с разбиением на {n} равняется {result}.");


try
{
    StreamWriter file = new StreamWriter("C:\\Users\\prdb\\Desktop\\Demo\\Sch\\MDKMDK\\INTEGRALS");
    file.WriteLine($"Результат: {result}");
    file.Close();
} catch(Exception exc)
{
    Console.WriteLine("Exception: " + exc.Message);
} finally
{
    Console.WriteLine("Finished");
}