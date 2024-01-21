using System;
using NLog;

// Add the NLog package and complete the tasks based on:
// https://pierresimondelaplace.gitlab.io/wsb-zaawansowane-techniki-obiektowe/WSB_ZaawansowaneTechnikiObiektowe.pdf

namespace AdapterPattern
{
    class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        static void Main()
        {
            var nLogAdapter = new NLogAdapter(Logger);
            var customController = new CustomController(nLogAdapter);

            customController.Get();

            Console.ReadLine();
        }
    }
}
