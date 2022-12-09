// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();
int EnterNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] PrintArray(int[] num)
{
    int size = num.Length;
    for (int i = 0; i < size; i++)
    {
        num[i] = new Random().Next(0, 100);
        Console.Write(num[i] + ", ");
    }
    return num;
}
int digit = EnterNumber("Введите длину массива: ");
int[] array = new int[digit];
PrintArray(array);