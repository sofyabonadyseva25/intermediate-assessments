using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write($"A(m, n) = {FunctionAkk(m, n)}");
    }

    static int FunctionAkk(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0 && m > 0)
            return FunctionAkk(m - 1, 1);
        else
            return FunctionAkk(m - 1, FunctionAkk(m, n - 1));
    }
}
