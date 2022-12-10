// Напишите цикл, которые принимает на вход два числа (А и В) и возводит число А в степерь В.
Console.WriteLine("Введите число А");
int number =int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B");
int numberDegree =int.Parse(Console.ReadLine()!);

int poweredNumber = Power(number, numberDegree);
Console.WriteLine(poweredNumber);

int Power(int A, int B)
{
    int result = 1;
    if (B == 0)
    {
        return result;
    }
    
    else
    {
        for (int i = 1; i <= B; i++)   
        {
            result = result * A;
        }

        return result;
    }    
}