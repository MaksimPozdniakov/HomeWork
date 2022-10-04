//Задача №1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input first number ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second numbers ");
int n2 = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if (n1 > n2)
{
    max = n1; 
    min = n2;
}
else
{
    max = n2; 
    min = n1;
}
Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);
*/

//Задача №2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Input first num ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second num ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third num ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if(n2 > max) max = n2;
if(n3 > max) max = n3;

Console.WriteLine("max = " + max);
*/

//Задача №3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("ДА");
}
else 
{
    Console.WriteLine("НЕТ");
}
*/

//Задача №4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());

int current;
if (number > 0)
{
    current = 1;
}
else
{
    current = number;
}
while (current <= number)
{
    if (current % 2 == 0)
    {
        Console.Write(current + " ");
    }

    current++;
}
*/
