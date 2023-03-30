using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class encapsulation
    {
        public string ID
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        static void Main()
        {
            encapsulation student = new encapsulation();

            //setting the values 

            student.ID = "101";
            student.Name = "manju";
            student.Email = "manjugelam@gmail.com";
            //getting values
            Console.WriteLine(" ID=" + student.ID);
            Console.WriteLine(" Name=" + student.Name);
            Console.WriteLine(" Email=" + student.Email);

        }
    }
}

