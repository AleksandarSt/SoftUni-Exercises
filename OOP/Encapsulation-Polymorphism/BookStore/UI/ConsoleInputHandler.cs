using BookStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.UI
{
    class ConsoleInputHandler:IInputHandler
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
