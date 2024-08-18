using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// специализированный лист для  типа фигуры
    /// </summary>
    public class ListFigure<T> : List<T> where T : Figure
    {
       /// <summary>
       /// метод для сложения периметров фигур или определенных
       /// </summary>
       /// <typeparam name="U">тип фигуры</typeparam>
       /// <returns>сложенные периметры</returns>
        public double PType<U>() where U : Figure
        {
            return this.OfType<U>().Sum(f => f.P());
        }

        /// <summary>
        /// метод для сложения площадей фигур или определенных
        /// </summary>
        /// <typeparam name="U">тип фигуры</typeparam>
        /// <returns>сложенные площади</returns>
        public double SType<U>() where U : Figure
        {
            return this.OfType<U>().Sum(f => f.S());
        }

        /// <summary>
        /// переопределенный метод превращения в строку
        /// </summary>
        /// <returns>строку</returns>
        public override string ToString()
        {
            string str = "";
            foreach (var figure in this)
            {
                str += figure.ToString() + "\n";
            }
            return str;
        }
    }
}
