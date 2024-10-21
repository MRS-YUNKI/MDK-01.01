Console.WriteLine("Введите координаты пушки по оси X (есть возможность указать значение с плавающей точкой:");
double x0 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты пушки по оси Y (есть возможность указать значение с плавающей точкой):");
double y0 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение начальной скорости снаряда (v0):");
int v0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение угла вылета снаряда из пушки в градусах:");
int a = Convert.ToInt32(Console.ReadLine());

const double g = 9.81;
double angle_in_radian = a * Math.PI / 180;

double vx0 = v0 * Math.Cos(angle_in_radian);
double vy0 = v0 * Math.Sin(angle_in_radian);

double t = 0;
double dt = 0.1;

while (true)
{
    double x = x0 + vx0 * t;
    double y = y0 + vy0 * t - (g * Math.Pow(t, 2)) / 2;
    if (y <= 0)
    {
        Console.WriteLine($"Снаряд упал в координатах: ({x}, 0)");
        break;
    }
    Console.WriteLine($"t = {t}, x = {x}, y = {y}.");
    t += dt;
}