//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

/*
int CutNumber (int num)
{
    int dec = num / 10;
    int result = dec % 10;
     return result;
}
Console.Write("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int result = CutNumber(num);
Console.WriteLine($"New version of {num} is {result}");
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6      123456789


void FriNumber (int num)
{
    if (num > 99)
    {
        string result = num.ToString();
        Console.WriteLine(result[2]);
    }
    
    else
    Console.Write($"{num} -> третьей цифры нет");
}
Console.Write("Insert number:");
int num = Convert.ToInt32(Console.ReadLine());
FriNumber(num);



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет      day off    not a day off

/*
bool dayoff (int num)
{
    if(num == 6 || num == 7)
    return true;
    else 
    return false;
}
Console.Write("Введите день недели(от 1 до 7):");
int num = Convert.ToInt32(Console.ReadLine());
bool result = dayoff (num);

Console.WriteLine(result);
*/

