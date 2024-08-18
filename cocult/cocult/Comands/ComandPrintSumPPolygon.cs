namespace cocult.Comands
{
    /// <summary>
    /// команда для вывода суммы периметров всех введенных многоугольников
    /// </summary>
    class ComandPrintSumPPolygon : IComand
    {
        /// <summary>
        /// поле для хранения фигур
        /// </summary>
        ListFigure<Figure> listEnteredShapes;
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandPrintSumPPolygon(ListFigure<Figure> listEnteredShapes)
        {
            NameComand = "вывод_суммы_периметров_всех_введенных_многоугольников";
            this.listEnteredShapes = listEnteredShapes;
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумарная периметров многоугольников - {listEnteredShapes.PType<Polygon>()}");
        }
    }
}
