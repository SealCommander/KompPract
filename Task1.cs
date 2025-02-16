namespace КП
{
    internal class Program
    {
        public static int task1(string numbers)
        {
            int maxcount = 1;
            int currentcount = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                char curr_num_str = numbers[i];
                char curr_num2_str = numbers[i + 1];
                int curr_num_int = curr_num_str - '0';
                int curr_num2_int = curr_num2_str - '0';
                if (curr_num2_int == curr_num_int)
                {
                    currentcount++;
                    if (currentcount > maxcount)
                    {
                        maxcount = currentcount;
                    }
                }
                else
                {
                    currentcount = 1;
                }

                if (curr_num_int == 0)
                {
                    break;
                }
                

            }

            return maxcount;
        }

        public static void test1()
        {
            if (task1("1122233330") == 4)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.Write("NO");
            }

            if (task1("7777770") == 6)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            if (task1("0") == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        static void Main()
        {
            test1();
        }
    }
}
