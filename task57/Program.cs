// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9


Console.WriteLine("Введите число строк и число столбцов через Enter ");
int m = Convert.ToInt32(Console.ReadLine());//число строк
int n = Convert.ToInt32(Console.ReadLine());//число столбцов
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine("_____________");
ItemCounter(matrix);


int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// void ItemCounter(int[,] matrix)
// {
//     int num0 = 0;
//     int num1 = 0;
//     int num2 = 0;
//     int num3 = 0;
//     int num4 = 0;
//     int num5 = 0;
//     int num6 = 0;
//     int num7 = 0;
//     int num8 = 0;
//     int num9 = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] == 0)
//             {
//                 num0 = num0 + 1;
//             }
//             if (matrix[i, j] == 1)
//             {
//                 num1 = num1 + 1;
//             }
//             if (matrix[i, j] == 2)
//             {
//                 num2 = num2 + 1;
//             }
//             if (matrix[i, j] == 3)
//             {
//                 num3 = num3 + 1;
//             }
//             if (matrix[i, j] == 4)
//             {
//                 num4 = num4 + 1;
//             }
//             if (matrix[i, j] == 5)
//             {
//                 num5 = num5 + 1;
//             }
//             if (matrix[i, j] == 6)
//             {
//                 num6 = num6 + 1;
//             }
//             if (matrix[i, j] == 7)
//             {
//                 num7 = num7 + 1;
//             }
//             if (matrix[i, j] == 8)
//             {
//                 num8 = num8 + 1;
//             }
//             if (matrix[i, j] == 9)
//             {
//                 num9 = num9 + 1;
//             }
//         }
//     }
//     Console.Write($"0 встречается {num0} раза");
//     Console.WriteLine();
//     Console.Write($"1 встречается {num1} раза");
//     Console.WriteLine();
//     Console.Write($"2 встречается {num2} раза");
//     Console.WriteLine();
//     Console.Write($"3 встречается {num3} раза");
//     Console.WriteLine();
//     Console.Write($"4 встречается {num4} раза");
//     Console.WriteLine();
//     Console.Write($"5 встречается {num5} раза");
//     Console.WriteLine();
//     Console.Write($"6 встречается {num6} раза");
//     Console.WriteLine();
//     Console.Write($"7 встречается {num7} раза");
//     Console.WriteLine();
//     Console.Write($"8 встречается {num8} раза");
//     Console.WriteLine();
//     Console.Write($"9 встречается {num9} раза");
//     Console.WriteLine();
// }

void ItemCounter(int[,] matrix)
{
    int[] repeats = new int[10];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            repeats[matrix[i, j]]++;
        }
    }
    for (int i = 0; i < repeats.Length; i++)
    {
    Console.Write($"{i} встречается {repeats[i]} раза");
    Console.WriteLine();
    }
}
