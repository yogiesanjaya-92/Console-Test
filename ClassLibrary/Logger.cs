using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Logger : ILogger
    {
        public void log(string message)
        {
            Console.WriteLine($"Write to Console: {message}");
        }
    }
}
