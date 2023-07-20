// Seminar 7


// Task 01.

// Задайте двумерный массив размером m × n, заполненный случайными целыми числами.
// m = 3, n = 4.    ||   -1 4 8 19   
//                        5 -2 33 -2
//                       -77 3 8 1

// Двумерный массив - массив массивов



/*   ???
int[,] CreateAndFillMatrix(int rows, int columns, int start, int end)
{
int[,] matrix = new int[rows, columns];
for (int i = 0; i < rows; i++)
for (int j = 0; j < columns; j++)
matrix[i, j] = new Random().Next(start, end + 1);
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write('[');
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (j != matrix.GetLength(1) - 1)
Console.Write($"{matrix[i, j]}, ");
else Console.Write(matrix[i, j]);
}
Console.WriteLine(']');
}
}

int[,] matrix = CreateAndFillMatrix(4, 5, 1, 14);
PrintMatrix(matrix);
*/


/*  ???
void PrintMatrix(int[,] matrix)
{
Console.Write($"[ ]\t");
for (int i = 0; i < matrix.GetLength(1); i++)
Console.Write($"[{i}]\t");
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write($"[{i}]\t");
for (int j = 0; j < matrix.GetLength(1); j++)
Console.Write(matrix[i, j] + "\t");
Console.WriteLine();
}
}
*/




int[,] GetRandom2DArray (int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
         for (int j = 0; j < colNumber; j++)
         {
            result[i,j] = new Random().Next(-deviation, deviation+1);
         }
    }
    return result;
}


void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
        {
            Console.Write($"[{i}]\t");
        }
        Console.WriteLine();
        for (int i = 0; i < arrayToPrint.GetLength(0); i++)
        {
            Console.Write($"[{i}]\t");
            for (int j = 0; j < arrayToPrint.GetLength(1); j++)
            {
                Console.Write(arrayToPrint[i,j] + "\t");
            }
            Console.WriteLine();
        }
}

int[,] randomArray = GetRandom2DArray(5, 4,10);
Print2DArray(randomArray);