using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal abstract class Gun
    {
        public int CurrrentMagazine;
        public int MagazineCapacity;

        public abstract void Fire();
    }
}
