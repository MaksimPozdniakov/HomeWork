// Задача №1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrom(int num)
{
    int firstNum = num / 10000;
    int lastNum = num % 10;
   
    
    if(num < 10000 | num > 99999)
    {
        Console.WriteLine("Данное число не является пятизначным ");
    }
    
    else
    {
        if (firstNum == lastNum)
        {
            firstNum = num / 1000 % 10;
            lastNum = num % 100 / 10;
            {
                if (firstNum == lastNum)
                {
                    Console.WriteLine("Данное число является палиндромом ");
                }
                else
                {
                    Console.WriteLine("Данное число не является палиндромом ");
                }
            }
            
            
        }
        else
        {
            Console.WriteLine("Данное число не является палиндромом ");
        }
            
        
    }
}

Console.Write("Input number ");
int a = Convert.ToInt32(Console.ReadLine());
Palindrom(a);
*/
// Задача №2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Rastoynie(double xA, double xB, double xC, double yA, double yB, double yC)
{
    double abc;

    abc = Math.Sqrt(Math.Pow(xA-yA,2) + Math.Pow(xB-yB,2) + Math.Pow(xC-yC,2));
    return Math.Round(abc, 2);
}
Console.Write("Input xA ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xB ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xC ");
double xC = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yA ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yB ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yC ");
double yC = Convert.ToDouble(Console.ReadLine());
Console.Write(Rastoynie(xA, xB, xC, yA, yB, yC));
*/
// Задача №3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
int TablCubs(int num)
{
    int current;
    
    if (num > 0)
    {
        current = 1;
    }   
    
    else
    {
        current = num;
    }
    
    while (current <= num)
    {
        Console.Write(Math.Pow(current, 3) + " ");
       
        current++;
    }
    return current;
}

Console.Write("Input number ");
int a = Convert.ToInt32(Console.ReadLine());
TablCubs(a);
*/

