using System.Configuration;
using System.Data;
using System.Windows;
using WhackerLinkLib.Models.Radio;

namespace WhackerLinkConsoleV2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Codeplug Codeplug { get; set; }

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public App()
        {
            //AllocConsole();
            //Console.WriteLine($"Debug: {Codeplug}");
            //if (Codeplug.Systems[0].debug)
            //{
            //    Console.WriteLine("Hello, world!");
            //}
        }
    }

}
