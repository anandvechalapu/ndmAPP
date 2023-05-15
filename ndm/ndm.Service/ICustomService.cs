using ndm.DTO;

namespace ndm.Service
{
    public interface ICustomService
    {
        Task SendMessageAsync(string message);
        Task<string> GetMessageAsync();
    }
}