using AccountService.Requests.Authentication;
using AccountService.Responses.Authentication;
using AccountService.Services;
using Microsoft.AspNetCore.Mvc;

namespace AccountService.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public ActionResult<RegisterResponse> Register(RegisterRequest request) => _authenticationService.Register(request);

        [HttpPost("login")]
        public ActionResult<LoginResponse> Login(LoginRequest request) => _authenticationService.Login(request);

        [HttpPost("confirmEmail")]
        public ActionResult ConfirmEmail(ConfirmEmailRequest request) => _authenticationService.ConfirmEmail(request);

        [HttpPost("forgotPassword")]
        public ActionResult ForgotPassword(ForgotPasswordRequest request) => _authenticationService.ForgotPassword(request);

        [HttpGet("persistPassword/{Email}")]
        public ActionResult PersistPassword(PersistPasswordRequest request) => _authenticationService.PersistPassword(request);
    }
}
