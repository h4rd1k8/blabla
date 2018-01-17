using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public string firstName;
        public string lastName;
        public double gpa;

        public Student()
        {
            firstName = "Yerdaulet";
            lastName = "Alipbayev";
            gpa = 2.43;
        }

        public Student(string a, string b, double g)
        {
            firstName = a;
            lastName = b;
            gpa = g;
        }

        public override string ToString()
        {
            return this.firstName + " " + lastName + " " + gpa;
        }
    }

    class Yerda
    {
        static void Main(string[] args)
        {
            Student x = new Student();
            x.firstName = "Yerdaulet";
            Console.WriteLine(x);
            Student y = new Student("The", "Best", 4);
            Console.WriteLine(y);
        }
    }
}
