using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult.Comands
{
    /// <summary>
    /// команда сохранения файла
    /// </summary>
    class ComandSaveFigure : IComand
    {

        /// <summary>
        /// список для хранения фигур
        /// </summary>
        ListFigure<Figure> _listEnteredShapes;

        /// <summary>
        /// название команды
        /// </summary>
        public string NameComand { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="paths">список со всеми сохраненными файлами</param>
        public ComandSaveFigure(ListFigure<Figure> _listEnteredShapes)
        {
            NameComand = "сохранить";
            this._listEnteredShapes = _listEnteredShapes;
        }

        /// <summary>
        /// команда для сохранения фигур
        /// </summary>
        /// <param name="data">путь файла</param>
        public void Execute(string data)
        {
            try
            {
                using (StreamWriter str = new StreamWriter(data, append: true))
                {
                    foreach (var el in _listEnteredShapes)
                    {
                        str.WriteLine(el.ToString());
                    }
                    _listEnteredShapes.Clear();
                    Console.Clear();
                    Console.WriteLine("Данные сохранены");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Не корректный файл {ex}");
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("В это место нельзя сохранить файл или этот путь недостижим");
            }
        }
    }
}
