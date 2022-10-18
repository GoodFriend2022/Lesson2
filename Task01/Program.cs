// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)// Запрашивает на ввод число
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
bool Right(int value)// Проверяет трёхзначное ли число
{
    if (value > 99 && value < 1000)
    {
        return true;
    }
    return false;
}

int secondNumber = Prompt("Введите трехзначное число > ");
if (Right(secondNumber))
{
    secondNumber = secondNumber / 10 % 10;
    System.Console.WriteLine($"Вторая цифра введенного Вами числа - {secondNumber}");
}
else
{
    System.Console.WriteLine("Ваше число не является трёхзначным, перезапустите программу и попробуйте ещё раз");
}