﻿using BookStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.UI
{
    public class ConsoleRenderer:IRenderer
    {
        public void WriteLine(string message, params string[] parameters)
        {
            Console.WriteLine(message, parameters);
        }
    }
}
