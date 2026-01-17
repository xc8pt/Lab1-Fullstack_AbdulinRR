using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;


Console.Write("Напишите свой ФИО: ");
string? name = Console.ReadLine();
DateTime now = DateTime.Now;
Console.WriteLine($"Привет, {name}");
Console.WriteLine(now.DayOfWeek);
while (true)
{
    Console.Write("Хотите продолжить?(Да/Нет): ");
    string? input = Console.ReadLine();
    switch (input)
    {
        case "Да":
            Console.WriteLine("Нет");
            break;
        case "Нет":
            Console.WriteLine("Да");
            break;
        
    }
}





