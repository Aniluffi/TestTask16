using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{

    /// <summary>
    /// интерфейс методов для класса Comands
    /// </summary>
    interface IComand
    {
        public string NameComand { get; set; }
        void Execute(string data);
    }
}
