namespace ToThePowerOf
{
    /// <summary>
    /// https://edabit.com/challenge/esARjHfWfdRP6ePEC
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(СalculateExponent(3, 3));
        }

        static int СalculateExponent(int x, int y)
        {
            return Convert.ToInt32(Math.Pow(x, y));
        }

        static int СalculateExponent2(int x, int y)
        {
            for (int i = 0; i < y -1; i++)
            {
                x = x * x;
            }
            
            return x;
        }
    }
}
