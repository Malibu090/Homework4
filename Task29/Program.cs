// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] PrintArray(int[] num)
{
    int size = num.Length;
    for (int i = 0; i < size; i++)
    {
        num[i] = new Random().Next(0, 100);
        Console.Write(num[i] + " ");
    }
    return num;
}

int[] array = new int[8];
PrintArray(array);