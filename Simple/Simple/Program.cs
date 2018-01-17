using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SimpleNumb
    {
        int a;

        public static bool isSimple(int b)
        {
            for (int i = 2; i <= (int)(b / 2); i++)
            {
                if (b % i == 0)
                    return false;
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpleNumb s = new SimpleNumb();
            int a = int.Parse(Console.ReadLine());
            Console.Write(s.ToString() + " ");
        }
    }
}
