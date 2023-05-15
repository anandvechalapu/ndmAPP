using ndm.DataAccess;
using ndm.DTO;

namespace ndm.Service
{
    public class CustomService : ICustomService
    {
        private readonly IDataAccess _dataAccess;

        public CustomService(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task SendMessageAsync(string message)
        {
            // Implement code to send message
            var messageDto = new MessageDto
            {
                Message = message
            };
            await _dataAccess.SendMessageAsync(messageDto);
        }
 
        public async Task<string> GetMessageAsync()
        {
            // Implement code to get message
            var messageDto = await _dataAccess.GetMessageAsync();
            return messageDto.Message;
        }
    }
}