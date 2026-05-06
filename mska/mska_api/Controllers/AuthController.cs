
using Microsoft.AspNetCore.Mvc;
using mska_service.DTOs;
using mska_service.Interfaces;

namespace mska_api.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService service)
        {
            _authService = service;
        }

        [HttpPost("login")]
        public ActionResult Login(LoginRequest request)
        {
            var token = _authService.Login(request.Username, request.Password);

            if (token == null)
                return Unauthorized("Sai tài khoản hoặc mật khẩu");

            return Ok(new { token });
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            var token = Request.Headers["Authorization"]
                .ToString()
                .Replace("Bearer ", "");

            _authService.Logout(token);

            return Ok("Logged out");
        }
    }
}
