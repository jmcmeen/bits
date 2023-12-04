namespace ATMPinCodeValidation
{
    /// <summary>
    /// https://edabit.com/challenge/gBYEFXeD9G2JMZ9dD
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(ValidatePin("111"));
            Console.WriteLine(ValidatePin("a111"));
            Console.WriteLine(ValidatePin("11111"));
            Console.WriteLine(ValidatePin("a11111"));
            Console.WriteLine(ValidatePin("1111111"));
        }

        static bool ValidatePin(string pin)
        {
            string validChars = "0123456789";

            if (pin.Length != 4 && pin.Length != 6) return false;

            foreach (char c in pin)
            {
                if (validChars.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
