using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draven.Helpers
{
    public static class ConsoleHelper
    {
        private static void ColorPrint(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static void PrintError(this string msg)
        {
            ColorPrint(msg, ConsoleColor.Red);
        }

        public static void PrintSuccess(this string msg)
        {
            ColorPrint(msg, ConsoleColor.Green);
        }
    }
}
