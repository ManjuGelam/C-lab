using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class Anonymus
    {
        static void Main()
        {
            var emp = new { id = 100, name = "manju", job = "trainee", salary = 20000, status = true };
            Console.WriteLine(emp.GetType()+" \n");
          //  Printer.print(emp);
            Console.ReadLine();
        }
    }
}
