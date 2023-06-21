// Напишите программу, которая по заданному номеру честверти
// показывает диапазон возможных координат точек в этой четверти (х и у).

int number = new Random().Next(1, 5); // номер четверти

switch (number)
{
    case 1:
    {
        Console.WriteLine($"В чнтверти {number} диапазон возможных координат: x > 0; y > 0");
        break;
    }
    case 2:
    {
        Console.WriteLine($"В чнтверти {number} диапазон возможных координат: x < 0; y > 0");
        break;
    }
    case 3:
    {
        Console.WriteLine($"В чнтверти {number} диапазон возможных координат: x < 0; y < 0");
        break;
    }
    case 4:
    {
        Console.WriteLine($"В чнтверти {number} диапазон возможных координат: x > 0; y < 0");
        break;
    }
    default:
    {
        Console.WriteLine("Такой четсверти не существует.");
        break;
    }
}


