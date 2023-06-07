using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo
{
    public class Messeger
    {
        public static void Msg(string format)
        {
            Console.WriteLine(format);
        }
        public static void Error(string format)
        {
            Console.WriteLine("Error\t" + format);
            Environment.Exit(-1);
        }
        public static void Error(string format, int code) 
        { 
            Console.WriteLine("Error\t" + format);
            Environment.Exit(code);
        }
        public static void Expected(string format, int code)
        {
            Console.WriteLine("Expected\t" + format);
            Environment.Exit(code);
        }

    }
}
