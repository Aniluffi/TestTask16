using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// класс для хранения точек
    /// </summary>
    
    public class Point
    {
        /// <summary>
        /// поле для хранения x вершины
        /// </summary>
        
        public int X { get; set; }
        /// <summary>
        /// поле для хранения y вершины
        /// </summary>
       
        public int Y { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="x">координата x</param>
        /// <param name="y">координата y</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {
        }

        /// <summary>
        /// метод для превращения в строку
        /// </summary>
        /// <returns>строку</returns>
        public override string ToString()
        {
            return $"( {X} ; {Y} )";
        }
        /// <summary>
        ///метод который определяет запись фигуры
        /// </summary>
        /// <param name="writer"></param>
        public void WriteBinary(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
        }
        /// <summary>
        /// абстрактный метод который определяет чтения фигуры
        /// </summary>
        /// <param name="writer"></param>
        public void ReaderBinary(BinaryReader reader,List<Point> points)
        {
            int x = BitConverter.ToInt32(reader.ReadBytes(4));
            int y = BitConverter.ToInt32(reader.ReadBytes(4));
            points.Add(new Point(x,y));
        }
    }
}
