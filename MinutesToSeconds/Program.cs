
namespace MinutesToSeconds
{
    /// <summary>
    /// https://edabit.com/challenge/bizjGL4wyd8PwR4Ke
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            int seconds = MinutesToSeconds(10);
            double alsoSeconds = MinutesToSeconds(1.5);

            Console.WriteLine(seconds);
            Console.WriteLine(alsoSeconds);
        }

        static int MinutesToSeconds(int minutes)
        {
            return minutes * 60;
        }

        static double MinutesToSeconds(double minutes)
        {
            return minutes * 60;
        }
    }
}
