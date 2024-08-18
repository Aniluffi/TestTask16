using MessagePack;
using MessagePack.Resolvers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cocult.Comands
{
    class ComandReadBinary : IComand
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
        public ComandReadBinary(ListFigure<Figure> _listEnteredShapes)
        {
            NameComand = "читать_бинар";
            this._listEnteredShapes = _listEnteredShapes;
        }

        /// <summary>
        /// команда для вывода сохраненных фигур в бинарном файле
        /// </summary>
        /// <param name="data">путь файла</param>
        public void Execute(string data)
        {
            Console.Clear();
            _listEnteredShapes.Clear();
            try
            {
                using (FileStream fs = new FileStream(data, FileMode.Open))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    
                    while (reader.PeekChar() > -1)
                    {
                        byte typeByte = reader.ReadByte();
                        switch ((Figurs)typeByte)
                        {
                            case Figurs.Rectengle:
                                _listEnteredShapes.Add(Rectangle.ReaderBinary(reader));
                                break;

                            case Figurs.Tringle:
                                _listEnteredShapes.Add( Triangle.ReaderBinary(reader));
                                break;

                            case Figurs.Square:
                                _listEnteredShapes.Add( Square.ReaderBinary(reader));
                                break;

                            case Figurs.Polygon:
                                _listEnteredShapes.Add(Polygon.ReaderBinary(reader, reader.ReadInt32()));
                                break;

                            case Figurs.Circle:
                                _listEnteredShapes.Add(Circle.ReaderBinary(reader));
                                break;

                            default:
                                throw new InvalidOperationException("Unknown figure type");
                        }
                    }
                }

                Console.WriteLine($"Файл загружен");
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Не корректный файл {ex}");
            }
        }

        
    }
}
