
// Seminar 8




// Task 53
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:              В итоге получается вот такой массив:
// 1 4 7 2                              8 4 2 4
// 5 9 2 3                              5 9 2 3
// 8 4 2 4                              1 4 7 2


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
            Console.Write($"[{i}]\t");телеграмм вебматпрофи
            
            for (int j = 0; j < arrayToPrint.GetLength(1); j++)
            {
                Console.Write(arrayToPrint[i,j] + "\t");
            }
            Console.WriteLine();
        }
}


void Replace(int[,] array)
{
int temp = 0;                                               // temp задан через переменную
    for (int i = 0; i < array.GetLength(1); i++)
        {
        temp = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = array[0, i];
        array[0, i] = temp;
        }
}

 
// второй вариант, почти также, но temp задан немного по-другому

// void ReplaceFirstAndLastElement(int[,] matrix)
// {
//     int len = matrix.GetLength(0) - 1;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//         int temp = matrix[0, i];                            // temp задан сразу в теле цикла
//         matrix[0, i] = matrix[len, i];
//         matrix[len, i] = temp;
//         }
}


int[,] randomArray = GetRandom2DArray(3, 4, 10);
Print2DArray(randomArray);
Console.WriteLine();
Replace(randomArray);
Print2DArray(randomArray);
*/



// Task 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:                 В итоге получается вот такой массив:
// 1 4 7 2                                 1 5 8 5
// 5 9 2 3                                 4 9 4 2
// 8 4 2 4                                 7 2 2 6
// 5 2 6 7                                 2 3 4 7


// 44.20' - в массиве можно обращаться к последнему эл-ту, как к отрицательному индексу 
// (-1, например), а в матрице нельзя
// 54.20' - если матрица не квадратная (размер столбцов не равно размеру строк), 
// то проверка на соответсвие (!= ->  не равен)
// ~ 59' - тк void ничего не выводит (а нам надо вывести либо сообщение, 
// либо, матрицу (цифровое выражение)), надо подумать, как хитро вывести
// 1.09.00' - в int-методе  после первого return метод перестает работать (поэтому сначала 
// проверяем на несоблюдение условия), в этом  случае матрица заполнена 0 (выведется матрица нулей)
// ~ 1.12.00' - другое решение: void 
// ~ 1.14.00' - другое решение: try - catch


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

int[,] ReplaceRowsToColumns(int[,] array)
{
    int[,] matrix = new int [array.GetLength(0), array.GetLength(1)]; // <- инициализация new массива д/изменения

    if (array.GetLength(0) != array.GetLength(1))               // !!!  (!= ->  не равен) 
                                                                // если матрица не квадратная (размер столбцов не равно размеру строк), 
        {                                                       // то проверка на соответсвие 
        return matrix;                                          
        }                               // в int-методе  после первого return метод перестает работать (поэтому сначала 
                                        // проверяем на несоблюдение условия), в этом  случае матрица заполнена 0 (выведется матрица нулей)
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    matrix [j, i] = array [i, j];               // !!! замена старого массива array на новый matrix
                }
            }
            return matrix;
}


//      // ВТОРОЙ ВАРИАНТ (в методе void операторы try - catch, с ~ 1.12.00')
// void ReplaceRowsToColumns(int[,] matrix)                    
// {
//     try
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//             {
//             for (int j = 0 + i; j < matrix.GetLength(1); j++)
//                 {
//                     int temp = matrix[j, i];
//                     matrix[j, i] = matrix[i, j];
//                     matrix[i, j] = temp;
//                 }
//             }
//             Print2DArray(matrix);                              // !!! испльзуем метод в методе
//     }
//     catch (System.IndexOutOfRangeException)
//     {
//         Console.WriteLine("Can't replace rows and columns");
//     }
// }


//      // ТРЕТИЙ ВАРИАНТ (метод void - catch, с ~ 1.14.00')
// void ReplaceRowsToColumns(int[,] matrix)
// {
//     if (matrix.GetLength(0) != matrix.GetLength(1))
//         {
//             Console.WriteLine("Can't replace rows and columns");
//         }
//     else
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0 + i; j < matrix.GetLength(1); j++)   // важный момент увеличение индекса j на i (int j = 0 + i)
//             {
//                 int temp = matrix[j, i];
//                 matrix[j, i] = matrix[i, j];
//                 matrix[i, j] = temp;
//             }
//         }
//         Print2DArray(matrix);                                    // !!! испльзуем метод в методе
//     }
// }


int[,] randomArray = GetRandom2DArray(5, 5, 10);
Print2DArray(randomArray);
Console.WriteLine();
int[,] replaceArray = ReplaceRowsToColumns(randomArray);
Print2DArray(replaceArray);
// ReplaceRowsToColumns(randomArray);  // вместо двух предыдущих строк для ВТОРОГО и ТРЕТЬЕГО ВАРИАНТА
*/




// Task 57. 
// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных
// { 1, 9, 9, 0, 2, 8, 0, 9 }           1, 2, 3
// 0 встречается 2 раза                 4, 6, 1
// 1 встречается 1 раз                  2, 1, 6
// 2 встречается 1 раз                  1 встречается 3 раза
// 8 встречается 1 раз                  2 встречается 2 раза
// 9 встречается 3 раза                 3 встречается 1 раз
//                                      4 встречается 1 раз
//                                      6 встречается 2 раза


// ЭТА ЗАДАЧА РЕШАЕТСЯ ЧЕРЕЗ СЛОВАРЬ

// ~ 1.21.00' - начало
// ~ 1.37.00' - объясняет эту задачу


/*
int[,] GetRandom2DArray (int rowNumber, int colNumber, int start, int end)     // deviation
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
         for (int j = 0; j < colNumber; j++)
         {
            result[i,j] = new Random().Next(start, end+1);
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


void CountElementsInMatrix(int[,] matrix, Dictionary<int, int> counter)
{
    for (int i = 0; i < matrix.GetLength(0); i++)           // пока i меньше, чем количество строк идет цикл
    {
        for (int j = 0; j < matrix.GetLength(1); j++)       // пока j меньше, чем количество строк идет цикл (в первом цикле)
        {
            if (counter.ContainsKey(matrix[i, j]))          // условие: если у нас в counter есть ключ "matrix[i, j]"
            {
            counter[matrix[i, j]]++;                        // тогда мы число с эти ключом прибавляем еще 1 раз
            }
            else
            {
            counter.Add(matrix[i, j], 1);   // ? в элементе с этим ключом она встретилась 1 раз, поэтому записываем его 1 раз?
            }
        }
    }
}

Dictionary<int, int> counter = new Dictionary<int, int>();      //<- инициализация нового словаря с названием "counter",  
                                                                // словарь принимает в себя ключи (<ключ, значение>),
int[,] matrix = GetRandom2DArray(4, 5, 0, 9);                   // в словаре все элементы вызываются не по индексу, а по ключу
Print2DArray(matrix);                                           // в словарь нельзя добавить эл-т, который в нем уже есть, он неповторяемый
                                                                // поэтому можем считать отдельно, например, 3-ки отдельно, 6-ки отдельно и тд
CountElementsInMatrix(matrix, counter);                         
Console.WriteLine(); 
    // теперь у нас есть словарь, мы знаем сколько и каких цифр у нас есть, как получить значения из этого словаря, если мы обращаемся по ключу, а не по индексу?
    // цикл foreach позволяет обратиться по ключу
foreach (int key in counter.Keys)
{
    Console.WriteLine($"There are {counter[key]} {key}'s");     // counter[key] -> сколько раз встреается key (этот ключ (цифра)) 
}                                                               // дженерики это контейнеры, которые могут хранить в себе любой тип
*/                                                              // словарь относится к дженерикам (листы, словари..)




// HomeWork_Seminar_08


// Task 54

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:         В итоге получается вот такой массив:
// 1 4 7 2                         7 4 2 1
// 5 9 2 3                         9 5 3 2
// 8 4 2 4                         8 4 4 2




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


void FromMinToMax(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j+1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i,j] < matrix[i,k])
                {
                    int temp = matrix[i,j];
                    matrix[i,j] = matrix[i,k];
                    matrix[i,k] = temp;
                }
            }
        }
    }
}


Console.WriteLine();
FromMinToMax(randomArray);
Print2DArray(randomArray);
Console.WriteLine();
*/



/* // пузырьковая сортировка от меньшего к большему в одномерном массиве
int[] FillArray(int size, int minValue, int maxValue)       
{
    int[] array = new int[size];                                    
                                                                    
    for (int i = 0; i < size; i++)                                  
        array[i] = new Random().Next(minValue, maxValue + 1);      
    return array;    
}


void PrintArray (int[] arrayToPrint)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[");
    for(int i = 0; i < arrayToPrint.Length; i++)
        {
            Console.Write(arrayToPrint[i]);
            if (i != arrayToPrint.Length - 1)
                {
                    Console.Write(", ");
                }
        }
    Console.WriteLine("]");
    Console.WriteLine("--------------------------");
    Console.ForegroundColor = ConsoleColor.White;
}


Console.Write("Input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] FromMinToMax(int[] array)    
{ 
    int temp = array[0];    
    {
        for (int p = 0; p < array.Length; p++)              // поэлементный вывод для печати
            {
                for (int i = 0; i < array.Length - 1; i++)  // поэлементный вывод для сортировки 
                {
                    if (array[i] > array[i+1])
                    {
                        temp = array[i]; 
                        array[i] = array[i+1];
                        array[i+1] = temp;
                    }             
                }        
            } 
        return array;
    }
}


int[] myArray = FillArray(Length, min, max);      
PrintArray(myArray);
Console.WriteLine();
int[] newArray = FromMinToMax(myArray);
PrintArray(FromMinToMax(newArray));
Console.WriteLine();
*/



//  // для задачи 54_не ругается, но и не выводит
// 
// int[,] FromMinToMax(int[,] myArray)
// {
//     //int[,] result = new int[myArray.GetLength(0), myArray.GetLength(1)];
//     int line = myArray.GetLength(0);
//     int column = myArray.GetLength(1);
//     int temp = myArray[0,0];
 
//     { 
//         for (int p = 0; p < myArray.GetLength(0)-1; p++)          //поэлементный вывод для печати строк
//         {  
//             for (int p1 = 0; p1 < myArray.GetLength(1)-1; p1++)
//             {
//                 for (int j = 0; j < column; j++)
//                 {
//                     for (int i = 0; i < line ; i++)
//                     {                  
//                         if (myArray[i,j+1] > myArray[i,j])
//                                 {
//                                     temp = myArray[i,j]; 
//                                     myArray[i,j] = myArray[i,j+1];
//                                     myArray[i,j+1] = temp;
//                                 }  
//                     }            
//                 }
//             }
//         }
//         return myArray; 
//     }
// }

// int[,] newarray = FromMinToMax(randomArray);
// //FromMinToMax(randomArray);
// Print2DArray(newarray);
// Console.WriteLine();




// Task 56.

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:          Программа считает сумму элементов в каждой строке
// 1 4 7 2                          и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

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


       
int SumElementRows(int[,] myArray, int i)
{
        int lineSum = myArray[i,0];
        for (int j = 1; j < myArray.GetLength(1); j++)
        {                  
            lineSum += myArray[i,j];
        }      
        
        Console.Write($"Sum of elements of line {i+1} is: ");
        Console.ForegroundColor = ConsoleColor.Yellow;  
        Console.WriteLine(lineSum);
        Console.ForegroundColor = ConsoleColor.White;
        
        return lineSum;           
    
    
}


int sumRows = SumElementRows(randomArray, 0);
int minSumRows = 0;



for (int i = 1; i < randomArray.GetLength(0); i++)
{
    int temp = SumElementRows(randomArray, i);
    if (sumRows > temp)
        {
            sumRows = temp;
            minSumRows = i;
        }
}



Console.WriteLine();
Console.Write($"String with minimum sum of elements is ");
Console.ForegroundColor = ConsoleColor.Yellow;  
Console.WriteLine(minSumRows+1);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
*/




//       // нахождение суммы строки (полный цикл, в этой задаче не применила)
//
// void SumRows(int[,] myArray)
// {
//     int line = myArray.GetLength(0);
//     int column = myArray.GetLength(1);
    
//     for (int i = 0; i < line; i++)
//     {
//         int lineSum = 0;
//         for (int j = 0; j < column; j++)
//         {                  
//             lineSum += myArray[i,j];
//         }
//         Console.Write($"Sum of elements of line {i} is: ");
//         Console.ForegroundColor = ConsoleColor.Yellow;  
//         Console.WriteLine(lineSum);
//         Console.ForegroundColor = ConsoleColor.White;
//     }   
// }
// SumRows(randomArray);
// Console.WriteLine();




// Task 58
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:           ||          Результирующая матрица будет:
// 2 4 | 3 4                           ||          18 20
// 3 2 | 3 3                           ||          15 18

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
int[,] ferstArray = GetRandom2DArray(m,n,range);
Print2DArray(ferstArray);
Console.WriteLine();



Console.WriteLine();
int[,] secondArray = GetRandom2DArray(m,n,range);
Print2DArray(secondArray);
Console.WriteLine();

Console.WriteLine();


int[,] sumMatrix = new int[m, n];
for (int i = 0; i < ferstArray.GetLength(0); i++)
{
    
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        sumMatrix[i, j] = 0;
        for (int k = 0; k < ferstArray.GetLength(1); k++)
        {
            sumMatrix[i, j] += ferstArray[i, k] * secondArray[k, j];
        }
    }
}


Print2DArray(sumMatrix);
Console.WriteLine();
*/








//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//     int[,] array = {{ 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9}};




