// Задача №1. Составить таблицу умножения.
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

/* 
 int[] Array()
{
    int size = 90;
    int min = 1;
    int max = 99;

    int[] array = new int[size];

    bool alreadyThere; 
    int i = 0;

    while(i < size)
    {
        alreadyThere = false;
        int newRandomValue = new Random().Next(min, max + 1);

        for(int j = 0; j < i; j++)
        {
            if (array[j] == newRandomValue)
            {
                alreadyThere = true;
                break;
            }
        }
        
        if (!alreadyThere)
        {
            array[i] = newRandomValue;
            i++;
        }
        
    }
    
    return array;
}

void Show(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] myArray = Array();
Show(myArray);
  */

/* 
int[] Array()
{
    int[] array = {89, 93, 26, 6, 28, 43, 20, 15, 90, 92, 97, 58, 33, 17, 44, 77, 5, 83, 72, 80, 55, 7, 46, 49, 68, 11, 79, 40, 88, 50, 66, 47, 37, 56, 39, 86, 21, 36, 57, 38, 59, 30, 
                   69, 3, 82, 12, 2, 74, 61, 48, 99, 19, 81, 76, 29, 87, 65, 32, 22, 25, 73, 95, 51, 71, 34, 35, 60, 94, 75, 63, 13, 24, 78, 41, 84, 18, 9, 14, 62, 45, 42, 1, 52, 70, 
                   98, 54, 16, 67, 53, 10};

    return array;
}

void Show(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void Sort(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        for(int j = 0; j < array.Length; j++)
        {
            if(array[j] > array[i])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

int[] array = Array();

Sort(array);
Show(array);
 */
