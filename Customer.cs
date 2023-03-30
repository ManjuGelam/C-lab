using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    public class Customer//readonly 
    {
        int _Custid;
        string _Name_State;
        public Customer(int custid)
        {
            _Custid = custid;
            _Name_State  = "manju";
            _Name_State = "Andhrapradesh";



        }
        public int Custid
        {
            get { return _Custid; }
        }
        public string Name
        {
            get { return _Name_State; }
        }
        public string State
        {
            get { return _Name_State; }
        }
        static void Main()
        {
            Customer obj = new Customer(100);
            Console.WriteLine(" customer id :" + obj.Custid);
            Console.WriteLine(" customer name :" + obj.Name);
            Console.WriteLine(" customer state  :" + obj.State);
        }
    }
}
