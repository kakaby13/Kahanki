using System.Security.Claims;
using Kahanki.Services;
using Kahanki.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Kahanki.Controllers;

[Route("[controller]")]
public class ChatController : ControllerBase
{
    private readonly IChatService _chatService;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ChatController(
        IChatService chatService, 
        IHttpContextAccessor httpContextAccessor)
    {
        _chatService = chatService;
        _httpContextAccessor = httpContextAccessor;
    }

    [HttpGet("GetChatList")]
    public List<UserShortProfile> GetChatList()
    {
        var currentUserId = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        return _chatService.GetChatListByUserId(currentUserId);
    }

    [HttpGet("GetChatByTargetUserId")]
    public ChatModel GetChatByTargetUserId(string targetUserId)
    {
        var currentUserId = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        return _chatService.GetChat(currentUserId, targetUserId);
    }
}