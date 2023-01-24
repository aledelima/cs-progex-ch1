//Microsoft (R) Visual C# Compiler version 3.4.0-beta4-19562-05 (ff930dec)
//Copyright (C) Microsoft Corporation. All rights reserved.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            // “Cowards die many times before their deaths; the valiant never taste of death but once”
            Console.Write("Output #1\n");
            Console.Write(" Cowards die many times before their deaths; the valiant never taste of death but once\n\n");
            Console.Write("Output #2\n");
            Console.Write(" Cowards die many times\n before their deaths;\n the valiant never taste of death but once\n\n");        
            Console.Write("Output #3\n");
            Console.Write(" Cowards\n die\n many\n times\n before\n their\n deaths;\n the\n valiant\n never\n taste\n of\n death\n but\n once\n\n");        
        }
    }
}