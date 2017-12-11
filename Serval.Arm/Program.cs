using System;

using Serval.Domain;

namespace Serval.Arm
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringProvider = new StringProvider();
            Console.WriteLine(stringProvider.GetString());
        }
    }
}
