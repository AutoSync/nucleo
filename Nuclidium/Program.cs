using System;



namespace Nuclidium
{
    class Program
    {
        private static Version app_ver = new Version(1, 0, 0);
        static void Main(string[] args)
        {
            Console.WriteLine("2023 (C) AutoSync Nucleo(TM) Nuclidium(TM) - All Rights Reserved");
            Console.WriteLine(args.Length + " Arguments");

            foreach(var arg in args)
            {
                ProcessArgs(arg);
            }

        }
        private static void ProcessArgs(string  arg)
        {
            switch(arg)
            {
                case "-x":
                    Console.WriteLine("Process compile Nucleo to Cpp");
                    break;
                case "-v":
                    Console.WriteLine("Version" + app_ver.ToString());
                    break;
                case "-nx":
                    Console.WriteLine("Nucleo Interpreter");
                    break;
                default:
                    Console.WriteLine("Command not recognized");
                    break;

            }
        }

    }
}