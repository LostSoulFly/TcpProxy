﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerProxy
{
    class Logger
    {
        public static void LogToConsole(string msg)
        {
            Console.WriteLine("{0}: {1}", DateTime.Now.ToLongTimeString(), msg);
        }
    }
}
