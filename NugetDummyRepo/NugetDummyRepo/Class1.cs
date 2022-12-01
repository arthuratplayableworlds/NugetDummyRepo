using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;

namespace NugetDummyRepo;

public class Class1
{
    public static void PrintStuff()
    {
        var assembly = Assembly.GetAssembly(typeof(Class1));
        var version = FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion;
        
        
        Console.WriteLine($"This is the dummy repo version : {version}.");
        
        
    }
}