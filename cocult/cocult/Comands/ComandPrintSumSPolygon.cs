namespace cocult.Comands
{
    /// <summary>
    /// команда для вывода суммы площадей всех введенных многоугольников
    /// </summary>
    class ComandPrintSumSPolygon : IComand
    {
        /// <summary>
        /// поле для хранения фигур
        /// </summary>
        ListFigure<Figure> listEnteredShapes;
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandPrintSumSPolygon(  ListFigure<Figure> listEnteredShapes)
        {
            NameComand = "вывод_суммы_площадей_всех_введенных_многоугольников";
            this.listEnteredShapes = listEnteredShapes;
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумарная площадь многоугольников - {listEnteredShapes.SType<Polygon>()}");
        }
    }
}
