
// Seminar 8




// Task 53
// 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

 
// второй вариант, поти также, но temp задан немного по-другому

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


//      // ВТОРОЙ ВАРИАНТ (метод void с ~ 1.12.00')
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


//      // ТРЕТИЙ ВАРИАНТ (в методе void операторы try - catch, с ~ 1.14.00')
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