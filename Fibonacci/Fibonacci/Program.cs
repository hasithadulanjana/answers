﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            new FibController(new ConsoleView(), new FibonacciModel()).Runner();
        }
    }
}
