// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("Создадим рандомный трехмерных массив с неповторяющимися числами");
int n = 2;
int[,,] matrix = FillMatrix(n, n, n);
PrintMatrix(matrix);


int[,,] FillMatrix(int rowsCount, int columnsCount, int zCount, int leftRange = 0, int rightRange = 100)
{
    int[,,] matrix = new int[rowsCount, columnsCount, zCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rand.Next(leftRange, rightRange);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == matrix[i, j, k])
            {
                matrix[i, j, k] = matrix[i, j, k] + 1;
            }
                Console.Write(matrix[i, j, k] + " ");
                Console.Write($"({i}, {j}, {k}); ");
            }
            Console.WriteLine();
        }
    }
}

