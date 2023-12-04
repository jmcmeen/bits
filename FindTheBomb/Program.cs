namespace FindTheBomb
{
    /// <summary>
    /// https://edabit.com/challenge/JYEufqRvkusjr5R58
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheBomb("Something, something, bomb..."));
            Console.WriteLine(FindTheBomb("Something, something, bom..."));
        }

        public static string FindTheBomb(string value)
        {
            if (value.ToLower().Contains("bomb"))
            {
                return "Duck!!";
            }
            else
            {
                return "There is no bomb, relax.";
            }
        }
    }
}
