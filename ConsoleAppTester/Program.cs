﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liga;

namespace ConsoleAppTester
{
    class Program
    {
        static void Main(string[] args)
        {
            NbaLigaRepository drzave = new NbaLigaRepository();
            drzave.GetLiga();
            Console.ReadKey();
        }
    }
}
