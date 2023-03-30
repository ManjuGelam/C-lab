using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    public class sealedmethod
    {
        public virtual void eat()
        {
            Console.WriteLine("eating----");
        }
        public virtual void run()
        {
            Console.WriteLine("eating----");
        }
        public class dog : sealedmethod
        {
            public override void eat()
            {
                Console.WriteLine("eating-----");

            }
            public class cat : dog
            {
                public override void eat()
                {
                    Console.WriteLine("eating biscuits ----");

                }
                public override void run()
                {
                    Console.WriteLine("running biscuits -----");
                }
                public class test
                {
                      static void Main()
                    {
                        dog d = new dog();
                        d.eat();
                        d.run();
                        Console.ReadLine();
                    }
                }
            }

        }
    }
}

