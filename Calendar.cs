Console.Write("Укажите свою дату рождения (день.месяц): ");
string Date = Console.ReadLine();
string[] DayAndMonth = Date.Split('.');
int day = int.Parse(DayAndMonth[0]);
int month = int.Parse(DayAndMonth[1]);
switch (month)
{
    case 1:
        if (day <= 20)
        {
            Console.WriteLine("Ваш знак зодиака Козерог");
        }
        else
        {
            Console.WriteLine("Ваш знак зодиака Водолей");
        }
        break;
    case 2:
        if (day <= 20)
        {
            Console.WriteLine("Ваш знак зодиака Водолей");
        }
        else
        {
            Console.WriteLine("Ваш знак зодиака Рыбы");
        }
        break;
    case 3:
        if (day <= 20)
        {
            Console.WriteLine("Ваш знак зодиака Рыбы");
        }
        else
        {
            Console.WriteLine("Ваш знак зодиака Овен");
        }
        break;
    case 4:
        if (day <= 20)
        {
            Console.WriteLine("Ваш знак зодиака Овен");
        }
        else
        {
            Console.WriteLine("Ваш знак зодиака Телец");
        }
        break;
    case 5:
        if (day <= 20)
        {
            Console.WriteLine("Ваш знак зодиака Телец");
        }
        else
        {
            Console.WriteLine("Ваш знак зодиака Близнецы");
        }
        break;
    case 6:
        if (day <= 21)
        {
            Console.WriteLine("Ваш знак зодиака Близнецы");
        }
        else
        {
            Console.WriteLine("Ваш знак зодиака Рак");
        }
        break;
    case 7:
        if (day <= 22)
        {
            Console.WriteLine("Ваш знак зодиака Рак");
        }
        else
        {
            Console.WriteLine("Ваш знак зодиака Лев");
        }
        break;
    case 8:
        if (day <= 23)
        {
            Console.WriteLine("Ваш знак зодиака Лев");
        }
        else
        {
            Console.WriteLine("Ваш знак зодиака Дева");
        }
        break;
    case 9:
        if (day <= 23)
        {
            Console.WriteLine("Ваш знак зодиака Дева");
        }
        else
        {
            Console.WriteLine("Ваш знак зодиака Весы");
        }
        break;
    case 10:
        if (day <= 23)
        {
            Console.WriteLine("Ваш знак зодиака Весы");
        }
        else
        {
            Console.WriteLine("Ваш знак зодиака Скорпион");
        }
        break;
    case 11:
        if (day <= 22)
        {
            Console.WriteLine("Ваш знак зодиака Скорпион");
        }
        else
        {
            Console.WriteLine("Ваш знак зодиака Стрелец");
        }
        break;
    case 12:
        if (day <= 21)
        {
            Console.WriteLine("Ваш знак зодиака Стрелец");
        }
        else
        {
            Console.WriteLine("Ваш знак зодиака Козерог");
        }
        break;
}