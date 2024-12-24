Console.Write("Введите значение нижнего предела (a): ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение верхнего предела (b): ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите количество разбиений интеграла на прямоугольники (n): ");
int n = Convert.ToInt32(Console.ReadLine());

double f(double x)
{
    return 2 * Math.Pow(x, 2) + 3 * x;
}

double h = (b - a) / n;
double pre_integrals = 0;

for (int i = 0; i < n; i++)
{
    double middle_point = a + (i + 0.5) * h;
    pre_integrals += f(middle_point);
}
double result = h * pre_integrals;

StreamWriter file = new StreamWriter("C:\\Users\\prdb\\Desktop\\Demo\\Sch\\MDKMDK\\TRAINING\\OUTPUT.txt");
file.WriteLine($"Результат расчетов: {result}");
file.Close();
