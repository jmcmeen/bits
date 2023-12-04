//john mcmeen

namespace SumOfTwoNumbers
{
    /// <summary>
    /// https://edabit.com/challenge/xfRucdwGksiyjZq4K
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            Sum(4, 8);
            Sum(4.0, 8.0);
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static double Sum(double x, double y)
        {
            return x + y;
        }
    }
}
