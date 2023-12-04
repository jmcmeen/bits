namespace AlmostPalindrome
{
    /// <summary>
    /// https://edabit.com/challenge/t6R99zCQ7nesR7Rdk
    /// </summary>
    internal class Program
    {

        static void Main()
        {
            Console.WriteLine(AlmostPalindrome("abc")); //true
            Console.WriteLine(AlmostPalindrome("aba")); //true
            Console.WriteLine(AlmostPalindrome("abbc")); //true
            Console.WriteLine(AlmostPalindrome("hello")); //false

        }

        public static bool AlmostPalindrome(string testString)
        {
            char[] chars = testString.ToCharArray();
            int low = 0;
            int high = chars.Length - 1;
            int mismatchCounter = 0;

            while (low <= high)
            {
                if (char.ToUpper(chars[low]) != char.ToUpper(chars[high]))
                {
                    mismatchCounter++;
                }

                low++;
                high--;
            }

            return mismatchCounter <= 1;
        }
    }
}
