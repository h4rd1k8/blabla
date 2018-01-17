using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsPrime(int a) // Создаём функцию для определение простого числа
            {
                bool ok = true;
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        ok = false;
                        break;
                    }
                }
                return ok;
            }
            string x = Console.ReadLine(); // Ввод чисел
            string [] y = x.Split(' '); // В массив y присваиваем числа которые мы ввели разделяя их по проблеам тем самым у нас получается массив из стрингов но с отдельными числами
            for(int i = 0; i < y.Length; ++i) // Пробегаемся по массиву и ищем числа которые являются простыми
            {
                if(IsPrime(int.Parse(y[i])))
                {
                    Console.WriteLine(y[i] + ' '); // Выводим их
                }
            }
        }
    }
}
