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



/*
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
*/


/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 

Console.WriteLine("Ether number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ether number: ");
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());Console.WriteLine("Ether number: ");

int max = -1;
if (a == b && b == c){
    max = a;
    Console.WriteLine("Нечего сравнивать - все числа равны");
}else if (a == b){
    max = a;
    if (c > max){
        max = c;
	Console.WriteLine("Максимальное число - третье");
    } else {
	Console.WriteLine("Максимальные числа - первое и второе");
    }
}else if (a == c){
    max = a;
    if (b > max){
        max = b;
	Console.WriteLine("Максимальное число - второе");
    } else {
	Console.WriteLine("Максимальные числа - первое и третье");
    }
}else if (b == c){
    max = b;
    if (a > max){
        max = a;
	Console.WriteLine("Максимальное число - первое");
    } else {
	Console.WriteLine("Максимальные числа - второе и третье");
    }
}else{
    max = a;
    if (b > max){
        max = b;
    }
    if (c > max){
        max = c;
    }
if (max == a) Console.WriteLine("Максимальное число - первое");
if (max == b) Console.WriteLine("Максимальное число - второе");
if (max == c) Console.WriteLine("Максимальное число - третье");
}
Console.WriteLine(max);*/ 



/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

int module (int a){
    if (a >= 0) {
        return a;
    }
    else {
        return (a * (-1));
    }
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
if (number == 0){
    Console.WriteLine("Это ноль");
}else if ((module(number)%2) == 0){
    Console.WriteLine("Это число является четным");
}else{
Console.WriteLine("Это число является нечетным");
}