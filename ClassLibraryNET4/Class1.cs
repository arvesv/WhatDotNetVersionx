using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ClassLibraryNET4
{
    public static class Class1
    {
        public static string GetRuntimeDotNetVersion()
        {
            return "Hello from the a .NET 4.5 assembly\n\n" +
                   $"Runtime .NET version {AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName}\n" +
                   $"System version {System.Environment.Version.ToString()}\n";
        }
    }
}
