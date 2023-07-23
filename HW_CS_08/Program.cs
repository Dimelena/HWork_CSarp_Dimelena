
// Seminar 8



// Task 53
// 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:              В итоге получается вот такой массив:
// 1 4 7 2                              8 4 2 4
// 5 9 2 3                              5 9 2 3
// 8 4 2 4                              1 4 7 2



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
    Console.Write($"[ ]\t");                                        // !!! обратный слеш
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

int[,] randomArray = GetRandom2DArray(3, 4, 10);
Print2DArray(randomArray);