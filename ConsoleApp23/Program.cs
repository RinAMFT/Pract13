using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        /// <summary>
        /// По номеру месяца вывести название времени года.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            byte a = Input("month=");
            Console.WriteLine($"Время года:{GetDay(a)}");
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
                case 1: return "Зима.";
                case 2: return "Зима.";
                case 3: return "Весна.";
                case 4: return "Весна.";
                case 5: return "Весна.";
                case 6: return "Лето.";
                case 7: return "Лето.";
                case 8: return "Лето.";
                case 9: return "Осень.";
                case 10: return "Осень.";
                case 11: return "Осень.";
                case 12: return "Зима.";
                default: return "Ошибка";


            }
        }
    }
}
