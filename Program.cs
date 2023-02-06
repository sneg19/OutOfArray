/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

/*
1. Создать двумерный массив;
2. Принять позиции элемента в массиве;
3. Вернуть значение этого элемента массива / указать что его нет.
*/

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

bool UserInput(int[,] InMatrix, int indexX, int indexY)
{
    for (int i = 0; i < InMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < InMatrix.GetLength(1); j++)
        {
            if (InMatrix[i, j] == InMatrix[indexX, indexY] ) return true;
        }
    }
    return false;
}


Console.WriteLine("Введите первую координату элемента массива: ");
int indexX = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите вторую координату элемента массива: ");
int indexY = int.Parse(Console.ReadLine()!);

int[,] ourArray = GetMatrix(3, 4, -10, 10);
bool condition = UserInput(ourArray, indexX, indexY);
PrintArray(ourArray);
if(condition == true)
 {
    Console.WriteLine($"{ourArray[indexX, indexY]} такой элемент присутствует в массиве");
 }
 else
 {
    Console.WriteLine($"Такого элемента в массиве нет");
 }
