using System;
using LibArray;

namespace Lib_4
{
    public static class ExtensionArray
    {

        public static void Init(this Array<double> numbers)
        {
            Random rnd = new Random();

            for (int i = 0; i < numbers.Capacity; i++)
            {
                numbers.Add(rnd.Next(1, 11));
            }
        }
    }
}
