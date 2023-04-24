Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите m: ");
int n = InputInt("Введите n: ");
if (n < 1 || m < 1 )
{
    Console.WriteLine("Вы ввели отрицательное число!");
}
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}