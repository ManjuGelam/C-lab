using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class sortingstringinlist
    {
        static void Main()
        {
            List<string> names = new List<string>();
            names.Add("manju");
            names.Add("sai divya ");
            names.Add("sai latha");
            names.Add("neelima ");
            names.Sort();
            foreach (string name in names)
                Console.WriteLine(name);
        }

    }
}
