// 2018 - 2023 (C) AutoSync Nucleo Team


using System;

using Nucleo;


namespace Nucleo
{
    class Program
    {
        private static Version appversion = new Version(1, 0, 0);
        private static void Main(string[] args)
        {
            switch (args.Length)
            {
                case 0:
                    ShowVersion();
                    break;
                case 1:
                    ProcessCommand(args[0]);
                    break;
                case 2:
                    ProcessPairCommand(args[0], args[1]);
                    break;
                case 3:
                    ProcessExpressionCommand(args[0], args[1], args[2]);
                    break;
                default:
                    Messeger.Error("Not Recognize commands", 1000);
                    break;
            }
        }

        private static void ShowVersion()
        {
            Messeger.Msg("Nucleo Team 2023 V" + appversion.ToString());
        }
        private static void ProcessCommand(string arg)
        {
            
           switch(arg)
            {
                case "-v":
                    ShowVersion();
                    break;
                case "run":
                    Messeger.Msg("Running server");
                    break;
                case "update":
                    ShowVersion();
                    Messeger.Msg("Nucleo is running its newest version");
                    break;
                default:
                    Messeger.Error("Not argument recognized", 1010);
                    break;

            }

        }
        static void ProcessPairCommand(string first, string second)
        {
            switch (first)
            {
                case "import":
                    ProcessImport(second);
                    break;
                case "compile":
                    ProcessCompile(second);
                    break;
                case "run":
                    ProcessRun(second);
                        break;
            }
        }
    
        private static void ProcessImport(string command)
        {

        }
        private static void ProcessCompile(string command)
        {
            Messeger.Msg("Compile Using Nuclidium Engine");

        }
        private static void ProcessExpressionCommand(string first, string second, string third)
        {

        }
        private static void ProcessRun(string command)
        {

        }
        private static void ProcessOperation(string[] args)
        {

        }

      

       
        
    }
}