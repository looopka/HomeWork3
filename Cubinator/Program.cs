

Double getCube(int num)
{
    return Math.Pow(num, 3);
}

void cubinator(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write(getCube(i) + ",");
    }
}

Console.WriteLine("Введи целое число больше или равное 1");
if (int.TryParse(Console.ReadLine(), out int num) && num  >= 1)
    cubinator(num);
else
{
    Console.WriteLine("Ввод не корректный");
}