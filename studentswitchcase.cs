using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class studentswitchcase

    {
        public static void Main()
        {


            Console.Write("enter student no :");
            int sno = int.Parse(Console.ReadLine());
            switch(sno)
            {
                case 1:
                    Console.WriteLine("student 1");
                    break;
                case 2:
                    Console.WriteLine("student 2");
                    break;
                case 3:
                    Console.WriteLine("student 3");
                    break;
                case 4:
                    Console.WriteLine(" student 4");
                    break;
                case 5:
                    Console.WriteLine(" student 6");
                    break;
            }
            Console.ReadLine();
        }
    }
}