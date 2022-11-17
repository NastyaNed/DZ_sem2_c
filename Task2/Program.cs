// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ToThirdDigit(int number)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    return number % 10;
}

if(number<0) number=-number;
if (number > 99)
{
    int result = ToThirdDigit(number);
    Console.WriteLine(result);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}