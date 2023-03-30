using System;
using System.Collections;
using System.Text;

namespace labprograms
{
    class implemetingthephonebook
    {
        static void Main()
        {
            Hashtable phonebook = new Hashtable();
            while(true)
            {
                Console.WriteLine("--------------- phonebook -------------------");
                Console.WriteLine(" \t1:Add number to the phonebook");
                Console.WriteLine(" \t2:Get number to the phonebook");
                Console.WriteLine(" \t3:exit ");
                Console.WriteLine("\n---------------");
                Console.WriteLine("\n\n Enter the choice :");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        {
                            long number = 0;
                            string name = " ";
                            Console.WriteLine(" enter your name:");
                             name = Console.ReadLine();
                            Console.WriteLine(" enter your number :");
                            number = Convert.ToInt64(Console.ReadLine());
                            phonebook.Add(number, name);


                        }
                        break;
                        case 2:
                        {
                            long number = 0;
                            string name = " ";
                            Console.WriteLine(" enter your name:");
                            name = Console.ReadLine();
                            if(phonebook == null)
                            {
                                Console.WriteLine("given number is not here ");
                            }
                            else
                            {
                                number = Convert.ToInt64(phonebook[name]);
                                Console.WriteLine("name:" + name + ",phone number :" + number );

                            }

                        }
                        break;
                    case 3:
                        {
                            goto Out;
                        }
                        break ;

                        default:
                        {
                            Console.WriteLine("\n you have entered the wrong choice");
                        }
                        break;
                }
                Out:
                Console.WriteLine("thank you for using phonebook");

            }
        }
    }
}
