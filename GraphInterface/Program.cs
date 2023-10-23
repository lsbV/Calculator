using System;
namespace GraphInterface
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            if (args.Length > 0)
            {
                
                //for console
            }
            else
            {
                Application.Run(new Form1());

            }

            
        }
       
    }
}