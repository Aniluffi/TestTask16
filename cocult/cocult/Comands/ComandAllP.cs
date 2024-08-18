namespace cocult.Comands
{
    /// <summary>
    /// команда для нахождения суммы периметров всех введенных фигур
    /// </summary>
    class ComandAllP : IComand
    {
        /// <summary>
        /// поле для хранения фигур
        /// </summary>
        ListFigure<Figure> listEnteredShapes;
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandAllP(ListFigure<Figure> listEnteredShapes)
        {
            NameComand = "сумма_периметров_всех_введенных_фигур";
            this.listEnteredShapes = listEnteredShapes;
        }


        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумма всех P = {listEnteredShapes.PType<Figure>()}");
        }
    }
}
