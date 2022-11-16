// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
/*
void Numbers(int n)
{
    Console.Write(n + " ");
    if (n > 1) Numbers (n - 1);
}

Console.Write("Input number ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {n} -> ");
Numbers(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
/*
int SumElements(int m, int n)
{
    if (m < n) return SumElements(m + 1, n) + m; // в случае ввода положительных чисел
    if (m > n) return SumElements(m - 1, n) + m; // в случае ввода отрицательных чисел
    else return m;
}

Console.Write("Input number M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {M}; N = {N} -> {SumElements(M,N)}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
/*
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0) return Akkerman(m - 1,Akkerman(m, n - 1));
    else return 0;
}

Console.Write("Input number m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number n ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($" m = {m}, n = {n} -> {Akkerman(m,n)}");
*/