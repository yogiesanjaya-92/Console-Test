namespace ClassLibrary
{
    public interface IRemote
    {
        bool isComplete { get; set; }
        double remoteHours { get; set; }
        string remoteIP { get; set; }
        IPerson user { get; set; }

        void completeRemote();
        void performRemote(double hours);
    }
}