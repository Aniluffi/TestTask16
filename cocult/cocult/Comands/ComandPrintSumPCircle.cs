namespace cocult.Comands
{
    /// <summary>
    /// команда для вывода суммы периметров всех введенных кругов
    /// </summary>
    class ComandPrintSumPCircle : IComand
    {
        /// <summary>
        /// поле для хранения фигур
        /// </summary>
        ListFigure<Figure> listEnteredShapes;
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandPrintSumPCircle(ListFigure<Figure> a)
        {
            NameComand = "вывод_суммы_периметров_всех_введенных_кругов";
            listEnteredShapes = a;
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумарная периметров кругов - {listEnteredShapes.PType<Circle>()}");
        }
    }
}
