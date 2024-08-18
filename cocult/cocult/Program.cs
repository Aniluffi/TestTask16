using cocult;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;
using System.Text;
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Reflection;
using cocult.Comands;

class Program
{

    /// <summary>
    /// точка входа в приложение
    /// </summary> 
    public static void Main()
    {
        App app = new App();
        app.Run();

    }
}
