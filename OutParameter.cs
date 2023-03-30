using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class OutParameter
    {
        public void Show(out int value )
        {
            int square = 3;
            value = square;
            value = value;

        }
        static void Main()
        {
            int value = 30;
            OutParameter o = new OutParameter();
            Console.WriteLine(" value before passing out variABLE " + value);
            o.Show(out value);
            Console.WriteLine(" value after receiving the out varible :" + value);

        }
    }
}
