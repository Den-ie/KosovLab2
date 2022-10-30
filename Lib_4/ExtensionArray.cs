using System;
using LibArray; 

namespace Lib_4
{
    public static class ExtensionArray
    {
        public static void Init(this Array<double> numbers)
        {
            for (int i = 0; i < numbers.Capacity; i++)
            {
            Random rnd = new Random();

                numbers.Add(rnd.Next(-10, 11));
            }
        }

        public static string Calculate(Array<double> numbers)
        {
            string answer = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    answer += Convert.ToString(Math.Round(Math.Sqrt(numbers[i]),2)) + "\n";
                }
            }
            return answer;
        }
    }
}
