using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace DependencyInjection
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IRemote CreateRemote()
        {
            return new Remote(CreateMessager(), CreateLogger());
        }

        public static IMessager CreateMessager()
        {
            return new Messager();
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }
    }
}
