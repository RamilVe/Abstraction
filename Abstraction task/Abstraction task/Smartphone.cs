using System;
using System.Collections.Generic;
using System.Text;

namespace Smartphones
{
    internal abstract class Smartphone
    {
        public Smartphone(string model)
        {
            this.Model = model;
        }
        public string Brand;
        public string Model;

        public abstract void Price();
    }
}
