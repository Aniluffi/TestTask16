using MessagePack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс,для работы с прямоугольником
    /// </summary>
    [MessagePackObject]
    public class Rectangle :Figure
    {
        public override string Type => "Rectangle";

        /// <summary>
        /// название фигуры
        /// </summary>
        public static readonly string name = "прямоугольник";

        /// <summary>
        /// поле хранящее сторону 1 прямоугольника
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// поле хранящее сторону 2 прямоугольника
        /// </summary>
        
        public double B { get; set; }


        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="a">ввод стороны 1 прямоугольника</param>
        /// <param name="b">ввод стороны 2 прямоугольника</param>
        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public Rectangle()
        {
        }

        public Rectangle(List<int> n)
        {
            A = n[0];
            B = n[1];
        }

        /// <summary>
        /// метод для вычисления площади прямоугольника
        /// </summary>
        /// <returns>возращает площадь</returns>
        public override double S()
        {
            return A * B;
        }

        /// <summary>
        /// метод для вычисления периметра прямоугольника
        /// </summary>
        /// <returns>возращает периметр</returns>
        public override double P()
        {
            return A + B * 2;
        }

        /// <summary>
        /// метод для вывода информации о прямоугольнике
        /// </summary>
        public override string ToString()
        {
            return $"Прямоугольник A = {A} B = {B}";
        }
        public override void WriteBinary(BinaryWriter writer)
        {
            
            writer.Write((byte)Figurs.Rectengle);
            
            writer.Write((int)A);
           
            writer.Write((int)B);
        }
        public static Rectangle ReaderBinary(BinaryReader reader, int n = 0)
        {
            int a = reader.ReadInt32();
            int b = reader.ReadInt32();
            
            return new Rectangle(a, b);
        }
    }
}
