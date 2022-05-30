using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    internal class Child : BaseClass
    {
        public void Method2()
        {
            BaseMethod();
        }
    }
}
