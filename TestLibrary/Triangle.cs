using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    /// <summary>
    /// Класс прямоугольного треугольника )
    /// </summary>
    public class Triangle
    {

        double A { get; set; }
        double B { get; set; }
        double C { get; set; }

        /// <summary>
        /// Создание треугольника
        /// </summary>
        /// <param name="a">Длина cтороны A</param>
        /// <param name="b">Длина cтороны B</param>
        /// <param name="c">Длина cтороны C</param>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0)
                throw new System.ArgumentException("Параметр не может быть отрицательным", "a");
            if (b <= 0)
                throw new System.ArgumentException("Параметр не может быть отрицательным", "b");
            if (c <= 0)
                throw new System.ArgumentException("Параметр не может быть отрицательным", "c");

            A = a;
            B = b;
            C = c;
        }



        /// <summary>
        /// Площадь прямоугольного треугольника
        /// </summary>
        public double Area
        {
            get
            {
                double semiPerimeter = Perimeter / 2;
                return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
            }
        }

        /// <summary>
        /// Периметр треугольника
        /// </summary>
        public double Perimeter
        {
            get
            {
                return A + B + C;
            }
        }


    }
}
