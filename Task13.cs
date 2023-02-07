/*
Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
*/

int[] array = new int[8];

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено некорректное число! Повторите ввод.");
        }
    }
    return result;
}

void EnterArray(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] =  GetNumber("Введите элемент массива: ");
        
    }

    Console.WriteLine("");

    for (int i = 0; i < array.Length; i++ )
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }

}

EnterArray(array);
