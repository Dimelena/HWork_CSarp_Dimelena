// Seminar 7


// Task 46.

// Задайте двумерный массив размером m × n, заполненный случайными целыми числами.
// m = 3, n = 4.    ||   -1 4 8 19   
//                        5 -2 33 -2
//                       -77 3 8 1

// Двумерный массив - массив массивов



/*
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

int[,] randomArray = GetRandom2DArray(5, 4,10);
Print2DArray(randomArray);
*/



// Task 48
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4   ||    0 1 2 3
//                      1 2 3 4
//                      2 3 4 5


/*
int[,] Get2DArray (int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
         for (int j = 0; j < colNumber; j++)
         {
            result[i,j] = i + j;
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


int[,] array = Get2DArray (3, 4);
Print2DArray(array);
*/


// Task 49. 
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты. Например, изначально массив выглядел вот так:

    
// 1 4 7 2          Новый массив будет выглядеть вот так:
// 5 9 2 3          1 4 7 2
// 8 4 2 4          5 81 2 9
//                  8 4 2 4


/*
int[,] Get2DArray (int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
         for (int j = 0; j < colNumber; j++)
         {
            result[i,j] = i + j;
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


int[,] numbers = Get2DArray (3, 4);
Print2DArray(numbers);                              // распечатали изначально заданную матрицу (numbers)
Console.WriteLine();

void ChangeMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            array[i,j] = array[i,j]*array[i,j];
        }
    }
}

ChangeMatrix(numbers);                              // задаем матрицу (numbers) в методе, которую должны изменить;
Print2DArray(numbers);                              // во втором случае Print2DArray(numbers) распечатает 
                                                    // уже измененную методом ChangeMatrix матрицу
*/


// Task 51
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// с индексами (0,0); (1;1) и т.д. Например, задан массив:  1 4 7 2
//                                                          5 9 2 3
//                                                          8 4 2 4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12


/*
int[,] Get2DArray (int rowNumber, int colNumber, int start, int end)    // !!! в данном случае - 4 переменные
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
         for (int j = 0; j < colNumber; j++)
         {
            result[i,j] = i + j;
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

int SumOfDiagonalElements(int[,] matrix)
{
    int sumOfDiagonalElements = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
            if (i == j) 
                sumOfDiagonalElements += matrix[i, j];
            }
        }
    return sumOfDiagonalElements;            
}

int[,] numbers = Get2DArray(5, 4, 1, 10);
Print2DArray(numbers); 
Console.WriteLine($"Sum of diagonal elements = {SumOfDiagonalElements(numbers)}");
*/






// HomeWork_Seminar_07






// Task 47.
// Задайте двумерный массив размером m × n, заполненный случайными вещественными числами. m = 3, n = 4.
// 0,5   7     -2    -0,2
// 1    -3,3    8    -9,9
// 8     7,8   -7,1   9


/*
double[,] GetRandom2DArray (int rowNumber, int colNumber, int deviation)
{
    double[,] result = new double[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
         for (int j = 0; j < colNumber; j++)
         {
            result[i,j] = Math.Round(new Random().Next(-deviation, deviation+1) + new Random().NextDouble(),2);
         }
    }
    return result;
}


void Print2DArray(double[,] arrayToPrint)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"[ ]\t");                                        
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"[{i}]\t");
        }
        
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        for (int i = 0; i < arrayToPrint.GetLength(0); i++)
        {           
            Console.Write($"[{i}]\t");
            for (int j = 0; j < arrayToPrint.GetLength(1); j++)
            {                 
                Console.Write(arrayToPrint[i,j] + "\t");
            }
            Console.WriteLine();
            
        }
        Console.ForegroundColor = ConsoleColor.White;
}

Console.WriteLine();
Console.Write("Input the number of rows of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns of array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the range of the array: ");
int range = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[,] randomArray = GetRandom2DArray(m,n,range);
Print2DArray(randomArray);
Console.WriteLine();
*/




// Task 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


/*
int[,] GetRandom2DArray (int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
         for (int j = 0; j < colNumber; j++)
         {
            result[i,j] = new Random().Next(-deviation,deviation+1);
         }
    }
    return result;
}


void Print2DArray(int[,] arrayToPrint)
{   Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"[ ]\t");                                        
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
        {
            Console.Write($"[{i}]\t");
        }
        Console.ForegroundColor = ConsoleColor.Blue;
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
        Console.ForegroundColor = ConsoleColor.White;
}

Console.WriteLine();
Console.Write("Input the number of rows of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns of array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the range of the array: ");
int range = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Input the row number of element: ");
int RowNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the column number of element: ");
int ColumnNum = Convert.ToInt32(Console.ReadLine());


Console.WriteLine();
int[,] randomArray = GetRandom2DArray(m,n,range);
Print2DArray(randomArray);
Console.WriteLine();


int FoundElement(int[,]myArray, int Row, int Column)
{
    int foundElement = myArray [0,0];                               
    for (int i = 0; i < myArray.GetLength(0); i++)
        {
        for (int j = 0; j < myArray.GetLength(1); j++)
            {
            if (i == Row && j == Column) 
                foundElement = myArray[i, j];  
            else if(i < Row && j < Column)
                foundElement = 0;              
            }           
        }     
    return foundElement;
}


int N = FoundElement(randomArray, RowNum, ColumnNum); 
if (N == 0)
Console.Write($"There's no element at position here [{RowNum}, {ColumnNum}] -> ");
else
Console.Write($"The element at position [{RowNum}, {ColumnNum}] has the value of ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(FoundElement(randomArray, RowNum, ColumnNum));
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
*/




// Task 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// 1 4 7 2         Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// 5 9 2 3
// 8 4 2 4


/*
int[,] GetRandom2DArray (int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
         for (int j = 0; j < colNumber; j++)
         {
            result[i,j] = new Random().Next(deviation+1);
         }
    }
    return result;
}


void Print2DArray(int[,] arrayToPrint)
{   Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"[ ]\t");                                        
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
        {
            Console.Write($"[{i}]\t");
        }
        Console.ForegroundColor = ConsoleColor.Blue;
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
        Console.ForegroundColor = ConsoleColor.White;
}


Console.WriteLine();
Console.Write("Input the number of rows of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns of array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the range of the array: ");
int range = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


Console.WriteLine();
int[,] randomArray = GetRandom2DArray(m,n,range);
Print2DArray(randomArray);
Console.WriteLine();


void ColumnAverage(int[,] myArray)
{
    int column = myArray.GetLength(0);
    int line = myArray.GetLength(1);

    for (int j = 0; j < line; j++)
    {
        double columnAvg = 0;
        for (int i = 0; i < column; i++)
        {                  
            columnAvg += myArray[i,j];
        }
        columnAvg = Math.Round(columnAvg / column, 2);

        Console.Write($"Average {j} column is: ");
        Console.ForegroundColor = ConsoleColor.Yellow;  
        Console.WriteLine(columnAvg);
        Console.ForegroundColor = ConsoleColor.White;
    }
    
}


ColumnAverage(randomArray);
Console.WriteLine(); 
*/


