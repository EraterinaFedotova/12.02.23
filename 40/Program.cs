//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();
Console.Write("Введите стороны треугольника через пробел: ");

string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int a = int.Parse(st[0]), b = int.Parse(st[1]), c = int.Parse(st[2]);

if ((a + b) > c && (a + c) > b && (b + c) > a)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}