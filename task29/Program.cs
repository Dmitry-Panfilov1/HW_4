// Напишите программу, которая принимает на вход числа N, min, max. Затем генерирует массив и заполняет его случайными числами в диапозоне от min до max.

Console.WriteLine("Введите размер массива");
int N =int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите нижнюю границу диапазона заполнения");
int min =int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите верхнюю границу диапазона заполнения");
int max =int.Parse(Console.ReadLine()!);

int[] arrayGener = GenerateArray(N, min, max);
PrintArray(arrayGener);

int[] GenerateArray(int size, int minBorder, int maxBorder)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minBorder, maxBorder);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}