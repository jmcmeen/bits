namespace CountOnesBinaryRepresentation
{
    /// <summary>
    /// https://edabit.com/challenge/zn3A3AAzoE7vezw7Q
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToBinaryString(64));
            Console.WriteLine(CountOnes(ToBinaryString(64)));

        }

        static string ToBinaryString(int value)
        {
            return Convert.ToString(value, 2);
        }

        static int CountOnes(string value)
        {
            int count = 0;  
            foreach(char c in value)
            {
                if (c == '1')
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountOnes(int i)
        {
            int db = 0;
            while (i > 0)
            {
                if (i % 2 == 1) db++;
                i = i / 2;
            }
            return db;
        }
    }
}
