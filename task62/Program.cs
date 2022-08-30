// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



Console.WriteLine("Заполним спирально массив 4 на 4. Введите начальное число ");
int m = Convert.ToInt32(Console.ReadLine());
int n = 4;
int[,] matrix = FillMatrix[n, n];
PrintMatrix(matrix);

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
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i, j] = matrix[1, 1])
            {
                matrix[1, 1] = m;
            }
        }
        {

        }



        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
}

