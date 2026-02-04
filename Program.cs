using System;
class Program
{
    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }

    static void Main()
    {
        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine(i + "->" + EsPar(i));
            i++;
        }
    }
}