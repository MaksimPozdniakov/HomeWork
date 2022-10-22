// Задача №1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// без массива
/*
int Amount(int amountNum)
{
    int count = 0;

    for(int i = 1; i <= amountNum; i++)
    {
        Console.Write($"Введите {i} число ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0) count++;
    }
    return count;
}
Console.Write("Какое количество чисел будем проверять? ");
int amount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" Количество чисел больше нуля = {Amount(amount)}");
*/

// с массивом
/*
int[] CreateArray()
{
    Console.Write("Сколько чисел будем проверять? ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Минимальный эллемент массива ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальный эллемент массива ");
    int max = Convert.ToInt32(Console.ReadLine());
    
    int[] myArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(min, max); 
    }
    return myArray;
}

void ShowArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.WriteLine();
}

int PozitivNumbers(int[] myArray)
{
    int count = 0;

    for(int i = 0; i <= myArray.Length; i++)
    {
        if(i > 0) count++;
    }
    return count;
}

int[] myArray = CreateArray();
ShowArray(myArray);

Console.WriteLine();

int result = PozitivNumbers(myArray);

Console.Write($"Количество положительных чисел = {result}");
*/

// Задача №2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// примеры b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void IntersectionPoint()
{
    Console.Write("Введите значение b1 ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k1 ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение b2 ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k2 ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    
    double x = (b1 - b2) / (k2 - k1);
    double y = ((k2 * b1) - (k1 * b2)) / (k2 - k1);

    if (k1 == k2)
    {
        Console.Write("Прямые параллельны и отрезки пересекаться не могут. Решение задачи прекращаем ");
    }

    else
    {
        Console.Write($"Наша точка пересечения двух прямых {x} , {y} ");
    }
}

IntersectionPoint();
*/