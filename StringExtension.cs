using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Length > array[j].Length)
                    {
                        string temp;
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

        }
    }
}

