using System;
using System.Collections.Generic;
using System.Text;
 
namespace labprograms
{
    class reverseofnumber
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
            Console.WriteLine("Reversed Number is: " + Reverse);
            Console.ReadLine();
        }
    }

}

