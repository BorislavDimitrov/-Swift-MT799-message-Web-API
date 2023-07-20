using Models;

namespace Services.Messages
{
    public interface IMessagesService
    {
        Task<Message> SaveMessageAsync(string MTmessage);
    }
}
