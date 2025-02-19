using System;

class Task2
{
    public static int task2(int[] arr)
    {
        int count = 0;
        foreach (int number in arr)
        {
            if (number > 0)
            {
                count++;
            }
        }
        return count;
    }

    public static void test3()
    {
        if (task2([3, -1, 4, 0, 7]) == 3)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("FAIL");
        }

        if (task2([-5, -2, -8, -1]) == 0)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("FAIL");
        }

        if (task2([0]) == 0)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("FAIL");
        }

        if (task2([-1]) == 0)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("FAIL");
        }

        if (task2([1000000, -1000000, 500000, 0]) == 2)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("FAIL");
        }

        if (task2([2147483647, -2147483648, 0]) == 1)
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
        test3();
    }
}