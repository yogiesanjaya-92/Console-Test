using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Messager : IMessager
    {
        public void sendEmail(IPerson person, string message)
        {
            Console.WriteLine($"Simulating Sending an Email to {person.Email} -> {message}");
        }
    }
}
