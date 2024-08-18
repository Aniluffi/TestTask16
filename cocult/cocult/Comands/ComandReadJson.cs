using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace cocult.Comands
{
    class ComandReadJson : IComand
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
        public ComandReadJson( ListFigure<Figure> _listEnteredShapes)
        {
            NameComand = "читать_json";
            this._listEnteredShapes = _listEnteredShapes;
        }

        public async void Execute(string data)
        {
            Console.Clear();
            _listEnteredShapes.Clear();
            using (FileStream fs = new FileStream(data, FileMode.Open))
            {
                var options = new JsonSerializerOptions
                {
                    Converters = { new ShapeConverter() },
                    WriteIndented = true
                };

                ListFigure<Figure> figures = await JsonSerializer.DeserializeAsync<ListFigure<Figure>>(fs, options) ?? new ListFigure<Figure>();
                foreach (var el in figures)
                {
                    _listEnteredShapes.Add(el);
                }
                Console.WriteLine("Данные загружены");
            }
            
        }
    }
}
