using System;
using System.Globalization;
using System.Resources;

namespace Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new ResourceManager(typeof(Program));

            CultureInfo.CurrentCulture = new CultureInfo("sv");
            CultureInfo.CurrentUICulture = new CultureInfo("sv");

            Console.WriteLine(manager.GetString("Test"));
            Console.ReadLine();
        }
    }
}