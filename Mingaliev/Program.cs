using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mingaliev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите две переменных чтобы найти их сумму: \na = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Сумма переменных 'a' и 'b' равна: {0}", sum);
            Console.Write("Для выхода нажмите любую клавишу...");
            Console.ReadLine();
        }
    }
}
