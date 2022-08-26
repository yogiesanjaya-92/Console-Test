using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson person = Factory.CreatePerson();

            person.FirstName = "Yogie";
            person.LastName = "Sanjaya";
            person.Email = "sanjaya@mail.com";
            person.PhoneNumber = "08137775555";

            IRemote remoteAccess = Factory.CreateRemote();
            remoteAccess.remoteIP = "10.88.89.50";
            remoteAccess.user = person;

            remoteAccess.performRemote(2);
            remoteAccess.performRemote(1.5);

            remoteAccess.completeRemote();

            Console.ReadLine();
        }
    }
}
