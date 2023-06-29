// Task 10
// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.


/*
Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int SecondDigit = num / 10 % 10;  
if (num < 100 || num > 1000)
    Console.WriteLine("Repeat the entry (Your number is not a three-digit number).");
else 
Console.WriteLine("Second digit of number is " + SecondDigit);
*/



// Task 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.Через строку решать нельзя.


/*
Console.Write("Input a number: ");
int Usnum = Convert.ToInt32(Console.ReadLine());
int num = Usnum;
if (num < 100)
    Console.WriteLine("There is no third digit in number " + num);
else
{ 
    while (num > 1000)
        {
            num /=10;
        }
        int ThirdDigit = num % 10;
        Console.WriteLine($"The third digit of the number {Usnum} is {ThirdDigit}");
}
*/



// Task 15
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


/*
Console.Write("Input the number of the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 6)
    Console.WriteLine("This is a Weekday.");

else if (num > 5 && num < 8)
    Console.WriteLine("This is the Weekend Day.");

else
    Console.WriteLine("Repeat the entry (this day of the week doesn't exist).");
