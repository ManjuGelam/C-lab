using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace labprograms
{
    class randomevennumber
    {
        static void Main()
        {
         
            IEnumerable<int> data = ((ParallelQuery<int>)ParallelEnumerable.Range(10,20)).Where(n => n % 2 == 0).Select(res => res);
            foreach(int even in data)
            {
                Console.WriteLine(even);
            }
        }

    }
}
