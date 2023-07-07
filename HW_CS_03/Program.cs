
// Seminar 3



// Task 17.
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.
// x=34; y=-30 -> 4     ||      x=2; y=4-> 1        ||      x=-34; y=-30 -> 3

/*
int GetNumberOfQuarter(int X, int Y)
{
int result = 0;
if (X > 0 && Y > 0)
{
    result = 1;
}
else if (X < 0 && Y > 0)
{
    result = 2;
}
else if (X < 0 && Y < 0)
{
    result = 3;
}
else if (X > 0 && Y < 0)
{
    result = 4;
}
return result;
}

Console.Write("Enter a variable X: ");
int userX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a variable Y: ");
int userY = Convert.ToInt32(Console.ReadLine());

int quarter = GetNumberOfQuarter(userX, userY);
if (quarter > 0)
{
    Console.WriteLine($"Point [{userX} : {userY}] is in a quarter {quarter}");
}
else
{
    Console.WriteLine($"Point [{userX} : {userY}] is on the intersection of the planes");
}
*/



// Task 18
// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).


/*                                                                // Вариант полного написания метода VOID 
Console.Write("Enter number of quarter: ");
int number = Convert.ToInt32(Console.ReadLine());
                                                                    // метод VOID ничего не возвращает, 
void GetQuarter (int quarter)                                       // из него можно сразу вывести результат
{
if (quarter == 1)
{
    Console.WriteLine("X and Y > 0");
}
else if (quarter == 2)
{
    Console.WriteLine("X < 0 and Y > 0");
}
else if (quarter == 3)
{
    Console.WriteLine("X < 0 and Y < 0");
}
else if (quarter == 4)
{
    Console.WriteLine("X > 0 and Y < 0");
}
}
// int PointСoord = int (GetQuarter(number));
// Console.WriteLine($"Range of points in the quadrant {number} is {PointСoord}");
GetQuarter(number);
*/


/*
string QuadrantRange(int quadrant)                     // метод STRING
{
if (quadrant == 1) return "x > 0; y > 0";
else if (quadrant == 2) return "x < 0; y > 0";
else if (quadrant == 3) return "x < 0; y < 0";
else if (quadrant == 4) return "x > 0; y < 0";
else return "invalid quadrant";
}
Console.Write("Enter a quadrant number: ");
int quarter = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(QuadrantRange(quarter));
*/


/*                                                                   
void GetQuarter (int quarter)                          // метода VOID (компакт.вариант)                              
{
if (quarter == 1) Console.WriteLine("X and Y > 0");
else if (quarter == 2) Console.WriteLine("X < 0 and Y > 0");
else if (quarter == 3) Console.WriteLine("X < 0 and Y < 0");
else if (quarter == 4) Console.WriteLine("X > 0 and Y < 0");
else Console.WriteLine("invalid quadrant");
}
Console.Write("Enter number of quarter: ");
int number = Convert.ToInt32(Console.ReadLine());
GetQuarter(number);
*/


// Task 20
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09     ||    A (7,-5); B (1,-1) -> 7,21

/*
Console.Write("Enter x for first point: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y for first point: ");
int aY = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter x for second point: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y for second point: ");
int bY = Convert.ToInt32(Console.ReadLine());

int a = aY - bY;
int b = aX - bX;

double distance = Math.Sqrt(a * a + b * b);
Console.WriteLine(distance);
*/



// Task 22
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25           ||       2 -> 1,4


/*
Console.Write("Input number: ");                
int Num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int mult = 0;
if (Num > 0)
{
while (count < Num + 1)                         // через цикл while
{
    mult = count * count;
    count = count + 1;
    Console.Write($"{mult}, ");
}
}
else                                            // корректирока при введении отрицателього N
{
count = count * (-1);
while (count > Num - 1)
{
    mult = count * count;
    count = count - 1;
    Console.Write($"{mult}, ");
}
}
*/


/*
string Squares(int n)                           // решение через string  
{
    string squares = "1";
    if (n > 2)
    {
        for (int i = 2; i <= n; i++)            // через цикл for
        {
            squares = $"{squares} {i * i}";
        }
    }
    else                                        // отрицательное число N отрабатывает не корректно!
    {
        for (int i = 0; i >= n; i--)
        {
            squares = $"{squares} {i * i}";
        } 
    }
    return squares;                             // через string всегда return
}
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Squares(number));
*/


/*
Console.Clear();                                // строка очистки терминала перед запуском программы!
Console.WriteLine("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= n)
{
    Console.Write($"{Math.Pow(count, 2)}");     // функция "квадрат числа"
    if (count != n)                             // if и else здесь для корректного оформления строки вывода
    {                                           // (между цифр - ,  в конце - .)    ;     != строго
        Console.Write(", ");
    }
    else
        Console.Write(".");
    count++;
}
*/


// Homework 3


// Task 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет; 12821 -> да; 23432 -> да


/*
bool IsPolindrom(int N)
{
    int num = N;         // пришло       
    int turn = 0;        // переменная перевернутого числа        
    while (num > 9)
    {
        turn = turn + num % 10;  
        turn = turn * 10;         
        num = num / 10;           
    }
    turn = turn + num % 10;       
return N == turn;
}
Console.Write("Input a five-digit number: ");
int userNum = Convert.ToInt32(Console.ReadLine());
if(userNum < 100000) 
    {
    Console.WriteLine("This number is a palindrome - " + IsPolindrom(userNum));
    }
else 
Console.WriteLine("Repeat the entry. This is not a five-digit number");
*/



// Task 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));    
}
Console.WriteLine("Input the coordinates of the two points");
Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Distance between points {(Math.Round(Distance(x1, y1, z1, x2, y2, z2), 3))}");
*/




// Task 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


/*
void CubeNumbers(int N)
{
    int num = 1;
    while (num < N+1)
    {
        Console.WriteLine(num+" - "+num*num*num);
        num++;
    }
}
    Console.Write("Input N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    CubeNumbers(N);
*/
 

// Вариант со -> в одну строку
/*
void CubeNumbers(int N)
{
    int num = 1;
    while (num < N+1)
    {
        Console.Write(num*num*num+" - ");
        num++;
    }
}
    Console.Write("Input N: ");
    int N = Convert.ToInt32(Console.ReadLine());

    Console.Write(N+" ->  ");
    CubeNumbers(N);
*/