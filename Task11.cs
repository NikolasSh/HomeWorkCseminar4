/*
Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B.
*/
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >=1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}

int GetNumber1(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}

double NumberPow(int number1, int number2)
{
    double pow = 0;
    for (int i = 1; i < number2; i++ )
    
    {
        pow = Math.Pow(number1, number2);
    }


    return pow; 
}

int numberA = GetNumber("Введите число А: ");
int numberB = GetNumber1("ВВедите число В: ");
double pow = NumberPow(numberA, numberB);
Console.WriteLine($"Результат возведения {numberA} в {numberB} степень будет = {pow}");

