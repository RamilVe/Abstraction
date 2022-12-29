using System;

namespace Smartphones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samsung samsung = new Samsung("Galaxy A13");

            Nokia nokia = new Nokia("G21");

            samsung.Price();
            nokia.Price();
        }
    }
}
