// Seminar 5



// Task 32.
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
// равна 29, сумма отрицательных равна -20.


/*
int [] getRandomArray(int length, int deviation)
{
    int [] result = new int[length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    return result;
}

void printArray (int[] arrayToPrint)
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

int sumElementsOfArray(int [] arrayToCalculate, int multiply)
{
    int result = 0;
    for(int i = 0; i < arrayToCalculate.Length; i++)
    {
    if (arrayToCalculate[i] * multiply > 0)
        {
            result += arrayToCalculate[i];
        }
    }
    return result;
}

int [] randomArray = getRandomArray(12, 9);
printArray(randomArray);
Console.WriteLine();

int positiveSumOfArray = sumElementsOfArray(randomArray, 1);
int negativeSumOfArray = sumElementsOfArray(randomArray, -1);
Console.WriteLine($"Сумма положительных чисел в массиве равна {positiveSumOfArray}, сумма отрицательных чисел в массиве равна {negativeSumOfArray}");
*/




// HomeWork_Seminar_05




// Task 34.
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


/*
int[] FillArray(int size, int minValue, int maxValue)       
{
    int[] array = new int[size];                                                              
    for (int i = 0; i < size; i++)                                  
        array[i] = new Random().Next(minValue, maxValue + 1);      
    return array;  
}

// void WriteArray(int[] array)                                        
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)     
//     Console.Write(array[i] + ", ");                                  
    
//     Console.WriteLine("]");
// }


void PrintArray (int[] arrayToPrint)
{
    Console.ForegroundColor = ConsoleColor.Blue;
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



int QuanEvenNum(int[] array)    
{ 
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0) sum++;
    }
    return sum;
}

Console.Write("Input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

if (min < 100 || max < 100)
    Console.WriteLine("Repeat the entry (Your number is not a three-digit number).");
else 
{
    int[] myArray = FillArray(Length, min, max);      
    PrintArray(myArray);
    int sum = QuanEvenNum(myArray);
    Console.WriteLine($"Number of even numbers in the array is {sum}");
}
*/



// Task 36.
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int[] FillArray(int size, int minValue, int maxValue)       
{
    int[] array = new int[size];                                    
                                                                    
    for (int i = 0; i < size; i++)                                  
        array[i] = new Random().Next(minValue, maxValue + 1);      
    return array;    
}

// void WriteArray(int[] array)                                        
// {
//     for (int i = 0; i < array.Length; i++)     
//     Console.Write(array[i] + " ");                                  

    
//     Console.WriteLine();
// }


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



int SumOddPosNum(int[] array)    
{ 
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i %2 == 1) 
            sum = array[i] + sum;
    }
    return sum;
}

Console.Write("Input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] myArray = FillArray(Length, min, max);      
PrintArray(myArray);
int sum = SumOddPosNum(myArray);

Console.WriteLine($"Sum of odd index numbers is {sum}");
*/



// Task 38.
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


/*
double [] FillArray(int size)
{
    double [] array1 = new double [size];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = Math.Round(new Random().NextDouble(),2) + new Random().Next(50);
    }
    return  array1;

}


void PrintArray (double[] arrayToPrint)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[");
    for(int i = 0; i < arrayToPrint.Length; i++)
        {
            Console.Write(arrayToPrint[i]);
            if (i != arrayToPrint.Length - 1)
                {
                    Console.Write("; ");
                }
        }
    Console.WriteLine("]");
    Console.WriteLine("--------------------------");
    Console.ForegroundColor = ConsoleColor.White;
}



void FindMaxMin(double [] array)
{
    double max = array[0];
    double min = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]> max) max= array [i];
        if (array[i]< min) min= array [i];
    }
    Console.Write($"The largest number is {max}; ");
    Console.Write($"the smallest number is {min}; ");
    Console.WriteLine($"number difference is {max - min}");

}

Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = FillArray(size);
PrintArray(array);
FindMaxMin(array);
*/