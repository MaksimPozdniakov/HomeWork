// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] NewArray()
{
    Console.Write("Введите значение m ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение n ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[,] myArray = new double[n, m];

    for (int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            myArray[i,j] = Math.Round((new Random().NextDouble() * 10), 2);
        }
    }
    return myArray;
} 

void ShowArray(double[,] myArray)
{
    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write(myArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] myArray = NewArray();
ShowArray(myArray);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] NewArray()
{
    Console.Write("Введите кол-во строк ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of minValue ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of maxValue ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] myArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            myArray[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return myArray;
}

void ShowArray(int[,] myArray)
{
    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write(myArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void FindPozition(int[,] myArray)
{
    Console.Write("Введите индекс нужной строки ");
    int ourRow = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс нужного столбца ");
    int ourColum = Convert.ToInt32(Console.ReadLine());
*/
// через оператор "else if"
/*
    if (ourRow < 0 && ourColum < 0) Console.Write($"Элемента с индексами [{ourRow},{ourColum}] нет ");

    else if (ourRow < myArray.GetLength(0) && ourColum < myArray.GetLength(1)) Console.Write($"Наш элемент c индексами [{ourRow},{ourColum}] = {myArray[ourRow,ourColum]}");

    else  Console.Write($"Элемента с индексами [{ourRow},{ourColum}] нет ");
*/
// без оператора "else if"
/*
    if ((ourRow >= 0 && ourRow < myArray.GetLength(0)) && (ourColum >= 0 && ourColum < myArray.GetLength(1)))
    {
        Console.Write($"Наш элемент c индексами [{ourRow},{ourColum}] = {myArray[ourRow,ourColum]}");
    }

    else
    {
        Console.Write($"Элемента с индексами [{ourRow},{ourColum}] нет ");
    }
}
*/
/*
int[,] myArray = NewArray();
ShowArray(myArray);

Console.WriteLine();

FindPozition(myArray);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] NewArray()
{
    Console.Write("Введите кол-во строк ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of minValue ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of maxValue ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] myArray = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            myArray[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return myArray;
}

void ShowArray(int[,] myArray)
{
    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write(myArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[] Result(int[,] myArray)
{

    double[] newArray = new double[myArray.GetLength(1)];
    
    
    for(int j = 0; j < myArray.GetLength(1); j++)
    {
        double sum = 0;

        for(int i = 0; i < myArray.GetLength(0); i++)
        {
            sum = sum + myArray[i,j];
            newArray[j] = sum/myArray.GetLength(0);
        }
    }
    return newArray;  
}

void ShowNewArray(double[] newArray)
{
    Console.Write(" ");
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
}


int[,] myArray = NewArray();
ShowArray(myArray);

Console.WriteLine();

double[] result = Result(myArray);
ShowNewArray(result);
*/