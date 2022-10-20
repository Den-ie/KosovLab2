using System;

namespace Lib_4
{
    public class ExtensionArray
    {



        public static int[] ArrayCeate(int size)
        {
            Random rnd = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 100);
            }

            return array;
        }

    }
}
