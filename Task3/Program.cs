// Написать программу, которая будет выдавать название дня недели по заданному номеру (от 1 до 7).

Console.WriteLine("Введите порядкой номер дня недели (от 1 до 7): ");
string n = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;
switch (n)
{
    case "1":
    Console.Write("Понедельник");
    break;

    case "2":
    Console.Write("Вторник");
    break;

    case "3":
    Console.Write("Среда");
    break;

    case "4":
    Console.Write("Четверг");
    break;
        
    case "5":
    Console.Write("Пятница");
    break;
        
    case "6":
    Console.Write("Суббота");
    break;
        
    case "7":
    Console.Write("Воскресенье");
    break;
        
    default:
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Выполнен неверный ввод, повторите попытку!");
    break;
}