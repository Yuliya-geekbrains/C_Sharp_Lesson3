// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу квадратов чисел

// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= N; i++)
{
   int sqr = Convert.ToInt32(Math.Pow(i, 2));
   Console.WriteLine($"{sqr}"); 
}
