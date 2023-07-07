

// HomeWork_Seminar_04


// Task 25
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// 3, 5 -> 243 (3⁵)   
// 2, 4 -> 16  



/*
int InputRequest(string input)
{
    Console.Write(input);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}




bool ValidateNumber(int number)
{
    if (number < 0)
    {
        System.Console.WriteLine("Repeat the entry. Input a positive Power Number ");
        return false;    
    }
    return true;
}




int Power(int powerN, int N)
{
    int power = 1;
    for (int i = 0; i < N; i++)
    {
        power *= powerN;
    }
    return power;
}




int powerN = InputRequest("Input a number: ");
int N = InputRequest("Input a positive Power Number: ");

if (ValidateNumber(N))
System.Console.WriteLine ($"The number {powerN} to the power of {N} is {Power(powerN, N)}");
*/





// Task 27
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



/*
int InputRequest(string input)
{
    Console.Write(input);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}




int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    } 
    return result;
}





int number = InputRequest("Input a positive number: ");
System.Console.WriteLine($"The sum of the digits in the number {number} is {SumAllDigit(number)}");
*/
 



// Task 29
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



// int InputText(string se)
// {
//     System.Console.WriteLine(se);
//     string readInput = Console.ReadLine();
//     int result = int.Parse(readInput);
//     return result;
// }




/*
int InputRequest(string input)
{
    Console.Write(input);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}




int [] RandAr(int size, int minN, int maxN)
{
    int [] array = new int [size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array [i] = random.Next(minN, maxN + 1);
    }
    return array;
}




void PrintAr(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length - 1]}]");
}




int size = InputRequest ("Input the number of elements in the array: ");
int minN = InputRequest ("Input the smallest number of the array: ");
int maxN = InputRequest ("Input the largest number of the array: ");
int [] myarray = RandAr(size, minN, maxN);

System.Console.Write($"Array of random numbers of a given range  ->  "); PrintAr(myarray);
*/