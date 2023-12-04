namespace IsPalindrome
{
    /// <summary>
    /// https://edabit.com/challenge/5tZQKkMhYPNxQxmnG
    /// </summary>
    internal class Program
    {
        
        static void Main()
        {
            Console.WriteLine(IsPalindrome1("Aba"));
            Console.WriteLine(IsPalindrome1("abc")); 
            Console.WriteLine(IsPalindrome2("Aba"));
            Console.WriteLine(IsPalindrome2("abc"));
        }

        public static bool IsPalindrome1(string testString)
        {
            char[] reversedChars = testString.ToCharArray();
            Array.Reverse(reversedChars);
            string reversedTestString = new string(reversedChars);
            return reversedTestString.ToLower() == testString.ToLower();
        }

        public static bool IsPalindrome2(string testString)
        {
            char[] chars = testString.ToCharArray();
            int low = 0;
            int high = chars.Length - 1;

            while (low <= high)
            {
                if (char.ToUpper(chars[low]) != char.ToUpper(chars[high]))
                {
                    return false;
                }

                low++;
                high--;
            }

            return true;
        }
    }
}
