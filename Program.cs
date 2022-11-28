// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
/* Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2" 
*/

int N = int.Parse(Console.ReadLine());
for (int i = -N; i <= N; i++)
{
    Console.WriteLine(i);
}
