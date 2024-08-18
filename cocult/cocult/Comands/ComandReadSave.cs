using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult.Comands
{
    /// <summary>
    /// команда для чтения сохраненных файлов
    /// </summary>
    class ComandReadSave: IComand
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
        /// <param name="paths">список сохраненных файлов</param>
        public ComandReadSave( ListFigure<Figure> _listEnteredShapes)
        {
            NameComand = "читать";
            this._listEnteredShapes = _listEnteredShapes;
        }

        /// <summary>
        /// команда для вывода сохраненных фигур
        /// </summary>
        /// <param name="data">путь файла</param>
        public void Execute(string data)
        {
            Console.Clear();
            try
            {

                 ReadFile(data);
            }
            catch (IOException ex)
            {
                Console.Clear();
                Console.WriteLine($"Не корректный файл {ex}");
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("не правильно введен файл или такого не существует");
            }
        }

        private void ReadFile(string path)
        {
            Console.Clear();
            using (StreamReader fs = new StreamReader(path))
            {
                ListFigure<Figure> list = new ListFigure<Figure>();
                string line;
                Console.WriteLine($"Фигуры из файла {path}");
                while ((line = fs.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(" ", 2);
                    _listEnteredShapes.Clear();
                    CreateFigure(words[0], words[1]);
                }
            }
        }

        /// <summary>
        /// метод для создания обьектов figure из строки
        /// </summary>
        /// <param name="figur">название фигуры</param>
        /// <param name="parametrs">параметры фигуры</param>
        private void CreateFigure(string figur, string parametrs)
        {
            if (figur.ToLower() == Circle.name) _listEnteredShapes.Add(new Circle(App.ToParametrs(parametrs)));
            if (figur.ToLower() == Polygon.name) _listEnteredShapes.Add(new Polygon(App.ToParametrs(parametrs)));
            if (figur.ToLower() == Triangle.name) _listEnteredShapes.Add(new Triangle(App.ToParametrs(parametrs)));
            if (figur.ToLower() == Square.name) _listEnteredShapes.Add(new Square(App.ToParametrs(parametrs)));
            if (figur.ToLower() == Rectangle.name) _listEnteredShapes.Add(new Rectangle(App.ToParametrs(parametrs)));
        }
    }
}
