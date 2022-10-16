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