﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADproject
{
    class SeniorAgent : Employee
    {
        public SeniorAgent (string a, string b, string c)
        {
            Name = a;
            Id = b;
            Rank = c;
        }
    }
}
