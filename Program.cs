// See https://aka.ms/new-console-template for more information
using System.Net;

Console.WriteLine("Hello, World!");


public static class Class1
{
    public static void Method1()
    {
        var protocolType = SecurityProtocolType.Ssl3;
        Console.WriteLine(protocolType);
    }

    public static void Method2(string relativePath)
    {
        var path = $"{Environment.CurrentDirectory}/{relativePath}";
        Console.WriteLine(path);
    }
}