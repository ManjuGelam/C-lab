using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class accessspecifiers
    {
        protected string name = "manju";
        protected void method ( string str)
        {
            Console.WriteLine(" hello " + str); 

        }
        class  protectedmodifier: accessspecifiers
        {
            static void Main()
            {
                Program p = new Program();
                Console.WriteLine("iam " + p.name);

            }
        }
    }
}
