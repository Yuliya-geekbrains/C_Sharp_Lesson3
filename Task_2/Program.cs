//  Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве
// А (3,6); В (2,1) -> 5,09
// А (7,-5); В (1,-1) -> 7,21

Console.Write("Введите координату x точки A: ");
int ax = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату y точки A: ");
int ay = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату x точки B: ");
int bx = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату x точки B: ");
int by = int.Parse(Console.ReadLine()!);

double AB = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
Console.WriteLine($"Расстояние между точками А и В = {AB:f2}");






