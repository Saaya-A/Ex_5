using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Год: ");
        int a = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 12; i++)
        {
            DateTime b = new DateTime(a, i, DateTime.DaysInMonth(a, i));
            int c = b.Day - (7 + (int)b.DayOfWeek - 4) % 7;
            Console.WriteLine($"{b.Month} месяц: Последний четверг - {c} числа.");
        }
    }

}