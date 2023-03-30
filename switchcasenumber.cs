using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace labprograms
{
    class switchcasenumber
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int Number = int.Parse(Console.ReadLine());
            int Reminder, Reverse = 0;
            while (Number != 0)
            {
                Reminder = Number % 10;
                Reverse = Reverse * 10 + Reminder;
                Number = Number / 10;
            }
            while (Reverse > 0)
            {
                Reminder = Reverse % 10;
                switch (Reminder)
                {
                    case 1:
                        Console.WriteLine("ONE");
                        break;
                    case 2:
                        Console.WriteLine("TWO");
                        break;
                    case 3:
                        Console.WriteLine("THREE");
                        break;
                    case 4:
                        Console.WriteLine("FOUR");
                        break;
                    case 5:
                        Console.WriteLine(" FIVE");
                        break;
                    case 6:
                        Console.WriteLine("SIX");
                        break;
                }

                Reverse = Reverse / 10;

            }
            Console.ReadLine();
        }
    }
}
    

