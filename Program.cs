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

int[,] GetMatrix(int m, int n, int minValue, int maxValue)  // Генерация двумерного массива
{
    int[,] matrix = new int[m, n];
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            matrix[row, column] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] inArray)  // Вывод массива на консоль
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            Console.Write($"{inArray[row, column]}\t ");
        }
        Console.WriteLine();
    }
}

void GetMatrixCal(int[,] matrix)  // Получение индексов элемента и проверка границ массива
{
    Console.Write("Введите номер строки элемента массива: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Введите номер стобца элемента массива: ");
    int column = int.Parse(Console.ReadLine()!);
    if(row > matrix.GetLength(0) || column > matrix.GetLength(1)) Console.WriteLine("Такого элемента массива нет ");
    else Console.WriteLine(matrix[row, column]);
}

void Main()  // Административная функция
{
Console.Clear();
int[,] ourArray = GetMatrix(3, 4, 0, 50);
PrintArray(ourArray);
GetMatrixCal(ourArray);
}

Main();