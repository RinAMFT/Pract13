using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        /// <summary>
        /// По номеру месяца вывести его название.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            byte a = Input("month=");
            Console.WriteLine(GetDay(a));
            Console.ReadKey();
        }
        static byte Input(string message)
        {
            Console.Write(message);
            return byte.Parse(Console.ReadLine());
        }
        static string GetDay(int month)
        {
            switch (month)
            {
                case 1: return "Январь.";
                case 2: return "Февраль.";
                case 3: return "Март.";
                case 4: return "Апрель.";
                case 5: return "Май.";
                case 6: return "Июнь.";
                case 7: return "Июль.";
                case 8: return "Август.";
                case 9: return "Сентябрь.";
                case 10: return "Октябрь.";
                case 11: return "Ноябрь.";
                case 12: return "Декабрь.";
                default: return "Ошибка";


            }
        }
    }
}
