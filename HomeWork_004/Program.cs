// Задача №1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double TwoNumbers(int a, int b)
{
    double result;
    
    result = Math.Pow(a,b);
    return result;
}

Console.Write("Input first number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int b = Convert.ToInt32(Console.ReadLine());

double result = TwoNumbers(a,b);
Console.WriteLine(result);
*/
// Задача №2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNumbers(int num)
{
   int result = 0;
   
   if (num < 0)
   {
        num = num * -1;
   }
   
   while (num > 0)
   {
        result = result + num % 10;
        num = num / 10;
   }
   
   return result;
}

Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int result = SumNumbers(num);
Console.WriteLine(result);
*/
// Задача №3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
}

void ShowArray(int[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
         Console.Write(newArray[i] + " ");
}

Console.Write("Input  number: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Specify the lower limit of the array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Specify the upper limit of the array: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/
