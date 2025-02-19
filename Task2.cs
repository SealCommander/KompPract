using System;

class Task2
{
    public static int task2(int N)
    {
        if (N < 2)
        {
            return -1;
        }
        for (int i = 2; i * i <= N; i++)
        {
            if (N % i == 0)
            {
                return i; 
            }
        }
        return N;
    }

    public static void test2()
    {
        if (task2(12) == 2)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("FAIL");
        }

        if (task2(49) == 7)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("FAIL");
        }

        if (task2(30) == 2)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("FAIL");
        }

        if (task2(17) == 17)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("FAIL");
        }

        if (task2(2) == 2)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("FAIL");
        }

        if (task2(1) == -1)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("FAIL");
        }
    }

    static void 
        Main()
    {
        test2();
    }
}