using System;

namespace labprograms
{
    class Program
    {
        internal string name;

        static void Main(string[] args)
        {
            Console.WriteLine(" enter a string : ");
            string str = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            string result = str.Trim().Substring(0, n );
            Console.WriteLine("result is :" + "" + result);
        
        }
    }
}
