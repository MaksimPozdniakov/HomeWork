//Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
            myArray[i,j] = new Random().Next(min, max+1);
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
            for (int k = j + 1; k < myArray.GetLength(1); k++)
            {
                if (myArray[i, k] > myArray[i, j]) 
                {
                    int temp = myArray[i, k];
                    myArray[i, k] = myArray[i, j];
                    myArray[i, j] = temp;
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
//Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
            myArray[i,j] = new Random().Next(min, max+1);
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

// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
            myArray[i,j] = new Random().Next(min, max+1);
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

int [,] NewArray(int[,] myArray1, int[,] myArray2)
{
    int[,] newArray = new int[myArray1.GetLength(0), myArray1.GetLength(1)]; 

    for (int i = 0; i < myArray1.GetLength(0); i++)
        for (int j = 0; j < myArray1.GetLength(1); j++)
            for (int k = 0; k < myArray1.GetLength(1); k++)
            {
                newArray[i,j] = newArray[i,j] + myArray1[i,k] * myArray2[k,j];
            }
    return newArray;        
}

int[,] myArray1 = RandomArray(); // первая матрица
int[,] myArray2 = RandomArray(); // вторая матрица
ShowArray(myArray1);
Console.WriteLine();
ShowArray(myArray2);
Console.WriteLine();

int[,] result = NewArray(myArray1,myArray2);
ShowArray(result);
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/* Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
/*
int[] TwoDigitPositiveNumsArray()
{
    int[] myArray = Enumerable.Range(10, 90).ToArray(); // создается массив двузначных чисел
    
    for (int i = 0; i < myArray.Length; i++)
    {
        int j = new Random().Next(0, 90);
        if (j != i)
        {
            var temp = myArray[i];
            myArray[i] = myArray[j];
            myArray[j] = temp;
        }
    }
    return myArray;
}

int[,,] RandomArray(int[] myArray)
{
    Console.Write("Введите количество строк ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение глубины ");
    int depth = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine();

    int m = 0;

    int[,,] myArray3 = new int[rows, colums, depth];

    for(int i = 0; i < myArray3.GetLength(0); i++)
        for(int j = 0; j < myArray3.GetLength(1); j++)
            for(int k = 0; k < myArray3.GetLength(2); k++)
            {
                myArray3[i, j, k] = myArray[m];
                m++;
            }
    return myArray3;
}

void ShowArray(int[,,] myArray)
{
    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            for(int k = 0; k < myArray.GetLength(2); k++)
            {
               Console.Write(myArray[i,j,k] + " "); 
               Console.Write($"({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }   
}

int[] myArray = TwoDigitPositiveNumsArray();
int[,,] myArray3 = RandomArray(myArray);
ShowArray(myArray3);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/* Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] SpiralArrey()
{
    Console.Write("Введите количество строк ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов ");
    int colums = Convert.ToInt32(Console.ReadLine());
    
    int[,] mySpiralArrey = new int[rows, colums];
    for (int passage = 0, valueElements = 1; valueElements <= rows * colums; passage++)
    {
        for (int i = passage, j = passage; j < colums - passage; j++)
        {
            mySpiralArrey[i, j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * colums) break;
        for (int i = passage + 1, j = colums - passage - 1; i < rows - passage; i++)
        {
            mySpiralArrey[i, j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * colums) break;
        for (int i = rows - passage - 1, j = colums - passage - 2; j >= passage; j--)
        {
            mySpiralArrey[i, j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * colums) break;
        for (int i = rows - passage - 2, j = passage; i > passage; i--)
        {
            mySpiralArrey[i, j] = valueElements;
            valueElements++;
        }
    }
    return mySpiralArrey;
}

void ShowArray(int[,] myArray)
{
    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            if(myArray[i,j] < 10)
            {
               Console.Write("0" + myArray[i,j] + " "); 
            }
            else
            {
                Console.Write(myArray[i,j] + " "); 
            }

        }
        Console.WriteLine();
    }   
}

int[,] mySpiralArrey = SpiralArrey();

ShowArray(mySpiralArrey);
