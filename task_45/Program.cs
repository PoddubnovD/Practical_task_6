//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write("{0}", arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write("   ");
        }
    }
    Console.WriteLine(" ]");
}

void FillArray(int[] arrayToFill, int diviation)
{
    for (int i = 0; i < arrayToFill.Length; i++)
        arrayToFill[i] = new Random().Next(-diviation, diviation + 1);
}

void CopyArray(int[] arrayToCopy, int[] arrayToFill)
{
    for (int i = 0; i < arrayToCopy.Length; i++)
        arrayToFill[i] = arrayToCopy[i];
}


int arraySize = 0;

arraySize = new Random().Next(5, 15);
int[] firstArray = new int[arraySize];
int[] secondArray = new int[arraySize];
FillArray(firstArray, 15);
CopyArray(firstArray, secondArray);
Console.Clear();

Console.WriteLine("Первый массив:");
PrintArray(firstArray);
Console.WriteLine();
Console.WriteLine("Копия первого:");
PrintArray(secondArray);
Console.ResetColor();