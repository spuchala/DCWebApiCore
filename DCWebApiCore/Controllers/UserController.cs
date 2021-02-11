using DCWebApiCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace DCWebApiCore.Controllers
{
    [Route("api/login")]
    public class UserController : ControllerBase
    {
        private UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }
    }
}
