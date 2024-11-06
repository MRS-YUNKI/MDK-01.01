Console.WriteLine("Введите количество месяцев: ");
int N = Convert.ToInt32(Console.ReadLine());

DateTime StartDate = new DateTime(1990, 1, 1);
DateTime ResultDate = StartDate.AddMonths(N).AddDays(2);

string NameOfMonth = ResultDate.ToString("MMMM");
string NameOfDay = ResultDate.ToString("dddd");
int Day = ResultDate.Day;
int Year = ResultDate.Year;
bool LeapYear = DateTime.IsLeapYear(Year);

Console.WriteLine($"День, месяц, год, день недели полученного года: {Day} {NameOfMonth} {Year}, {NameOfDay}");
Console.WriteLine($"Полученный год является високосным или нет: {(LeapYear ? "Да" : "Нет")}");