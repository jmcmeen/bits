namespace RemainderOfTwoNumbers
{
    /// <summary>
    /// https://edabit.com/challenge/Q2j5FTFtsk7PdzrQk
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            int r = Remainder(36, 6);
            Console.WriteLine(r);

            r = Remainder2(36, 6);
            Console.WriteLine(r);
        }

        public static int Remainder(int a, int b)
        {
            return a % b;
        }

        public static int Remainder2(int a, int b)
        {
            //repeat subtraction
            if(b > a)
            {
                return a;
            }

            while(a >= b)
            {
                a = a - b;
            }

            return a;
        }
    }
}
