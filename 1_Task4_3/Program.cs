using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Task4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение числа A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение числа B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение числа C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int kolvoA = 0;
            int kolvoB = 0;
            while (a >= c)
            {
                a -= c;
                kolvoA++;
            }
            while (b >= c)
            {
                b -= c;
                kolvoB++; 
            }

            int kolvoC = 0;
            int i = 0;

            while (i<kolvoA)
            {
                kolvoC += kolvoB;
                i++;
            }

            Console.WriteLine("Количество квадратов CxC расположенных в прямоугольнике АхВ равно " + kolvoC);
            Console.ReadKey();
        }
    }
    
}
