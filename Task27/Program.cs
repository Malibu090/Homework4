// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int EnterNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindSum(int num)
{
    int sum = 0;
    for (int i = 0; num > 0; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int number = EnterNumber("Введите число ");
int result = FindSum(number);
Console.WriteLine("Сумма цифр в числе равна " + result);
