using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 2, 67, 89, 56, 3, 5 };
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintArrayReverse(array, index - 1);
        }
    }
}
