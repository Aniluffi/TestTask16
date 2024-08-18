namespace cocult.Comands
{
    /// <summary>
    /// команда для вывода суммы периметров всех введенных квадратов
    /// </summary>
    class ComandPrintSumPSquare : IComand
    {
        /// <summary>
        /// поле для хранения фигур
        /// </summary>
        ListFigure<Figure> listEnteredShapes;
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }
        public ComandPrintSumPSquare(   ListFigure<Figure> listEnteredShapes)
        {
            NameComand = "вывод_суммы_периметров_всех_введенных_квадратов";
            this.listEnteredShapes = listEnteredShapes;
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумарная периметров квадратов - {listEnteredShapes.PType<Square>()}");
        }
    }
}
