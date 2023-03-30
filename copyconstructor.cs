using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class copyconstructor
    {

            int Id;
            string Name;
            double Balance;
            public copyconstructor(int Id)
            {
                this.Id = Id;
                Name = "Vijay";
                Balance = 5000.00;
            }
            public copyconstructor(copyconstructor cd)
            {
                this.Id = cd.Id;
                this.Name = cd.Name;
                this.Balance = cd.Balance;
            }
            public void Display()
            {
                Console.WriteLine($"Id: {Id}; Name: {Name}; Balance: {Balance}");
            }
            static void Main()
            {
                copyconstructor cd1 = new copyconstructor(1005);
                cd1.Display();
                copyconstructor cd2 = new copyconstructor(cd1);
                cd2.Display();
                Console.WriteLine();
                cd1.Balance = 10000;
                cd1.Display();
                cd2.Display();
                Console.WriteLine();
                cd1.Balance = 20000;
                cd1.Display();
                cd2.Display();
                Console.ReadLine();
            }
        }

    }




