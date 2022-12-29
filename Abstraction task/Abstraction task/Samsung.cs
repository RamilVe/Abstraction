using System;
using System.Collections.Generic;
using System.Text;

namespace Smartphones
{
    internal class Samsung:Smartphone
    {
        public Samsung(string model):base(model) 
        {

        }

        public override void Price()
        {
            Console.WriteLine("329 Azn");
        }
    }
}
