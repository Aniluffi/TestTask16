using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс,для работы с треугольником
    /// </summary>
    [MessagePackObject]
    public class Triangle :Figure
    {
        public override string Type => "Triangle";

        /// <summary>
        /// название фигуры
        /// </summary>

        public static readonly string name = "треугольник";

        /// <summary>
        /// поле хранящее сторону 1 треуголника
        /// </summary>
        
        public double A { get; set; }
        /// <summary>
        /// поле хранящее сторону 2 треуголника
        /// </summary>
    
        public double B { get; set; }
        /// <summary>
        /// поле хранящее сторону 3 треуголника
        /// </summary>
      
        public double C { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="a">ввод точки 1 треуголника </param>
        /// <param name="b">ввод точки 2 треуголника</param>
        /// <param name="c">ввод точки 3 треуголника</param>
        public Triangle(Point a, Point b, Point c)
        {
           A = MathGeometry.DistanceSquared(a,b);
            B = MathGeometry.DistanceSquared(b,c);
            C = MathGeometry.DistanceSquared(c,a);
        }

        public Triangle()
        {
        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="a">ввод стороны 1 треуголника </param>
        /// <param name="b">ввод стороны 2 треуголника</param>
        /// <param name="c">ввод стороны 3 треуголника</param>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public Triangle(List<int> n)
        {
            if (n.Count > 3)
            {
                A = MathGeometry.DistanceSquared(new Point(n[0], n[1]), new Point(n[2], n[3]));
                B = MathGeometry.DistanceSquared(new Point(n[2], n[3]), new Point(n[4], n[5]));
                C = MathGeometry.DistanceSquared(new Point(n[4], n[5]), new Point(n[0], n[1]));
            }
            else
            {
                A = n[0];
                B = n[1];
                C = n[2];
            }
        }

        /// <summary>
        /// метод для вычисления площади треугольника
        /// </summary>
        /// <returns>возращает площадь</returns>
        public override double S()
        {
            double p = MathGeometry.p(P());

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        /// <summary>
        /// метод для вычисления периметра треугольника
        /// </summary>
        /// <returns>возращает периметр</returns>
        public override double P()
        {           
            return MathGeometry.TringleP(A,B,C);
        }

        /// <summary>
        /// метод для вывода информации о треугольнике
        /// </summary>
        public override string ToString()
        {
            return $"Треугольник A = {(int)A} B = {(int)B} C = {(int)C}";
        }
        public override void WriteBinary(BinaryWriter writer)
        {
            
            writer.Write((byte)Figurs.Tringle);
            
            writer.Write((int)A);
            
            writer.Write((int)B);
            
            writer.Write((int)C);
        }
        public static Triangle ReaderBinary(BinaryReader reader, int n = 0)
        {
            int a = reader.ReadInt32();
            int b = reader.ReadInt32();
            int c = reader.ReadInt32();
            return new Triangle(a,b,c);
        }
    }
}
