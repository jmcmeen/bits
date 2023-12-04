using System.Diagnostics.Metrics;

namespace IndexOfAllCapitalLetters
{

    /// <summary>
    /// https://edabit.com/challenge/6qFnpAhd3kdmYcNG2
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            int[] capitals = IndexOfCapitals("AbC");
        }

        public static int[] IndexOfCapitals(string value)
        {
            int counter = 0;

            foreach(char v in value)
            {
                if (char.IsUpper(v)) {  
                    counter++; 
                }
            }

            int[] indices = new int[counter];

            counter = 0;
            int currIndex = 0;
            foreach(char v in value)
            {
                if (char.IsUpper(v)) 
                {
                    indices[counter] = currIndex;
                    counter++; 
                }

                currIndex++;
            }

            return indices;
        }

        public static int[] IndexOfCapitals2(string value)
        {
            List<int> indices = new List<int>();
            char[] values = value.ToCharArray();

            for (int i = 0; i < values.Length; i++)
            {
                if (char.IsUpper(values[i]))
                {
                    indices.Add(i);
                }
            }

            return indices.ToArray();
        }
    }
}
