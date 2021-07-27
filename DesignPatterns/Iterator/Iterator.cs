﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public interface Iterator<out T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}
