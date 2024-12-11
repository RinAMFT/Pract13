using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        /// <summary>
        /// Дан признак транспортного средства: a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд. Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите первую букву: ");
            char letter = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (letter)
            {
                case 'а':
                    Console.WriteLine("автомобиль");
                    break;
                case 'в':
                    Console.WriteLine("велосипед");
                    break;
                case 'м':
                    Console.WriteLine("мотоцикл");
                    break;
                case 'с':
                    Console.WriteLine("самолет");
                    break;
                case 'п':
                    Console.WriteLine("поезд");
                    break;
                default:
                    Console.WriteLine("Неизвестная буква");
                    break;
            }
            Console.ReadKey();
        }

    }
}
