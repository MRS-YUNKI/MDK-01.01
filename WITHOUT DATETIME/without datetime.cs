using System.Runtime.InteropServices;

string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
int[] days_in_months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
string[] days_of_week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
int start_year = 1990;
int start_day_of_week = 1;
int days_to_add = 2;

Console.Write("Введите количество месяцев: ");
int months_to_add = Convert.ToInt32(Console.ReadLine());

int current_year = start_year + months_to_add / 12;
int current_month = months_to_add % 12;

bool leap_year(int year)
{
    return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
}

if (leap_year(current_year))
{
    days_in_months[1] = 29;
}

int total_days = months_to_add * 30 + days_to_add;
int day_of_week = (start_day_of_week + 1 + days_to_add + total_days % 7) % 7;
int total_day = start_day_of_week + days_to_add;

Console.WriteLine($"День, месяц, год и день недели полученного года: {total_day} {months[current_month]} {current_year}, {days_of_week[day_of_week]}");
Console.WriteLine($"Полученный год является високосным или нет: {(leap_year(current_year) ? "Да" : "Нет")}");