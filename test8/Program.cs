// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число N > 1 = ");
int N = Convert.ToInt32(Console.ReadLine());// ввод N
int i = 2;
if (N <= 1)
{   
    Console.Write("N должно быть больше 1");
}
else 
{   
    Console.Write("Ряд чётных чисел из дапазона (1;N] = ");
    while (i<=N)
    {   
        Console.Write(i + " ");
        i+=2;
    }

}