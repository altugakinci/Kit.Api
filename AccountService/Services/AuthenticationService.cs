using AccountService.Requests.Authentication;
using AccountService.Responses.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace AccountService.Services;

public interface IAuthenticationService
{
    ActionResult<RegisterResponse> Register(RegisterRequest request);
    ActionResult<LoginResponse> Login(LoginRequest request);
    ActionResult ConfirmEmail(ConfirmEmailRequest request);
    ActionResult ForgotPassword(ForgotPasswordRequest request);
    ActionResult PersistPassword(PersistPasswordRequest request);
}

public partial class AuthenticationService : IAuthenticationService
{
    public ActionResult<RegisterResponse> Register(RegisterRequest request)
    {
        throw new NotImplementedException();
    }

    public ActionResult<LoginResponse> Login(LoginRequest request)
    {
        throw new NotImplementedException();
    }

    public ActionResult ConfirmEmail(ConfirmEmailRequest request)
    {
        throw new NotImplementedException();
    }

    public ActionResult ForgotPassword(ForgotPasswordRequest request)
    {
        throw new NotImplementedException();
    }

    public ActionResult PersistPassword(PersistPasswordRequest request)
    {
        throw new NotImplementedException();
    }
}

partial class AuthenticationService
{
    
}
