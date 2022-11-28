// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
/* Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2" 
*/

/*int N = int.Parse(Console.ReadLine());
for (int i = -N; i <= N; i++)
{
    Console.WriteLine(i);
}*/




//Первая домашка
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a > 5; b < 7 -> max = 7; a > 2 b < 10 -> max = 10; a > -9 b < -3 -> max = -3

Console.WriteLine("Ether number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ether number: ");
int b = int.Parse(Console.ReadLine());Console.WriteLine("Ether number: ");

if(a > b)
{
    Console.WriteLine($"{a} > {b}");
    Console.WriteLine($"max = {a}");
}
else
{
    Console.WriteLine($"{a} < {b}");
    Console.WriteLine($"max = {b}");
}

