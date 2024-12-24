Console.Write("Введите координаты пушки по оси X (есть возможность указать значение с плавающей точкой: ");
double x0 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты пушки по оси Y (есть возможность указать значение с плавающей точкой): ");
double y0 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение начальной скорости снаряда (v0): ");
int v0 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение угла вылета снаряда из пушки в градусах: ");
int a = Convert.ToInt32(Console.ReadLine());

const double g = 9.81;
double angle_in_radian = a * Math.PI / 180;

double vx0 = v0 * Math.Cos(angle_in_radian);
double vy0 = v0 * Math.Sin(angle_in_radian);
double t_max = vy0 / g;
double h_max = v0 * Math.Sin(angle_in_radian) * t_max - ((g * Math.Pow(t_max, 2)) / 2);

double t = 0;
double dt = 0.1;

StreamWriter file = new StreamWriter("C:\\Users\\prdb\\Desktop\\Demo\\Sch\\MDKMDK\\TRAINING\\OUTPUT.txt");
file.WriteLine("Таблица значений:");
file.WriteLine("t\t\t\t\t\tx\t\t\t\t\ty");
file.WriteLine("________________________________________________________________________________________________________________________");
while (true)
{
    double x = x0 + vx0 * t;
    double y = y0 + vy0 * t - ((g * Math.Pow(t, 2)) / 2);

    if (y <= 0)
    {
        file.WriteLine($"Снаряд упал в координатах ({x}, 0).");
        break;
    }
    file.WriteLine($"t = {t}\t\t\t\t\tx = {x}\t\t\t\t\ty = {y}");
    t += dt;
}
file.Close();
