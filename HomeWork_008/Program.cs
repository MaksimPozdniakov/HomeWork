//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] RandomArray()
{
    Console.Write("Введите количество строк ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] myArray = new int[rows, colums];

    for(int i = 0; i < myArray.GetLength(0); i++)
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i,j] = new Random().Next(min, max);
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

void SortArray(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(0); k++)
            {
                if (myArray[i, j] >= myArray[i, k]) 
                {
                    int temp = myArray[i, j];
                    myArray[i, j] = myArray[i, k];
                    myArray[i, k] = temp;
                }
            }
        }
    }
}

int[,] myArray = RandomArray();
ShowArray(myArray);

Console.WriteLine();

SortArray(myArray);
ShowArray(myArray);
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] RandomArray()
{
    Console.Write("Введите количество строк ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] myArray = new int[rows, colums];

    for(int i = 0; i < myArray.GetLength(0); i++)
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i,j] = new Random().Next(min, max);
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

void Sum(int[,] myArray)
{
    int minSum = 0;
    int numberOfString = 0;

    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        int sum = 0;

        for(int j = 0; j < myArray.GetLength(1); j++)
        {
           sum = sum + myArray[i,j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        
        if (i == 0)
        {
            minSum = sum;
        }
        else if (sum < minSum)
        {
            minSum = sum;
            numberOfString = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов равна {numberOfString + 1}. ");
}

int[,] myArray = RandomArray();
ShowArray(myArray);

Sum(myArray);
*/