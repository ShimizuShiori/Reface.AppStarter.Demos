using System;

namespace Reface.AppStarter.Demos.ScanEntities
{
    class Program
    {
        static void Main(string[] args)
        {
            AppSetup.Start<DemoAppModule>();
            Console.ReadLine();
        }
    }
}
