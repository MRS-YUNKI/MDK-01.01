Console.WriteLine("Введите значение x: ");
string x = Console.ReadLine();
Console.WriteLine("Введите систему счисления, в в которой задано x (от 2 до 9): ");
int q1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите систему счисления, в которую будет осуществлен перевод (от 2 до 9): ");
int q2 = int.Parse(Console.ReadLine());

if (q1 < 2 || q1 > 9 || q2 < 2 || q2 > 9) 
{
    Console.WriteLine("Диапозон от 2 до 9");
    return;
}

int value = Convert.ToInt32(x, q1);
string result = Convert.ToString(value, q2);

Console.WriteLine($"Число {x} в системе счисления {q1} равняется {result} в системе счисления {q2}.");