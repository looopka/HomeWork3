/*
 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int RequestHundler(string request)
{   
    if (int.TryParse(request, out int result) && result > 9999 && result < 100000)
        return result;
    else
    {
        throw new ArgumentException("Должно быть введено пятизначное число;");
    }
}

int Reverser(int num)
{
    int result = 0;
    while (num/10 > 0)
    {
        result += num % 10;
        result *= 10;
        num /= 10;
    }
    return result+num;
}

Console.WriteLine("Введи пятизнчное число");
int num = RequestHundler(Console.ReadLine());
if (num == Reverser(num))
{

    Console.WriteLine("Число " + num + " палиндром");
}
else
    Console.WriteLine("Число " + num + " не палиднром");