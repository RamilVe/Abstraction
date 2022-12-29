using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    internal interface IGun
    {
        int CurrentMagazine { get; set; }
        int MagazineCapacity { get; set; }

        
    }
}
