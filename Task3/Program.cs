// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int number = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(Week(number));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string Week(int number)
{
    if (number > 0 && number < 8)
    {
        if (number == 7 || number == 6)
        {
            Console.Write($"{number} -Является выходным");
        }
        else
        {
            Console.Write($"{number} - Является рабочим");
        }
    }
    else
    {
        Console.Write("Число , которое вы ввели не входит в диапозон от 1 до 7");
    }
    return " днем.";
}