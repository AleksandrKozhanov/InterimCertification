// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] Array = { 1, 2, 3, 4, 5 };
int g = Array.Length - 1;


void Main()
{
    recursion(g);
    Console.ReadKey();
}
void recursion(int x)
{
    int n = 0;
    int[] InvertArray = new int[5];
    if (x >= 0)
    {
        InvertArray[n] = Array[x];
        Console.Write(InvertArray[n] + " ");
        n++;
        x--;
    }
    else
    {
        return;
    }
    recursion(x);
}
Main();
