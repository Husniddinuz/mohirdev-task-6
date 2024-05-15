using System;

class ParityCheck
{
    static void Main()
    {
        Console.WriteLine("Raqamni kiriting:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Juft");
        }
        else
        {
            Console.WriteLine("Toq");
        }
    }
}
