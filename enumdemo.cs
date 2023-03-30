using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    enum color
    {
        red, green, yellow, black, blue,white
    }
    class enumdemo
    {
        static void printcolor(color color)
        {
            switch (color)
            {
                case color.red:
                    Console.WriteLine("COLOR IS RED , VALUE :" + (int)color.red);
                    break;
                case color.green:
                    Console.WriteLine("COLOR IS green , VALUE :" + (int)color.green);
                    break;
                case color.yellow:
                    Console.WriteLine("COLOR IS yellow , VALUE :" + (int)color.yellow);
                    break;
                case color.black:
                    Console.WriteLine("COLOR IS black , VALUE :" + (int)color.black);
                    break;
                case color.blue:
                    Console.WriteLine("COLOR IS white , VALUE :" + (int)color.blue);
                    break;
                case color.white:
                    Console.WriteLine("COLOR IS RED , VALUE :" + (int)color.white);
                    break;
            }
        }
        static void Main()
        {
            printcolor(color.red);
            printcolor(color.yellow);
            printcolor(color.white);
            printcolor(color.black);
            printcolor(color.blue);
            printcolor(color.green);
        }
    
    

    }
}
