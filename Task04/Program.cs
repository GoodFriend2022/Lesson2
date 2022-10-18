// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)// Запрашивает на ввод число
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
bool Right(int value)// Проверяет есть ли день недели, соответствующий заданному числу
{
    if (value > 0 && value < 8)
    {
        return true;
    }
    return false;
}

int day = Prompt("Введите число, соответствующее дню недели > ");
if (Right(day))
{
    if (day == 6 || day == 7)
    {
        System.Console.WriteLine($"Да, {day} день недели является выходным");
    }
    else
    {
        System.Console.WriteLine($"Нет, {day} день недели не является выходным");
    }
}
else
{
    System.Console.WriteLine("Ваше число не соответствует дню недели, перезапустите программу и попробуйте ещё раз");
}

