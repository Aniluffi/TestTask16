using MessagePack;
using MessagePack.Resolvers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult.Comands
{
    class ComandSaveBinary : IComand
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
        public ComandSaveBinary( ListFigure<Figure> _listEnteredShapes)
        {
            NameComand = "сохранить_бинар";
            this._listEnteredShapes = _listEnteredShapes;
        }

        /// <summary>
        /// команда для сохранения фигур в бинарном файле
        /// </summary>
        /// <param name="data">путь файла</param>
        public void Execute(string data)
        {
            try
            {
                Console.Clear();
                using (FileStream fs = new FileStream(data, FileMode.Append))
                using (BinaryWriter write = new BinaryWriter(fs))
                {
                    foreach(var figur in _listEnteredShapes)
                    {
                        figur.WriteBinary(write);
                    }
                }
                _listEnteredShapes.Clear();
                    Console.Clear();
                    Console.WriteLine("Данные сохранены");
                
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Не корректный файл {ex}");
            }
            catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine($"В это место нельзя сохранить файл или этот путь недостижим {e}");
            }
        }

      
    }
}

