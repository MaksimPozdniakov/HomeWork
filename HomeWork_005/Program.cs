// Задача №1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] NewArray(int size)
{
    int[] Array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(100,999); 
    }
    Console.WriteLine();
    return Array;
}

void PrintMyArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    Console.Write(Array[i] + " ");
}

int PozitivNumbers(int[] Array)
{
    int count = 0;
    for(int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Imput numbers of array ");
int size = Convert.ToInt32(Console.ReadLine());
PrintMyArray(NewArray(size));

int[] myArray = NewArray(size);
int result = PozitivNumbers(myArray);

Console.WriteLine($"Pozitiv numbers is {result}");
*/

// Задача №2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] NewArray(int size)
{
    int[] Array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(2, 25);
    }
    Console.WriteLine();
    return Array;
}

void PrintMyArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    Console.Write(Array[i] + " ");
}

int SumNegativPozition(int[] Array)
{
    int result = 0;

    for(int i = 1; i < Array.Length; i += 2) 
    {   
        result = result + Array[i];
    }
    return result;
}

Console.Write("Input size array ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = NewArray(size);
Console.Write("Our array ");
PrintMyArray(myArray);

Console.WriteLine();

Console.WriteLine($"Result = {SumNegativPozition(myArray)}.");
*/

// Задача №3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] NewArray(int size)
{
    double[] Array = new double[size];

    for(int i = 0; i < size; i++)
    {
        // чтобы окроглить и выйти за пределы диапазона от 0 до 1.
        Array[i] = Math.Round((new Random().NextDouble() * 10), 2); // положительные значения
        //Array[i] = Math.Round((new Random().NextDouble() * (-10)), 2); // отрицательные значения
    }
    Console.WriteLine();
    return Array;
}

void PrintMyArray(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    Console.Write(Array[i] + " ");
}

double Division(double[] Array)
{
    double result = 0;

    double min = Array[0];
    double max = Array[0];

    for(int i = 0; i < Array.Length; i ++)
    {
        
        if(Array[i] > max)
        {
            max = Array[i];
        }
        if(Array[i] < min)
        {
            min = Array[i];
        }

        result = max - min;
    }
    return Math.Round(result,2);
}

Console.Write("Input size array ");
int size = Convert.ToInt32(Console.ReadLine());

double[] myArray = NewArray(size);
Console.Write("Our array ");
PrintMyArray(myArray);

Console.WriteLine();

Console.WriteLine($"Result = {Division(myArray)}.");
*/