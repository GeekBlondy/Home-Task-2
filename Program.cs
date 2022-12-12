// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.WriteLine("Input a number from 100 to 999 inclusively:  ");
int num = Convert.ToInt32(Console.ReadLine());

int numA = num / 10;
int numB = numA % 10;

Console.WriteLine(numB);
*/

// 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.WriteLine("Input a new number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = -1;

while(num > 999)
{
    num = num / 10;
}

if(num <= 999)
{
    result = num % 10;
}

if(num < 100)
{
    result = -1;
}

Console.WriteLine(result);
*/


// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.WriteLine("Input a number from 1 to 7, where 1 - Monday, 7 - Sunday: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 5)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
*/