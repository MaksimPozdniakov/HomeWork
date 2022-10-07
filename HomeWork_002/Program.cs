//Зажача №1. Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
/*
int RandomDigit(int num)
{
    int result;
    int ed = num % 100;
    
    result = ed / 10;

    return result;
}
Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine()); 
int result = RandomDigit(number);
Console.WriteLine($"Digit {number} is {result}");
*/

//Задача №2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int Digit(int num)
{
    int result;
    
    if (num < 100)
    {
        result = -1;
    }
    
    else if (num >= 100 && num < 1000)
    {
        num = num % 10;
        result = num;
    }
    
    else 
    {
        while (num >= 1000)
        num = num % 100;
        result = num / 10;
    }

    return result;
}
Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Digit(number);
if (result > -1)
{
    Console.WriteLine($"Digit {number} is {result}");
}
else
{
    Console.WriteLine("No third digit");
}
*/