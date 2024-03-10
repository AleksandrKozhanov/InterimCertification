//Задача 1: Задайте значения M и N.
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//Использовать рекурсию, не использовать циклы.

//Программа выведет все натуральные числа в промежутке M N (ввключая M N) по возрастанию.
void Main()
{
    int M = ReadInt("Введите первое число: ");
    int N = ReadInt("Введите второе число: ");
    Console.Write(recursion(M, N));
}

String recursion(int M, int N)
{
    if (M > N)
    {
        if (M == N)
        {
            return Convert.ToString(M);
        }
        return N + " " + recursion(N + 1, M);
    }
    else
    {
        if (M == N)
        {
            return Convert.ToString(M);
        }
        return M + " " + recursion(M + 1, N);
    }
}
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();
