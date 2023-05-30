using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//SQL QUERY ДЛЯ ЗАДАНИЯ №2
//Select product_name,product_type from product_table 

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)  //Добавление других фигур можно оформить через добавление последующих конструкций If
        {
            double x, y, z, r, p, S;

            Console.WriteLine("Введите номер вычисляемой фигуры");
            Console.WriteLine("1 - круг, 2 - треугольник");
            var a = Console.ReadLine();
            if (a == "1")
            {
                Console.WriteLine("Введите радиус круга");
                r = Convert.ToDouble(Console.ReadLine());
                S = 3.14 * r * r; //не использовал Math.PI для красивого вывода 2 знаков после запятой

                Console.WriteLine($"Площадь круга = {S}");
                Console.ReadKey();

            }
            else if (a == "2")
            {
                Console.WriteLine("Введите длину основания a треугольника");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите длину стороны b треугольника");
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите длину стороны c треугольника");
                z = Convert.ToDouble(Console.ReadLine());

                if ((x * x) == ((y * y)+(z * z)))                               //Проверка
                {
                    Console.WriteLine("Треугольник является прямоугольным");    //на то
                }
                else Console.WriteLine("Треугольник НЕ является прямоугольным");//является ли треугольник прямоугольным

                p = (x + y + z) / 2;
                S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));

                Console.WriteLine($"Площадь треугольника = {S}");
                Console.ReadKey();

            }
        }
    }
}


