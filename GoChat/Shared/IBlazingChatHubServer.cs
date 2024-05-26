using GoChat.Shared.DTOs;

namespace GoChat.Shared
{
    public interface IBlazingChatHubServer
    {
        Task SetUserOnline(UserDto user);
    }
}
