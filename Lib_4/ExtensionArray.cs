using System;
using LibArray;

namespace Lib_4
{
    public class ExtensionArray
    {
        
        public static int[] ArrayCeate(Array<double> numbers)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < numbers.Lenght; i++)
            {
                numbers[i] = rnd.Next(0, 100);
            }

            return numbers;
        }

    }
}
