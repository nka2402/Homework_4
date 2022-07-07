/*
Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int GetNumber()
{
    int result = 0;
    Console.WriteLine("Введите число:");
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число");
        }
    }
    return result;
}


void SumNumber(int number)
{
    int sum = 0;
    while(number != 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    Console.WriteLine(sum);
}



int number = GetNumber();
SumNumber(number);
