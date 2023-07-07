
// Seminar 3

// Task 17.
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.
// Валерия Geek Brains: x=34; y=-30 -> 4
// x=2; y=4-> 1
// x=-34; y=-30 -> 3

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