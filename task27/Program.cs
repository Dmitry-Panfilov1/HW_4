// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
Console.WriteLine("Введите число");
int number =int.Parse(Console.ReadLine()!);

int sum = sumNumbers(number);
Console.WriteLine(sum);

int sumNumbers(int A)
{
    if (A < 0)
    {
        A = A * (-1);
    }
    
    int summa = 0;

    for (int i = A; i >= 1; i = i / 10)
    {
        int temp = i % 10;
        summa = summa + temp;
    }
    return summa;
}