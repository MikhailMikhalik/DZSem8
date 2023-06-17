// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// C = A · B =  
// 2	4
// 3	2
//   ·  
// 3	4
// 3	3
//   =  
// 18	20
// 15	18
 
// Компоненты матрицы С вычисляются следующим образом:

// c11 = a11 · b11 + a12 · b21 = 2 · 3 + 4 · 3 = 6 + 12 = 18

// c12 = a11 · b12 + a12 · b22 = 2 · 4 + 4 · 3 = 8 + 12 = 20

// c21 = a21 · b11 + a22 · b21 = 3 · 3 + 2 · 3 = 9 + 6 = 15

// c22 = a21 · b12 + a22 · b22 = 3 · 4 + 2 · 3 = 12 + 6 = 18


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 10);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void  MultiplicationMatrix(int[,] result, int[,] matrix1, int[,] matrix2)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
}

Console.Clear();
Console.Write("Введите размер массива через пробел: ");

int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
while (size[0] != size[1])
{
    Console.Write("Вы ошиблись!\nВведите размер массива: ");
    size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
}
int[,] matrix1 = new int[size[0], size[1]];
int[,] matrix2 = new int[size[0], size[1]];
int[,] result = new int[size[0], size[1]];
Console.WriteLine("Начальный массив 1: ");
InputMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine("Начальный массив 2: ");
InputMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine("Результат произведения 2-х массивов: ");
MultiplicationMatrix(result, matrix1, matrix2);
PrintMatrix(result);