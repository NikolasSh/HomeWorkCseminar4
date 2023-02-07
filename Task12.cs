/*
Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else 
        {
            Console.WriteLine("Вы ввели некорректное число или ноль! Повторите ввод!");
        }
    }
    return result;
}

int SumAllDigits(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number%10;
        number = number/10;
    }
    return sum;
}

int number = GetNumber("Введите число: ");
int result = SumAllDigits(number);
Console.WriteLine($"Сумма цифр числа{number} = {result}");