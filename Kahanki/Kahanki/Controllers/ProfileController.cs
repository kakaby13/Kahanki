using Kahanki.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Kahanki.Controllers;

[Route("[controller]")]
public class ProfileController : ControllerBase
{
    public UserProfile GetNextProfile()
    {
        return new UserProfile();
    }
}
