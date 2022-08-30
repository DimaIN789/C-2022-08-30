// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.WriteLine("Введите число строк и число столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = FillMatrix1(n, n);
PrintMatrix1(matrix1);
int[,] matrix2 = FillMatrix2(n, n);
PrintMatrix2(matrix2);
MultiplicationMatrix(matrix1);



int[,] FillMatrix1(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix1 = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix1;
}

void PrintMatrix1(int[,] matrix)
{
    Console.WriteLine("Первая матрица");
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write(matrix1[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("_____________");
}

int[,] FillMatrix2(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix2 = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix2;
}

void PrintMatrix2(int[,] matrix)
{
    Console.WriteLine("Вторая матрица");
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write(matrix2[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("_____________");
}

void MultiplicationMatrix(int[,] matrix)
{
    Console.WriteLine("Произведение двух матриц");
    int[,] rematrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rematrix[i, j] = matrix1[i, j] * matrix2[i, j];
            Console.Write(rematrix[i, j] + " ");
        }
        Console.WriteLine();
    }

}

