// таблица умножения
/*
void Table(int num)
{
    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            int result = j * i;
            Console.Write($"{i} * {j} = {result} \t");
        }
        Console.WriteLine();
    }
}

int num = 1;
Table(num);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
/*
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
/* 
int[,] CreateSpiralArray()
{
    Console.Write("Количество строк ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество столбцов ");
    int colums = Convert.ToInt32(Console.ReadLine());

    int[,] myArray = new int[rows,colums];

    for(int position = 0, value = 1; value <= rows * colums; position++)
    {
        for(int i = position, j = position; j < colums - position; j++)
        {
            myArray[i,j] = value;
            value++;
        }
        if(value > rows * colums) break;

        for(int i = position + 1, j = colums - position - 1; i < rows - position; i++)
        {
            myArray[i,j] = value;
            value++;
        }
        if(value > rows * colums) break;

        for(int i = rows - position - 1, j = colums - position - 2; j >= position; j--)
        {
            myArray[i,j] = value;
            value++;
        }
        if(value > rows * colums) break;

        for(int i = rows - position - 2, j = position; i > position; i--)
        {
            myArray[i,j] = value;
            value++;
        }
        if(value > rows * colums) break;
    }
    return myArray;
}

void ShowOurArray (int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            if (myArray[i,j] < 10)
            {
                Console.Write($"0{myArray[i,j]} ");
            }
            else 
            {
                Console.Write(myArray[i,j] + " ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = CreateSpiralArray();
ShowOurArray(array);
 */

 //Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/* 
int[,] CreateArray()
{
    int rows = 5;
    int colums = 5;
    int min = 1;
    int max = 9;

    int[,] myArray = new int[rows,colums];

    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i,j] = new Random().Next(min, max);
        }
    }
    return myArray;
}

void ShowMyArray(int[,] myArray)
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
    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j< myArray.GetLength(1); j++)
        {
            for(int k = j + 1; k < myArray.GetLength(1); k++)
            {
                if (myArray[i,k] > myArray[i,j])
                {
                    int temp = myArray[i,k];
                    myArray[i,k] = myArray[i,j];
                    myArray[i,j] = temp;
                }    
            }
        }
    }
}

int[,] myArray = CreateArray();
ShowMyArray(myArray);

Console.WriteLine();

SortArray(myArray);
ShowMyArray(myArray);
 */

//Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/* 
int[,] CreateArray()
{
    int rows = 5;
    int colums = 5;
    int min = 1;
    int max = 9;

    int[,] myArray = new int[rows,colums];

    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i,j] = new Random().Next(min, max + 1);
        }
    }
    return myArray;
}

void ShowMyArray(int[,] myArray)
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
    int numberString = 0;
    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            sum += myArray[i,j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");

        if(i == 0)
        {
            minSum = sum;
        }
        else if (sum < minSum)
        {
            minSum = sum;
            numberString = i;
        }
    }
    Console.WriteLine($"Строка {numberString + 1} с суммой {minSum}, является строкой с минимальной суммой эллементов");

}

int[,] myArray = CreateArray();
ShowMyArray(myArray);

Console.WriteLine();

Sum(myArray);
 */

 //Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/* 
int[,] CreateArray()
{
    int rows = 2;
    int colums = 2;
    int min = 1;
    int max = 9;

    int[,] myArray = new int[rows,colums];

    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i,j] = new Random().Next(min, max + 1);
        }
    }
    return myArray;
}

void ShowMyArray(int[,] myArray)
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

int[,] ResultMatrix(int[,] myArray1,int[,] myArray2)
{
    int[,] newArray = new int[myArray1.GetLength(0), myArray1.GetLength(1)];
    for(int i = 0; i < myArray1.GetLength(0); i++)
    {
        for(int j = 0; j < myArray1.GetLength(1); j++)
        {
            for(int k = 0; k < myArray1.GetLength(1); k++)
            {
                newArray[i,j] += myArray1[i,k] * myArray2[k,j];
            } 
        }
    }
    return newArray;  
}

int[,] firstMatrix = CreateArray();
int[,] secondMatrix = CreateArray();

ShowMyArray(firstMatrix);

Console.WriteLine();

ShowMyArray(secondMatrix);

Console.WriteLine();

int[,] newArray = ResultMatrix(firstMatrix,secondMatrix);
ShowMyArray(newArray);
 */
 // Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/* Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
/* 
int[,,] Array()
{
    int rows = 2;
    int colums = 2;
    int deep = 2;
    int min = 2;
    int max = 9;

int[,,] myArray = new int[rows,colums,deep];

    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            for(int k = 0; k < myArray.GetLength(2); k++)
            {
                myArray[i,j,k] = new Random().Next(min,max + 1);
            }
        }
    }
    return myArray;
}

void ShowArray(int[,,] myArray)
{
    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            for(int k = 0; k < myArray.GetLength(2); k++)
            {
                Console.Write($"{myArray[i,j,k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] myArray = Array();
ShowArray(myArray);
 */


int[] Array()
{
    int size = 40;
    int minValue = 1;
    int maxValue = 99;

    int[] myArray = new int[size];

    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue);
        
        for(int j = 0; j < myArray.Length; j++)
        {
            myArray[j] = new Random().Next(minValue, maxValue);
            
            {
                if(i != j)
                {
                    int temp = myArray[i];
                    myArray[i] = myArray[j];
                    myArray[j] = temp;
                }
            }
        }
    }
    return myArray;
}

void ShowArray(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
}

int[] myArray = Array();
ShowArray(myArray);