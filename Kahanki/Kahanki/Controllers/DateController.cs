using System.Security.Claims;
using Kahanki.Services;
using Kahanki.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Kahanki.Controllers;

[Route("[controller]")]
public class DateController : ControllerBase
{
    private readonly IUserProfileService _userProfileService;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public DateController(
        IUserProfileService userProfileService,
        IHttpContextAccessor httpContextAccessor)
    {
        _userProfileService = userProfileService;
        _httpContextAccessor = httpContextAccessor;
    }

    [HttpGet("GetNextProfile")]
    public UserProfile? GetNextProfile()
    {
        var currentUserId = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        return _userProfileService.GetNextUserProfileByUserId(currentUserId);
    }

    [HttpGet("SubmitUserAction")]
    public void SubmitUserAction(string targetUserId, int actionId)
    {
        var currentUserId = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        _userProfileService.SubmitUserAction(currentUserId, targetUserId, actionId);
    }


}
