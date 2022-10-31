using System;
using LibArray; 

namespace Lib_4
{
    public static class ExtensionArray
    {
        /// <summary>
        /// ������������� �������
        /// </summary>
        /// <param name="numbers"> ������ ��� ���������� </param>
        public static void Init(this Array<double> numbers, int min = -10, int max = 11)
        {
            for (int i = 0; i < numbers.Capacity; i++)
            {
            Random rnd = new Random();

                numbers.Add(rnd.Next(min, max));
            }
        }

        /// <summary>
        /// ������ �� �������
        /// </summary>
        /// <param name="numbers"> ������ ��� ���������� </param>
        /// <returns></returns>
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
