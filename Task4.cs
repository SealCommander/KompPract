using System;

class Task2
{
    public static int task2(string number)
    {
        bool flag = true;

        char firstDigit = number[0];
        
        for (int i = 1; i < number.Length; i++)
        {
            if (number[i] != firstDigit)
            {
                flag = false;
                break; 
            }
        }

        // Выводим результат
        if (flag)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    
    }

    public static void test2()
    {
        if (task2("222") == 1)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("FAIL");
        }

        if (task2("123") == 0)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("FAIL");
        }

        if (task2("999999999999999999") == 1)
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