namespace SortNumbersInDescendingOrder
{

    /// <summary>
    /// https://edabit.com/challenge/N5G33s49LDXdhLdsT
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(SortDescending(123));
        }

        public static int SortDescending(int value)
        {
            char[] values = value.ToString().ToCharArray();
            Array.Sort(values);
            Array.Reverse(values);

            string sorted = String.Join("", values);
            return Convert.ToInt32(sorted);
        }
    }
}
