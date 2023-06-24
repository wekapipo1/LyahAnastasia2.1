using System;

class Program
{
    static int Pair(string input)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == '(')
                count++;
            else if (c == ')')
            {
                if (count == 0)
                    return 0;
                count--;
            }
        }
        if (count == 0)
            return 1;
        else
            return 0;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введіть рядок з дужками:");
        string input = Console.ReadLine();
        int result = Pair(input);
        Console.WriteLine("Результат: " + result);
    }
}
