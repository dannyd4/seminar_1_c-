// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());// ввод a
Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());// ввод b

if (a == b)// проверка на равенство
{   
    Console.WriteLine("Введённые числа равны: " + a +" = " + b);
}
if (a>b)
{   
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
};
if (a<b)
{  
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);
};

