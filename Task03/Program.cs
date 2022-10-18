// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int Prompt(string message)// Запрашивает на ввод число
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int index = 0;
int thirdNumber = Prompt("Введите целое число > ");
int count = thirdNumber;

while (count != 0)
{
    count /= 10;
    index++;
}

if (index >= 3)
{
    int[] array = new int[index];

    while (thirdNumber != 0)
    {
        array[count] = thirdNumber % 10;
        thirdNumber /= 10;
        count++;
    }
    System.Console.WriteLine($"Третья цифра введенного Вами числа равна > {array[^3]}");
}
else
{
    System.Console.WriteLine("В введеном Вами числе третьей цифры нет");
}
