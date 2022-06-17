// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());// ввод a
Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());// ввод b
Console.Write("Введите число c = ");
int c = Convert.ToInt32(Console.ReadLine());// ввод c

int max = a;
if (max<b) max = b;
if (max<c) max = c;
Console.Write("Максимальное из трёх введённых чисел max = " + max);