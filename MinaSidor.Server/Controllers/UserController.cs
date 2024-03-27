using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.UserGroup;
using Service;
using Service.UserModel;
using Core.DataCore;
namespace MinaSidor.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController(UserService userService, IUserModel UserModel) : ControllerBase
    {
        private readonly UserService _userService = userService;
        private readonly IUserModel _userModel = UserModel;
        [HttpPost]
        public async Task<AppResponse<bool>> Register(UserRegisterRequest req)
        {
            return await _userService.UserRegisterAsync(req);
        }
        [HttpGet]
        public async Task<Customer> Getfulluser(int CustomerId)
            {
            return await _userModel.GetfullUser(34);
            }

        [HttpPost]
        public async Task<AppResponse<UserLoginResponse>> Login(UserLoginRequest req)
        {
            return await _userService.UserLoginAsync(req);
        }

        [HttpPost]
        public async Task<AppResponse<UserRefreshTokenResponse>> RefreshToken(UserRefreshTokenRequest req)
        {
            return await _userService.UserRefreshTokenAsync(req);
        }
        [HttpPost]
        public async Task<AppResponse<bool>> Logout()
        {
            return await _userService.UserLogoutAsync(User);
        }

        [HttpPost]
        [Authorize]
        public string Profile()
        {
            return User.FindFirst("UserName")?.Value ?? "";
        }
    }
}
