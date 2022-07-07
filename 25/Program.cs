/*
Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while(true)
    {
        
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            if(result == 0)
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
            else
                break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}


int GetExponent(int number1, int number2)
{
    int result = number1;

    for(int i = 1; i < number2; i++)
        result = result * number1;

    return result;
}


int number1 = GetNumber("Введите первое число");
int number2 = GetNumber("Введите второе число");
int result = GetExponent(number1, number2);

Console.WriteLine($"Степень {number2} числа {number1} = {result}");




