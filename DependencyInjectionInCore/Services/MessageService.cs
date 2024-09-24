namespace DependencyInjectionInCore.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "This is the message from the Message Service";
        }
    }
}
