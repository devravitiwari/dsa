﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.List
{
    interface IList<T>
    {
        void Add(T item);
        bool Remove(T item);
    }
}
