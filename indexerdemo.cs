using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class indexerdemo
    {
        public string[] names = new string[10];
        public string this[int i ]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
        static void Main()
        {
            indexerdemo p = new indexerdemo();
            p[0] = "manju";
            p[1] = "divya";
            p[2] = "neelima";
            p[3] = "latha"; 
            p[4] = "rakshitha";
            p[5] = "harish";
            p[6] = "sriram";
            p[7] = "anandh";
            p[8] = "yuvateja";
            p[9] = "sai";
            for(int i= 0;i<10; i++)
            {
                Console.WriteLine("p[i] :" + p[i]);
                Console.ReadLine();
            }
        }


    }
}
