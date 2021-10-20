using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создать метод для вычисления объема и площади поверхности куба по длине его ребра.*/

            Console.WriteLine("Программа вычисления объема и площади поверхности куба");
            Console.WriteLine("\nВведите параметр стороны куба");
            Console.Write("А = ");
            double paramA = Convert.ToDouble(Console.ReadLine()); //Ввод параметра для расчета
            double paramV, paramS;
            CalcKub(paramA,out paramV,out paramS); //Расчет через метод
            Console.WriteLine("\nОбъем куба V = {0:F2}, Площадь сторон куба S = {1:F2}",paramV,paramS);  //Вывод результата

            Console.Write("\nНажмите любую кнопку для выхода из расчета ...");
            Console.ReadKey();
        }
        static void CalcKub(double A, out double paramV, out double paramS) //Расчетный метод
        {
            paramV = Math.Pow(A, 3);
            paramS = 6 * Math.Pow(A, 2);
        }
    }
}
