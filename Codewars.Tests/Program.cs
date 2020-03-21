﻿using NUnit.Common;
using System;
using NUnitLite;

namespace Codewars.Tests
{
    class Program
    {
        static int Main(string[] args)
        {
            return new AutoRun(typeof(Program).Assembly)
                .Execute(args, new ExtendedTextWrapper(Console.Out), Console.In);
        }
    }
}
