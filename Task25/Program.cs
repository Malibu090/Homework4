// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int EnterNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Degree(int A, int B)
{
    int composition = 1;
    for (int i = 0; i < B; i++)
    {
        composition *= A;
    }
    return composition;
}

int A = EnterNumber("Введите A: ");
int B = EnterNumber("Введите B: ");
int result = Degree(A, B);
if (B > 0) Console.WriteLine(A + " в степени " + B + " равно " + result);
else if (B == 0) Console.WriteLine("Вы ввели ненатуральное число B! Но " + A + " в степени " + B + " равно 1");
else Console.WriteLine("Вы ввели ненатуральное число B!");
