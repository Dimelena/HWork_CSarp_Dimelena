


// HomeWork_Seminar_06



// Task 41.
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2        ||      1, -7, 567, 89, 223-> 3



/*
int Message (string message)                 // ввод числа с консоли
{
    Console.Write(message);
    string text = Console.ReadLine();
    int num = Convert.ToInt32(text);

    return num;
}


int[] ClientInputArray (int size)                // клиентское заполнение массива
{
    int[] clientArray =  new int[size];
    for (int i = 0; i < clientArray.Length; i++)
    {
        clientArray[i] = Message ($"  Input {i + 1} element: ");
    }
    return clientArray;
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
                    Console.Write("; ");
                }
        }
    Console.WriteLine("]");
    Console.WriteLine("***");
    Console.ForegroundColor = ConsoleColor.White;
}


int CountPosNum (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > 0)
       count++;
    }
    return count;
}


Console.WriteLine();
int legth = Message ("Input the number of elements -> ");
int[] array;
array = ClientInputArray (legth);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.Write("The count of numbers is more than 0 -> ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(CountPosNum (array));
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
*/



// Task 43.
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



/*
const int k = 0;
const int b = 1;
const int X_coord = 0;
const int Y_coord = 1;
const int line1 = 1;
const int line2 = 2;


double[] lineData1 = InputLine(line1);
double[] lineData2 = InputLine(line2);


if (PointOfIntersection (lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.WriteLine();
    Console.Write($"Point of intersection of two points is ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"({coord[X_coord]}; {coord[Y_coord]})");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
}

double Message (string message)                 
{
    Console.Write(message);
    string text = Console.ReadLine();
    double num = Convert.ToDouble(text);

    return num;
}


double[] InputLine(int aboutLine)                      // ввод коэфициентов для прямых   
{
    double[] lineData = new double [2];
    Console.WriteLine();
    lineData [k] = Message ($"Input the slope of the line {aboutLine} -> "); 
    lineData [b] = Message ($"Input the free coefficient of the line {aboutLine} -> "); 
    return lineData;
}


double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double [2];;
    coord[X_coord] = Math.Round((lineData1[b] - lineData2[b]) / (lineData2[k] - lineData1[k]),2);
    coord[Y_coord] = Math.Round(lineData1[b] * coord[X_coord] + lineData1[b],2);
    return coord;
}
 
bool PointOfIntersection (double[] lineData1, double[] lineData2)
{
    if (lineData1[k] == lineData2[k])
    {
        if (lineData1[b] == lineData2[b])
        {
            Console.WriteLine();
            Console.WriteLine("The lines match");
             Console.WriteLine();
            return false;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("The lines are parallel");
            Console.WriteLine();
            return false;
        }
    }
    return true;
}
*/


