using System;

namespace DOTNET_CORE
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string arg in args) {
                Console.WriteLine($"Hello {arg}");
            }
        }
    }
}
