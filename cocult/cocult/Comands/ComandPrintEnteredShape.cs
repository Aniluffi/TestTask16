namespace cocult.Comands
{
    /// <summary>
    /// команда для вывода всех введенных фигур
    /// </summary>
    class ComandPrintEnteredShape : IComand
    {
        /// <summary>
        /// поле для хранения фигур
        /// </summary>
        ListFigure<Figure> listEnteredShapes;
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandPrintEnteredShape(ListFigure<Figure> listEnteredShapes)
        {
            NameComand = "вывод_всех_введенных_фигур";
            this.listEnteredShapes = listEnteredShapes;
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Введенные фигуры:\n  {listEnteredShapes.ToString()}");
        }
    }
}
