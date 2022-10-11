//Зажача №1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
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
//Задача №3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Первый вариант:
/*
bool DateNumber(int num)
{
    bool result;
    if(num == 6 | num == 7)
    {
        result = true;
    }
    else
    {
        result = false;
    }
    return result;
}

Console.Write("Enter a number for the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine()); 
bool result = DateNumber(number);  

if(result)
{
    Console.Write($"Yes, {number} day of the week is a holiday!  ");
}
else if (number < 1 | number > 7)
{
    Console.Write("There are only 7 days in a week, enter the correct number!");
}
else
{
    Console.Write($"No, {number} day of the week is not a holiday! ");
}
*/

// Второй вариант:
/*
void DateNumber(int num)
{
   if(num > 5 && num < 8) Console.WriteLine("This day of the week is a holiday!");
   if(num < 1 | num > 7) Console.WriteLine("There are only 7 days in a week, enter the correct number!");
   if(num >= 1 && num <= 5) Console.WriteLine("This day of the week is not a holiday!");
}

Console.Write("Enter the date ");
int a = Convert.ToInt32(Console.ReadLine());
DateNumber(a);
*/