using System.Globalization;

Console.WriteLine("Введите количество месяцев: ");
int N = Convert.ToInt32(Console.ReadLine());

DateTime StartDate = new DateTime(1990, 1, 1);
DateTime ResultDate = StartDate.AddMonths(N).AddDays(2);

string NameOfMonth = ResultDate.ToString("MMMM", CultureInfo.InvariantCulture);
int Day = ResultDate.Day;
int Year = ResultDate.Year;
bool LeapYear = DateTime.IsLeapYear(Year);

Console.WriteLine($"День, месяц и год полученного года: {Day} {NameOfMonth} {Year}");
Console.WriteLine($"Полученный год является високосным или нет: {(LeapYear ? "Да" : "Нет")}");