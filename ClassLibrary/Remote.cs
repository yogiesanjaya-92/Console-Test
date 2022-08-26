using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Remote : IRemote
    {
        private IMessager _messager;
        private ILogger _logger;


        public IPerson user { get; set; }
        public string remoteIP { get; set; }
        public double remoteHours { get; set; }
        public bool isComplete { get; set; }

        public Remote(IMessager messager, ILogger logger)
        {
            _messager = messager;
            _logger = logger;
        }

        public void performRemote(double hours)
        {
            remoteHours += hours;
            _logger.log($"Performerd remote to {remoteIP}");
        }

        public void completeRemote()
        {
            isComplete = true;

            _logger.log($"Completed remote to {remoteIP} for {remoteHours} hours");

            _messager.sendEmail(user, $"The {remoteIP} has been remoted {remoteHours} hours");
        }
    }
}
