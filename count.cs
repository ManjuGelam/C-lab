using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace labprograms
{
    class count
    {
        public static void Main()
        {

        
        int[] arr = { 1, 20, 15, 23, 15, 14, 20, 25, 12, 30, 15 };
        Console.WriteLine(" your aray");
            for(int i=0; i<arr.Length; i++)
            {
            Console.WriteLine(arr[i] +"");
    }
    Console.WriteLine(" enter to check occurance:");
        int number = int.Parse (Console.ReadLine());
    int occurances= arr.Count(x => x ==number);
            Console.WriteLine("occurances of {0}is given array is {1}", number, occurances);


}
       
}
}