using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше 
             * (создать метод для вычисления  площади  треугольника по длинам его сторон).  Для решения задачи можно использовать формулу Герона 
            где x, y, z – стороны треугольника, p – полупериметр.*/

            int x=0, y=0, z=0; //переменные для расчетов
            
            Console.WriteLine("Программа сравнения площадей треугольников по формуле Герона");
            Console.WriteLine("\nВведите параметры сторон первого треугольника");
            XyzInput(ref x, ref y, ref z); //ввод данных
            double S1 = CalcSqr(x, y, z); //расчет 1 площади
            
            Console.WriteLine("\nВведите параметры сторон второго треугольника");
            XyzInput(ref x, ref y, ref z); //ввод данных и расчет
            double S2 = CalcSqr(x, y, z);

            if (S1 > S2) //вывод результата
            {
                Console.WriteLine("\nПлощадь первого треугольника больше и равна {0:F2}", S1);
            }
            else
            { 
            if (S1==S2)
                {
                    Console.WriteLine("\nПлощади треугольников равны");
                }
            else
                {
                    Console.WriteLine("\nПлощадь второго треугольника больше и равна {0:F2}", S2);
                }
            }
            Console.Write("\nНажмите любую кнопку для выхода из расчета ...");
            Console.ReadKey();
        }

        static double CalcSqr(int x, int y, int z) // расчетный метод
        {
            double halfPerim = Convert.ToDouble((x + y + z)) / 2;
            double S = Math.Sqrt(halfPerim * (halfPerim - x) * (halfPerim - y) * (halfPerim - z));
            return S;
        }

        static void XyzInput(ref int x, ref int y, ref int z) //метод для ввода цифр
        {
            Console.Write("x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("z:");
            z = Convert.ToInt32(Console.ReadLine());
        }
    }
}
