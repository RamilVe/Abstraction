using System;
using System.Collections.Generic;
using System.Text;

namespace Smartphones
{
    internal class Nokia:Smartphone
    {
        public Nokia(string model) : base(model)
        {

        }

        public override void Price()
        {
            Console.WriteLine("430 Azn");
        }
    }
}
