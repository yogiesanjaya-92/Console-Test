namespace ClassLibrary
{
    public interface IMessager
    {
        void sendEmail(IPerson person, string message);
    }
}