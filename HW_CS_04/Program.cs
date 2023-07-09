
// Seminar 4




// Task 24
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28      ||      4 -> 10     ||      8 -> 36

/*
int GetSumOfSeries (int from, int to)
{
int result = 0;
                                    // можно записать по-другому: (for(var i = from; i <= to; i++))
for(int i = from; i <= to; i++)     // var (неявная типизация) - распознает наш аргумент, каким он придет     
{                                   // в нашем случае - int, если распознование не требуется, var не заводить
result += i;                        // result = result + i
}
return result;                      // в функции возврат результата (return) находится внутри функции
}

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = GetSumOfSeries(1, number);    // т.к. в нашем случае по условии первая переменная нам известна (from = 1)
                                        // сразу записываем первым аргументом 1; если бы по условию необходимо было бы считать
                                        // от др.числа, то использовали бы обе переменные и пользователь вводил бы два числа
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}"); 
*/



// Task 26          НЕ ПРОВЕРЕНА
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3     ||      78 -> 2     ||      89126 -> 5


/*
int AmountOfDigits(int num)
{
int amount = 0;
while (num > 0)
{
num /= 10; // num = num / 10;
amount++; // amount = amount + 1;
}
return amount;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе {number} -> {AmountOfDigits(number)}");
*/


// Task 28          НЕ ПРОВЕРЕНА

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24      ||      5 -> 120


/*
int Base(int from, int to)
{
int product = 1;
for (int i = from; i <= to; i++)
{
product *= i;
}
return product;
}

Console.WriteLine("Введите ваше число:");
int value = Convert.ToInt32(Console.ReadLine());
int result= Base(1,value);
Console.WriteLine($"Ответ: {result}");
*/


// Task 30          НЕ ПРОВЕРЕНА
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


/*
int[] FillArray(int size)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(0, 2);
}
return array;
}
int[] array = FillArray(8);

// for (int i = 0; i < size; i++)
// {
// System.Console.Write($"{array[i]} ");
// }

foreach(int i in array)
{
System.Console.Write($"{i} ");
}

System.Console.WriteLine();
*/


//   Вар II

/*
void PrintArray(int[] array)
{
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i]);
if (i < array.Length - 1)
{
Console.Write(", ");
}
}
Console.Write("]");
}
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(2);
}

PrintArray(array);
*/


// Вар III
/*
void fillRandomArray(int[] array)
{
Random rnd = new Random();
for(int i = 0; i < array.Length; i++)
array[i] = rnd.Next(0, 2);
}

void printArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
Console.Write(array[i] + " ");
}

int[] randomArray = new int[8];
fillRandomArray(randomArray);
printArray(randomArray);
*/




// HomeWork_Seminar_04

/*
// Task 25
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// 3, 5 -> 243 (3⁵)   
// 2, 4 -> 16  




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