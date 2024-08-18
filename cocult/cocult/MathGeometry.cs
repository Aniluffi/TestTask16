using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс для геометрических операций
    /// </summary>
     static class MathGeometry
    {
        /// <summary>
        /// Вычисляет квадрат расстояния между двумя точками.
        /// </summary>
        /// <param name="point1">точка 1</param>
        /// <param name="point2">точка 2</param>
        /// <returns></returns>
        public static double DistanceSquared(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }

        /// <summary>
        /// нахождение полупериметра
        /// </summary>
        /// <param name="P">периметр</param>
        /// <returns>возращает полупериметр</returns>
        public static double p(double P)
        {
            return P / 2;
        }

        /// <summary>
        /// метод возращающиц периметр треугольника
        /// </summary>
        /// <param name="a">сторона треугольника1</param>
        /// <param name="b">сторона треугольника2</param>
        /// <param name="c">сторона треугольника3</param>
        /// <returns></returns>
        public static double TringleP(double a, double b,double c)
        {
            return a + b + c;
        }

        public static double TringleS(double a, double b, double c)
        {
            double p = MathGeometry.p(TringleP(a,b,c));

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        /// <summary>
        /// метод возращающий периметр квадрата
        /// </summary>
        /// <param name="a">сторона квадрата</param>
        /// <returns>возращает периметр квадрата</returns>
        public static double SquareP(double a)
        {
            return a * 4;
        }

        /// <summary>
        /// метод возращающий площадь квадрата
        /// </summary>
        /// <param name="a">сторона квадрата</param>
        /// <returns>возращает площадь квадрата</returns>
        public static double SquareS(double a)
        {
            return a * a;
        }

        /// <summary>
        /// метод возращающий периметр прямоугольника
        /// </summary>
        /// <param name="a">сторона прямоугольника</param>
        /// <returns>возращает периметр прямоугольника</returns>
        public static double RectangleP(double a, double b)
        {
            return (a + b) * 2;
        }

        /// <summary>
        /// метод возращающий площадь прямоугольника
        /// </summary>
        /// <param name="a">сторона прямоугольника</param>
        /// <returns>возращает площадь прямоугольника</returns>
        public static double RectangleS(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// метод возращающий периметр круга
        /// </summary>
        /// <param name="r">радиус круга</param>
        /// <returns>возращает периметр круга</returns>
        public static double CircleP(double r)
        {
            return 2 * Math.PI * r;
        }

        /// <summary>
        /// метод возращающий площадь круга
        /// </summary>
        /// <param name="r">радиус круга</param>
        /// <returns>возращает площадь круга</returns>
        public static double CircleS(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        
    }
}
