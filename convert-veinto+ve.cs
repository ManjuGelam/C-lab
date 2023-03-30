using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class convert_veinto_ve
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3, -4, -5, -6 };
            int loop = 0;
            for ( loop = 0; loop<arr.Length;loop++)
            {
                if (arr[loop] < 0)
                    arr[loop] = -arr[loop];
            }
            Console.WriteLine(" after conversion :");
            for( loop = 0; loop<arr.Length;loop++)
            {
                Console.WriteLine(arr[loop] + " ");

            }
            Console.WriteLine();
        }
    }

}
