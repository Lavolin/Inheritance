using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
     class BaseClass
    {
        private int x; // вижда се само в този клас
        internal int y; // вижда се от всички в този проект "AccessModifiers"
        public int z; // всеки го вижда
        protected int q; // вижда се в този клас и децата му

        protected void BaseMethod()
        {
            this.x = 5; 
        }
    }
}
