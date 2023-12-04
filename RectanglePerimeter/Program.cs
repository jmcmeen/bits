namespace RectanglePerimeter
{

    /// <summary>
    /// https://edabit.com/challenge/XnJ24rWW7iJkNrtsh
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = CalcRectanglePerimeter(4, 5);
            Console.WriteLine(p);
        }

        static int CalcRectanglePerimeter(int length, int width)
        {
            return length * 2 + width * 2;
        }
    }
}
