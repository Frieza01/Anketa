using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anketa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Даниил";
            byte MyAge = 25;
            bool HaveIApet = true;
            double MyShoeSize = 41.5;

            Console.WriteLine("Мое имя " + MyName);
            Console.WriteLine("Мой возраст " + MyAge);
            Console.WriteLine("Размер моей обуви " + MyShoeSize);
            Console.WriteLine("Есть ли у меня питомец " + HaveIApet);

            Console.ReadKey();

        }
    }
}
