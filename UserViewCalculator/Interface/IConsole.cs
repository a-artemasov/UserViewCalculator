﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserViewCalculator.Interface
{
    public interface IConsole
    {
        public void WriteLine(string line);
        public string ReadLine();
    }
}
