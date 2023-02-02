using System;
using System.Runtime.InteropServices;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello from the a .NET 4.8 executable\n\n" +
                              $"Runtime .NET version {AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName}\n" +
                              $"System version {System.Runtime.InteropServices.RuntimeEnvironment.GetSystemVersion()}\n\n");

            


            Console.WriteLine(ClassLibraryNET4.Class1.GetRuntimeDotNetVersion());
        }
    }

}

