using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
     class singleinheritance //single inheritance 
    {
        public string name;
        public int age;
        public singleinheritance(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

    }
    
    class employee : singleinheritance
    {
        public int emp_id;
        public int emp_salary;
        public employee(int id, int salary, string name, int age) : base(age, name)
        {
            emp_id = id;
            emp_salary = salary;
        }
        public void Print()
        {
            Console.WriteLine("emp_id:" + emp_id);
            Console.WriteLine("emp name:" + name);
            Console.WriteLine("emp salary:" + emp_salary);
            Console.WriteLine("emp age:" +age);
        }
         public static void Main()
        {
            employee e = new employee(111, 20000, "manju", 21);
            e.Print();
        }
    }
}
