Console.Write("Укажите свой год рождения:");
int Year = Convert.ToInt32(Console.ReadLine());
string Animal = "";
string Element = "";
switch (Year % 12)
{
    case 0: Animal = "Обезьяна";
        break;
    case 1:
        Animal = "Петух";
        break;
    case 2:
        Animal = "Собака";
        break;
    case 3:
        Animal = "Свинья";
        break;
    case 4:
        Animal = "Крыса";
        break;
    case 5:
        Animal = "Бык";
        break;
    case 6:
        Animal = "Тигр";
        break;
    case 7:
        Animal = "Заяц";
        break;
    case 8:
        Animal = "Дракон";
        break;
    case 9:
        Animal = "Змея";
        break;
    case 10:
        Animal = "Лошадь";
        break;
    case 11:
        Animal = "Овца";
        break;
}
switch ((Year - 4) % 10)
{
    case 0: Element = "Дерево";
        break;
    case 1:
        Element = "Дерево";
        break;
    case 2:
        Element = "Огонь";
        break;
    case 3:
        Element = "Огонь";
        break;
    case 4:
        Element = "Земля";
        break;
    case 5:
        Element = "Земля";
        break;
    case 6:
        Element = "Металл";
        break;
    case 7:
        Element = "Металл";
        break;
    case 8:
        Element = "Вода";
        break;
    case 9:
        Element = "Вода";
        break;
}

Console.WriteLine($"Ваше животное по китайскому календарю: {Animal}.");
Console.WriteLine($"Ваша стихия по китайскому календарю: {Element}.");
