namespace cocult.Comands
{
    /// <summary>
    /// команда для нахождения суммы площади всех введенных фигур
    /// </summary>
    class ComandAllS : IComand
    {
        /// <summary>
        /// поле для хранения фигур
        /// </summary>
        ListFigure<Figure> listEnteredShapes;
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandAllS(ListFigure<Figure> listEnteredShapes)
        {
            NameComand = "сумма_площадей_всех_введенных_фигур";
            this.listEnteredShapes = listEnteredShapes;
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумма всех S = {listEnteredShapes.SType<Figure>()}");
        }
    }
}
